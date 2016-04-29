using System.Net.Mime;
using System.Xml;
using LuaInterface;
using System;
using System.IO;
using System.Windows.Forms;

namespace FactorioAnalysis.FileAnalysis
{
    public class FolderSet
    {
        //base文件夹路径
        public static string BasePath { get; private set; }
        //core(lualib)文件夹路径
        public static string CorePath { get; private set; }

        private static string _gamePathXml = Application.StartupPath + "\\Data\\gamePath.xml";

        public FolderSet()
        {
            XmlDocument xd = new XmlDocument();
            xd.Load(_gamePathXml);
            XmlNode root = xd.SelectSingleNode("gamePath");
            XmlNode data = root.SelectSingleNode("basePath");
            XmlNode core = root.SelectSingleNode("corePath");
            BasePath = ((XmlElement) data).GetAttribute("path");
            CorePath = ((XmlElement) core).GetAttribute("path");
        }

        public FolderSet(string gameFolderPath)
        {
            BasePath = gameFolderPath + "\\data\\base\\";
            CorePath = gameFolderPath + "\\data\\core\\";
            XmlDocument xd = new XmlDocument();
            //创建根节点
            XmlElement root = xd.CreateElement("gamePath");
            xd.AppendChild(root);
            //创建子节点
            XmlElement data = xd.CreateElement("basePath");
            data.SetAttribute("path", BasePath);
            root.AppendChild(data);
            XmlElement core = xd.CreateElement("corePath");
            core.SetAttribute("path", CorePath);
            root.AppendChild(core);
            DirectoryInfo di=new DirectoryInfo(Application.StartupPath+"\\Data");
            if (!di.Exists)
            {
                di.Create();
            }
            xd.Save(_gamePathXml);
        }
    }
}