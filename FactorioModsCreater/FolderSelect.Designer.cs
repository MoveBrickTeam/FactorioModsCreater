namespace FactorioModsCreater
{
    partial class FolderSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderSelect));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.GameFolderPath = new System.Windows.Forms.TextBox();
            this.GameFolderSelect = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.GameFolderCancel = new System.Windows.Forms.Button();
            this.GameFolderConfirm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.WelcomeLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // WelcomeLabel
            // 
            resources.ApplyResources(this.WelcomeLabel, "WelcomeLabel");
            this.WelcomeLabel.Name = "WelcomeLabel";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.GameFolderPath, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.GameFolderSelect, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // GameFolderPath
            // 
            resources.ApplyResources(this.GameFolderPath, "GameFolderPath");
            this.GameFolderPath.Name = "GameFolderPath";
            // 
            // GameFolderSelect
            // 
            resources.ApplyResources(this.GameFolderSelect, "GameFolderSelect");
            this.GameFolderSelect.Name = "GameFolderSelect";
            this.GameFolderSelect.UseVisualStyleBackColor = true;
            this.GameFolderSelect.Click += new System.EventHandler(this.GameFolderSelect_Click);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.GameFolderCancel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.GameFolderConfirm, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // GameFolderCancel
            // 
            resources.ApplyResources(this.GameFolderCancel, "GameFolderCancel");
            this.GameFolderCancel.Name = "GameFolderCancel";
            this.GameFolderCancel.UseVisualStyleBackColor = true;
            // 
            // GameFolderConfirm
            // 
            resources.ApplyResources(this.GameFolderConfirm, "GameFolderConfirm");
            this.GameFolderConfirm.Name = "GameFolderConfirm";
            this.GameFolderConfirm.UseVisualStyleBackColor = true;
            this.GameFolderConfirm.Click += new System.EventHandler(this.GameFolderConfirm_Click);
            // 
            // FolderSelect
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FolderSelect";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox GameFolderPath;
        private System.Windows.Forms.Button GameFolderSelect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button GameFolderCancel;
        private System.Windows.Forms.Button GameFolderConfirm;
    }
}