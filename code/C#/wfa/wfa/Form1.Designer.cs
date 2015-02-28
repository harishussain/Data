namespace wfa
{
    partial class Form1
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
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(92, 29);
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.Size = new System.Drawing.Size(100, 20);
            this.TxtDisplay.TabIndex = 0;
            this.TxtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtDisplay.TextChanged += new System.EventHandler(this.TxtDisplay_TextChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 72);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(28, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(72, 72);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(28, 23);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(129, 72);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(28, 23);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 116);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(28, 23);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(72, 116);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(28, 23);
            this.btn0.TabIndex = 5;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnmul
            // 
            this.btnmul.Location = new System.Drawing.Point(129, 116);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(28, 23);
            this.btnmul.TabIndex = 6;
            this.btnmul.Text = "*";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(192, 72);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(28, 23);
            this.btnplus.TabIndex = 7;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnequal
            // 
            this.btnequal.Location = new System.Drawing.Point(192, 116);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(28, 23);
            this.btnequal.TabIndex = 8;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(192, 157);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(39, 23);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.TxtDisplay);
            this.Name = "Form1";
            this.Text = "calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.Button btnclear;
    }
}

