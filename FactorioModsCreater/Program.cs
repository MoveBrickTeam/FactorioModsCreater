using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactorioAnalysis.FileAnalysis;
using FactorioModsCreater.ApplicationInit;
using log4net;
using log4net.Repository.Hierarchy;

namespace FactorioModsCreater
{
    internal static class Program
    {
        public static string lang = "zh_CN";
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FileInfo check=new FileInfo(Application.StartupPath+"\\Data\\gamePath.xml");
            if (!check.Exists)
            {
                FolderSelect folderSelect=new FolderSelect();
                folderSelect.ShowDialog();
                ShowMain();
            }
            else
            {
                ShowMain();
            }
        }

        private static void ShowMain()
        {
            Main main = new Main();
            FormInit fi = new FormInit();
            fi.Init(main);
            Application.Run(main);
        }
    }
}
