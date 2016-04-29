using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using FactorioModsCreater.ApplicationInit;
using FactorioModsCreater.Properties;

namespace FactorioModsCreater
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void FMC_Main_Load(object sender, EventArgs e)
        {
            this.Icon = Resources.Main_Icon;
            WindowState = FormWindowState.Maximized;
        }

        private void Main_MainMenu_File_Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Main_MainMenu_File_New_Click(object sender, EventArgs e)
        {
            New newDialog=new New();
            //this.AddOwnedForm(newDialog);
            //newDialog.Activate();
            FormInit fi=new FormInit();
            fi.Init(newDialog);
            newDialog.Show();
        }
    }
}
