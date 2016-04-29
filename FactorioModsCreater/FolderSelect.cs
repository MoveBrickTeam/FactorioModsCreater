using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using FactorioAnalysis.FileAnalysis;

namespace FactorioModsCreater
{
    public partial class FolderSelect : Form
    {
        public FolderSelect()
        {
            InitializeComponent();
        }

        private void GameFolderSelect_Click(object sender, EventArgs e)
        {
           FolderBrowserDialog gamePathBrowserDialog=new FolderBrowserDialog();

            if (gamePathBrowserDialog.ShowDialog()==DialogResult.OK)
            {
                GameFolderPath.Text = gamePathBrowserDialog.SelectedPath;
            }
        }

        private void GameFolderConfirm_Click(object sender, EventArgs e)
        {
            string checkpath = GameFolderPath.Text + "\\data\\base\\data.lua";
            FileInfo fi = new FileInfo(checkpath);
            if (fi.Exists)
            {
                new FolderSet(GameFolderPath.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("您选择的不是游戏根目录!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
