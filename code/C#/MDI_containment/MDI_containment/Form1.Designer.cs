namespace MDI_containment
{
    partial class Pform
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menufile = new System.Windows.Forms.ToolStripMenuItem();
            this.menufilenew = new System.Windows.Forms.ToolStripMenuItem();
            this.menufileexit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menufile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menufile
            // 
            this.menufile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menufilenew,
            this.menufileexit});
            this.menufile.Name = "menufile";
            this.menufile.Size = new System.Drawing.Size(40, 20);
            this.menufile.Text = "&File ";
            this.menufile.Click += new System.EventHandler(this.menufile_Click);
            // 
            // menufilenew
            // 
            this.menufilenew.Name = "menufilenew";
            this.menufilenew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menufilenew.Size = new System.Drawing.Size(152, 22);
            this.menufilenew.Text = "&New ";
            this.menufilenew.Click += new System.EventHandler(this.menufilenew_Click);
            // 
            // menufileexit
            // 
            this.menufileexit.Name = "menufileexit";
            this.menufileexit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menufileexit.Size = new System.Drawing.Size(152, 22);
            this.menufileexit.Text = "&Exit";
            this.menufileexit.Click += new System.EventHandler(this.menufileexit_Click);
            // 
            // Pform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menufile;
        private System.Windows.Forms.ToolStripMenuItem menufilenew;
        private System.Windows.Forms.ToolStripMenuItem menufileexit;

    }
}

