namespace WindowsFormsApplication1
{
    partial class Form
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
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(84, 12);
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.Size = new System.Drawing.Size(98, 20);
            this.TxtDisplay.TabIndex = 0;
            this.TxtDisplay.TextChanged += new System.EventHandler(this.TxtDisplay_TextChanged);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(46, 53);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(29, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(100, 53);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(29, 23);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(153, 53);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(29, 23);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(46, 95);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(29, 23);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(100, 95);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(29, 23);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(153, 95);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(29, 23);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(46, 139);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(29, 23);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(100, 139);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(29, 23);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(153, 139);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(29, 23);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(100, 195);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(29, 23);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // btnpoint
            // 
            this.btnpoint.BackColor = System.Drawing.Color.White;
            this.btnpoint.Location = new System.Drawing.Point(153, 195);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(29, 23);
            this.btnpoint.TabIndex = 11;
            this.btnpoint.Text = ".";
            this.btnpoint.UseVisualStyleBackColor = false;
            this.btnpoint.Click += new System.EventHandler(this.btnpoint_Click);
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.White;
            this.btnplus.Location = new System.Drawing.Point(215, 53);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(29, 23);
            this.btnplus.TabIndex = 12;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = false;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnequal
            // 
            this.btnequal.BackColor = System.Drawing.Color.White;
            this.btnequal.Location = new System.Drawing.Point(215, 95);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(29, 23);
            this.btnequal.TabIndex = 13;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = false;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(215, 139);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(47, 23);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btnpoint);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.TxtDisplay);
            this.Name = "Form";
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
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnpoint;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.Button btnclear;
    }
}

