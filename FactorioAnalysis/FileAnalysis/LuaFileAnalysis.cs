using System.Collections.Specialized;
using System.Xml;
using LuaInterface;

namespace FactorioAnalysis.FileAnalysis
{
    public abstract class LuaFileAnalysis
    {
        //private string _xmlOutput;
        protected static Lua Lua=new Lua();
        //protected static ListDictionary Ld;
        protected LuaFileAnalysis()
        {
            string coreFile = "?.lua";
            new FolderSet(@"D:\Steam\steamapps\common\Factorio");//TODO:测试用,发布时删掉
            var dataLoader = FolderSet.CorePath+ "\\lualib\\dataloader.lua";
            Lua.DoFile(dataLoader);
            //设定lua脚本路径,core是核心脚本,base是游戏基础模组的路径
            string setLuaPath = "package.path='" + FolderSet.CorePath+"\\lualib\\" + coreFile + ";"+FolderSet.BasePath+"?.lua'";
            setLuaPath = setLuaPath.Replace("\\", @"\\");//由于Luainterface在执行字符串指令时会转义,所以需要进行双重转义
            Lua.DoString(setLuaPath);
        }

        protected static void XmlNodeSort(XmlElement root)
        {
            if (root.ChildNodes.Count > 0)
            {
                Sort(root);
                foreach (var child in root.ChildNodes)
                {
                    XmlElement element = child as XmlElement;
                    if (element != null)
                    {
                        XmlNodeSort(element);
                    }

                }
            }
        }

        protected static void Sort(XmlElement xe)
        {
            for (int i = 0; i < xe.ChildNodes.Count; i++)
            {
                for (int j = 1; j < xe.ChildNodes.Count - i; j++)
                {
                    string one = xe.ChildNodes[j - 1].Attributes?["order"].Value;
                    string two = xe.ChildNodes[j].Attributes?["order"].Value;
                    if (string.CompareOrdinal(one, two) <= 0) continue;
                    XmlElement temp = (XmlElement)xe.ChildNodes[j];
                    xe.ReplaceChild(xe.ChildNodes[j - 1], xe.ChildNodes[j]);
                    xe.InsertBefore(temp, xe.ChildNodes[j - 1]);
                }
            }
        }

        public abstract void AnalysisFile();
        public abstract void AnalysisTable(ListDictionary ld,XmlNode insertNode);
        public abstract void ExportXml();
    }
}