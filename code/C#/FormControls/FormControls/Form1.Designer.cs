namespace FormControls
{
    partial class MultiCon
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
            this.ChkService = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn3 = new System.Windows.Forms.RadioButton();
            this.btn2 = new System.Windows.Forms.RadioButton();
            this.btn1 = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChkService
            // 
            this.ChkService.AutoSize = true;
            this.ChkService.Location = new System.Drawing.Point(86, 12);
            this.ChkService.Name = "ChkService";
            this.ChkService.Size = new System.Drawing.Size(94, 17);
            this.ChkService.TabIndex = 0;
            this.ChkService.Text = "Check service";
            this.ChkService.UseVisualStyleBackColor = true;
            this.ChkService.CheckedChanged += new System.EventHandler(this.ChkService_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Location = new System.Drawing.Point(54, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "computer type";
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.Location = new System.Drawing.Point(19, 68);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(85, 17);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Work station";
            this.btn3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.Checked = true;
            this.btn2.Location = new System.Drawing.Point(19, 44);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(65, 17);
            this.btn2.TabIndex = 1;
            this.btn2.TabStop = true;
            this.btn2.Text = "Desktop";
            this.btn2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.Location = new System.Drawing.Point(19, 20);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(58, 17);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Laptop";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(73, 180);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(107, 35);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(73, 221);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(126, 20);
            this.Output.TabIndex = 3;
            this.Output.UseWaitCursor = true;
            this.Output.TextChanged += new System.EventHandler(this.Output_TextChanged);
            // 
            // MultiCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ChkService);
            this.Name = "MultiCon";
            this.Text = "Controls";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkService;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btn3;
        private System.Windows.Forms.RadioButton btn2;
        private System.Windows.Forms.RadioButton btn1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox Output;
    }
}

