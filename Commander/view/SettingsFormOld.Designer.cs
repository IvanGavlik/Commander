namespace Commander.view
{
    partial class SettingsFormOld
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
            this.save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.portNumber = new System.Windows.Forms.TextBox();
            this.testConnection = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save.AutoEllipsis = true;
            this.save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save.BackColor = System.Drawing.SystemColors.Highlight;
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.save.Location = new System.Drawing.Point(219, 334);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 1;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port";
            // 
            // portNumber
            // 
            this.portNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.portNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.portNumber.Location = new System.Drawing.Point(74, 13);
            this.portNumber.Name = "portNumber";
            this.portNumber.Size = new System.Drawing.Size(100, 22);
            this.portNumber.TabIndex = 6;
            this.portNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
            // 
            // testConnection
            // 
            this.testConnection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.testConnection.AutoEllipsis = true;
            this.testConnection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.testConnection.BackColor = System.Drawing.SystemColors.Highlight;
            this.testConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.testConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testConnection.Font = new System.Drawing.Font("Arial", 9.75F);
            this.testConnection.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.testConnection.Location = new System.Drawing.Point(193, 10);
            this.testConnection.Name = "testConnection";
            this.testConnection.Size = new System.Drawing.Size(123, 25);
            this.testConnection.TabIndex = 7;
            this.testConnection.Text = "Test Connection";
            this.testConnection.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.testConnection.UseVisualStyleBackColor = false;
            this.testConnection.Click += new System.EventHandler(this.testConnection_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.SystemColors.Highlight;
            this.info.Location = new System.Drawing.Point(12, 49);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(34, 20);
            this.info.TabIndex = 10;
            this.info.Text = "Off";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(328, 369);
            this.Controls.Add(this.info);
            this.Controls.Add(this.testConnection);
            this.Controls.Add(this.portNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.save);
            this.Name = "SettingsForm";
            this.Text = "Commander Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox portNumber;
        private System.Windows.Forms.Button testConnection;
        private System.Windows.Forms.Label info;
    }
}