using System.Collections.Specialized;
using System.Xml;
using LuaInterface;

namespace FactorioAnalysis.FileAnalysis
{
    public abstract class LuaFileAnalysis
    {
        private string _dataLoader;
        //private string _xmlOutput;
        protected static Lua Lua=new Lua();
        //protected static ListDictionary Ld;
        protected LuaFileAnalysis()
        {
            string coreFile = "?.lua";
            string baseFile = "data.lua";
            new FolderSet(@"D:\Steam\steamapps\common\Factorio");//TODO:测试用,发布时删掉
            _dataLoader = FolderSet.CorePath+ "\\lualib\\dataloader.lua";//data文件载入器的路径
            Lua.DoFile(_dataLoader);
            //设定lua脚本路径,core是核心脚本,base是游戏基础模组的路径
            string setLuaPath = "package.path='" + FolderSet.CorePath+"\\lualib\\" + coreFile + ";"+FolderSet.BasePath+"?.lua'";
            setLuaPath = setLuaPath.Replace("\\", @"\\");//由于Luainterface在执行字符串指令时会转义,所以需要进行双重转义
            Lua.DoString(setLuaPath);
        }

        public abstract void AnalysisFile();
        public abstract void AnalysisTable(ListDictionary ld,XmlNode insertNode);
        public abstract void ExportXml();
    }
}