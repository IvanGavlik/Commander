namespace Commander.view
{
    partial class Template
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Template));
            this.header = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.help = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AllowDrop = true;
            this.header.BackColor = System.Drawing.SystemColors.Control;
            this.header.Controls.Add(this.title);
            resources.ApplyResources(this.header, "header");
            this.header.Name = "header";
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
            this.panel1.Controls.Add(this.help);
            this.panel1.Controls.Add(this.settings);
            this.panel1.Controls.Add(this.stop);
            this.panel1.Controls.Add(this.start);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // help
            // 
            resources.ApplyResources(this.help, "help");
            this.help.Name = "help";
            // 
            // settings
            // 
            resources.ApplyResources(this.settings, "settings");
            this.settings.Name = "settings";
            this.settings.Click += new System.EventHandler(this.setSettings);
            // 
            // stop
            // 
            this.stop.AllowDrop = true;
            resources.ApplyResources(this.stop, "stop");
            this.stop.Name = "stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // start
            // 
            resources.ApplyResources(this.start, "start");
            this.start.Name = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Template
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Template";
            this.Load += new System.EventHandler(this.Template_Load);
            this.header.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label settings;
        private System.Windows.Forms.Label help;
    }
}