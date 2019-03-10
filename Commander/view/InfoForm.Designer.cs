namespace Commander.view
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.info = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.info.BackColor = System.Drawing.Color.White;
            this.info.CausesValidation = false;
            resources.ApplyResources(this.info, "info");
            this.info.ForeColor = System.Drawing.Color.Black;
            this.info.Name = "info";
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.title, "title");
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Name = "title";
            // 
            // InfoForm
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.title);
            this.Controls.Add(this.info);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label title;
    }
}