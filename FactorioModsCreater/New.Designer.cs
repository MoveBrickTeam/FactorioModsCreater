namespace FactorioModsCreater
{
    partial class New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New));
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SavePanel = new System.Windows.Forms.TableLayoutPanel();
            this.Confirm = new System.Windows.Forms.Button();
            this.SavePathLabel = new System.Windows.Forms.Label();
            this.SavePath = new System.Windows.Forms.TextBox();
            this.SaveDirect = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ClassChoose = new System.Windows.Forms.GroupBox();
            this.Custom = new System.Windows.Forms.Button();
            this.Weapon = new System.Windows.Forms.Button();
            this.Metarial = new System.Windows.Forms.Button();
            this.Production = new System.Windows.Forms.Button();
            this.Logistical = new System.Windows.Forms.Button();
            this.ClassItem = new System.Windows.Forms.ListView();
            this.MainPanel.SuspendLayout();
            this.SavePanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.ClassChoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            resources.ApplyResources(this.MainPanel, "MainPanel");
            this.MainPanel.Controls.Add(this.SavePanel, 0, 1);
            this.MainPanel.Controls.Add(this.TopPanel, 0, 0);
            this.MainPanel.Name = "MainPanel";
            // 
            // SavePanel
            // 
            resources.ApplyResources(this.SavePanel, "SavePanel");
            this.SavePanel.Controls.Add(this.Confirm, 2, 1);
            this.SavePanel.Controls.Add(this.SavePathLabel, 0, 0);
            this.SavePanel.Controls.Add(this.SavePath, 1, 0);
            this.SavePanel.Controls.Add(this.SaveDirect, 2, 0);
            this.SavePanel.Controls.Add(this.Cancel, 3, 1);
            this.SavePanel.Name = "SavePanel";
            // 
            // Confirm
            // 
            resources.ApplyResources(this.Confirm, "Confirm");
            this.Confirm.Name = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            // 
            // SavePathLabel
            // 
            resources.ApplyResources(this.SavePathLabel, "SavePathLabel");
            this.SavePathLabel.Name = "SavePathLabel";
            // 
            // SavePath
            // 
            resources.ApplyResources(this.SavePath, "SavePath");
            this.SavePath.Name = "SavePath";
            // 
            // SaveDirect
            // 
            resources.ApplyResources(this.SaveDirect, "SaveDirect");
            this.SaveDirect.Name = "SaveDirect";
            this.SaveDirect.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            resources.ApplyResources(this.Cancel, "Cancel");
            this.Cancel.Name = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // TopPanel
            // 
            resources.ApplyResources(this.TopPanel, "TopPanel");
            this.TopPanel.Controls.Add(this.ClassChoose, 0, 0);
            this.TopPanel.Controls.Add(this.ClassItem, 1, 0);
            this.TopPanel.Name = "TopPanel";
            // 
            // ClassChoose
            // 
            resources.ApplyResources(this.ClassChoose, "ClassChoose");
            this.ClassChoose.Controls.Add(this.Custom);
            this.ClassChoose.Controls.Add(this.Weapon);
            this.ClassChoose.Controls.Add(this.Metarial);
            this.ClassChoose.Controls.Add(this.Production);
            this.ClassChoose.Controls.Add(this.Logistical);
            this.ClassChoose.Name = "ClassChoose";
            this.ClassChoose.TabStop = false;
            // 
            // Custom
            // 
            resources.ApplyResources(this.Custom, "Custom");
            this.Custom.Image = global::FactorioModsCreater.Properties.Resources.signals;
            this.Custom.Name = "Custom";
            this.Custom.UseVisualStyleBackColor = true;
            // 
            // Weapon
            // 
            resources.ApplyResources(this.Weapon, "Weapon");
            this.Weapon.Image = global::FactorioModsCreater.Properties.Resources.military;
            this.Weapon.Name = "Weapon";
            this.Weapon.UseVisualStyleBackColor = true;
            // 
            // Metarial
            // 
            resources.ApplyResources(this.Metarial, "Metarial");
            this.Metarial.Image = global::FactorioModsCreater.Properties.Resources.intermediate_products;
            this.Metarial.Name = "Metarial";
            this.Metarial.UseVisualStyleBackColor = true;
            // 
            // Production
            // 
            resources.ApplyResources(this.Production, "Production");
            this.Production.Image = global::FactorioModsCreater.Properties.Resources.production;
            this.Production.Name = "Production";
            this.Production.UseVisualStyleBackColor = true;
            // 
            // Logistical
            // 
            resources.ApplyResources(this.Logistical, "Logistical");
            this.Logistical.Image = global::FactorioModsCreater.Properties.Resources.logistics;
            this.Logistical.Name = "Logistical";
            this.Logistical.UseVisualStyleBackColor = true;
            this.Logistical.Click += new System.EventHandler(this.New_ClassChoose_Logistical_Click);
            // 
            // ClassItem
            // 
            resources.ApplyResources(this.ClassItem, "ClassItem");
            this.ClassItem.Name = "ClassItem";
            this.ClassItem.UseCompatibleStateImageBehavior = false;
            // 
            // New
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New";
            this.MainPanel.ResumeLayout(false);
            this.SavePanel.ResumeLayout(false);
            this.SavePanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.ClassChoose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.TableLayoutPanel TopPanel;
        private System.Windows.Forms.GroupBox ClassChoose;
        private System.Windows.Forms.Button Custom;
        private System.Windows.Forms.Button Weapon;
        private System.Windows.Forms.Button Metarial;
        private System.Windows.Forms.Button Production;
        private System.Windows.Forms.Button Logistical;
        private System.Windows.Forms.TableLayoutPanel SavePanel;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label SavePathLabel;
        private System.Windows.Forms.TextBox SavePath;
        private System.Windows.Forms.Button SaveDirect;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ListView ClassItem;
    }
}