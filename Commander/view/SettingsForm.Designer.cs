namespace Commander.view
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.info = new System.Windows.Forms.Label();
            this.displayDialog = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.portNumber = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.logFilePath = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AllowDrop = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.title, "title");
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Name = "title";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.logFilePath);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.info);
            this.panel1.Controls.Add(this.displayDialog);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.portNumber);
            this.panel1.Controls.Add(this.save);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // info
            // 
            resources.ApplyResources(this.info, "info");
            this.info.Name = "info";
            // 
            // displayDialog
            // 
            resources.ApplyResources(this.displayDialog, "displayDialog");
            this.displayDialog.Name = "displayDialog";
            this.displayDialog.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.testConnection_Click);
            // 
            // portNumber
            // 
            resources.ApplyResources(this.portNumber, "portNumber");
            this.portNumber.Name = "portNumber";
            this.portNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
            // 
            // save
            // 
            this.save.AllowDrop = true;
            resources.ApplyResources(this.save, "save");
            this.save.Name = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // logFilePath
            // 
            resources.ApplyResources(this.logFilePath, "logFilePath");
            this.logFilePath.Name = "logFilePath";
            this.logFilePath.ReadOnly = true;
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox portNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox displayDialog;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox logFilePath;
    }
}