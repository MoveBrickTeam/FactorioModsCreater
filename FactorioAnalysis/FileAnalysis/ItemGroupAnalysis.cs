using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using LuaInterface;

namespace FactorioAnalysis.FileAnalysis
{
    public class ItemGroupAnalysis:LuaFileAnalysis
    {
        private static ListDictionary _ld;
        private static XmlDocument _outputDocument=new XmlDocument();
        private static XmlElement Root = _outputDocument.CreateElement("Root");
        
        public ItemGroupAnalysis() 
        {
        }

        public override void AnalysisFile()
        {
            Lua.DoFile(FolderSet.BasePath + "prototypes\\item\\item-groups.lua");
            Lua.DoFile(FolderSet.BasePath + "prototypes\\item\\demo-item-groups.lua");
            _ld = Lua.GetTableDict(Lua.GetTable("data.raw"));
            _outputDocument.AppendChild(Root);
            AnalysisTable(_ld,Root);
            ExportXml();
        }

        public override void AnalysisTable(ListDictionary lt, XmlNode insertNode)
        {
            /*
             * 1.判断当前lt是否有name键
             * 如果有,建立对应该lt的node a,将该lt的其他键值对放入该node的attr中
             * 判断lt的type,如果是item-subgroup:
             * --将该node a放入对应group名中的Node
             * --如果group对应Node不存在,就在insertNode中创建该节点
             * --如果存在,就不做操作
             * 如果是item-group
             * 先判断该item-group对应的Node是否存在,如果不存在
             * --创建该Node并补足属性
             * --如果存在
             * --将这个节点的属性补全
             * 如果遇到
             * 某个键对应的值为table,取出该table的ListDictionary以及当前node a,等到a写入document后进入递归
             * 如果没有name键,舍弃当前lt,遍历该lt下的键值对,每找到一个值为table的,就进入递归
             * 并且递归时的insertNode就是上级insertNode
             */
             /*TODO
              *排序问题,如何解决乱序插入?
              * 与当前已存在的节点的order属性做对比,如果当前要插入的节点的order值小于已存在Order的最小值,向前插,否则向后插;
              * 
              */
            if (lt.Contains("name"))
            {
                XmlElement curNode = _outputDocument.CreateElement(lt["name"].ToString());
                foreach (DictionaryEntry entry in lt)
                {
                    curNode.SetAttribute(entry.Key.ToString(), entry.Value.ToString());
                }
                if (!lt.Contains("group"))//如果节点类型是group(group是分类细表的目录,类似于属与种中的属)
                {
                
                    XmlElement checkNode = (XmlElement) _outputDocument.SelectSingleNode("Root/" + lt["name"].ToString());
                    if (checkNode==null)//判断该节点是否存在
                    {
                        //此处应有排序
                        insertNode.AppendChild(curNode);//不存在就在该节点的上级节点新建节点
                    }
                    else//存在
                    {
                        foreach (XmlAttribute attribute in curNode.Attributes)
                        {
                            checkNode.SetAttribute(attribute.Name,attribute.Value);//如果存在,将curNode中的所有Attr复制给Check
                        }
                    }
                }
                else//如果是item-subgroup(种)
                {
                    XmlElement check = (XmlElement) _outputDocument.SelectSingleNode("Root/" + lt["group"]);//判断当前物品类型的属是否存在
                    if (check==null)//不存在
                    {
                        //此处应有排序
                        check = _outputDocument.CreateElement(lt["group"].ToString());
                        Root.AppendChild(check);//根节点下添加该属
                    }
                    //此处应由排序
                    check.AppendChild(curNode);//将当前节点添加到属节点下
                }
            }
            else
            {
                foreach (var value  in lt.Values)
                {
                    LuaTable table=value as LuaTable;
                    if (table!=null)
                    {
                        AnalysisTable(Lua.GetTableDict(table),insertNode);
                    }
                }
            }

        }

        public override void ExportXml()
        {
            string xmlOutPut = Application.StartupPath + "\\Data\\Item_Group.xml";
            DirectoryInfo check=new DirectoryInfo(Application.StartupPath+"\\Data");
            if (!check.Exists)
            {
                check.Create();
            }
            XmlNodeSort(Root);
            _outputDocument.Save(xmlOutPut);
        }

        /*private void XmlNodeSort(XmlElement root)
        {
            if (root.ChildNodes.Count>0)
            {
                Sort(root);
                foreach (var child in root.ChildNodes)
                {
                    XmlElement element=child as XmlElement;
                    if (element!=null)
                    {
                        XmlNodeSort(element);
                    }
                    
                }
            }
        }

        private void Sort(XmlElement xe)
        {
            for (int i = 0; i < xe.ChildNodes.Count; i++)
            {
                for (int j = 1; j < xe.ChildNodes.Count-i; j++)
                {
                    string one = xe.ChildNodes[j - 1].Attributes?["order"].Value;
                    string two = xe.ChildNodes[j].Attributes?["order"].Value;
                    if (string.CompareOrdinal(one, two) <= 0) continue;
                    XmlElement temp = (XmlElement) xe.ChildNodes[j];
                    xe.ReplaceChild(xe.ChildNodes[j - 1], xe.ChildNodes[j]);
                    xe.InsertBefore(temp, xe.ChildNodes[j - 1]);
                }
            }
        }*/
    }
}