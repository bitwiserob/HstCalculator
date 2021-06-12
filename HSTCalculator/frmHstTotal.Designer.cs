
namespace HstCalculator
{
    partial class frmHstTotal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtHst = new System.Windows.Forms.TextBox();
            this.txtHstTotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbProvinces = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBefore = new System.Windows.Forms.RadioButton();
            this.rdAfter = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "GST/HST";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "GST/HST Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "&Total";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(148, 13);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 23);
            this.txtSubtotal.TabIndex = 4;
            // 
            // txtHst
            // 
            this.txtHst.Location = new System.Drawing.Point(148, 71);
            this.txtHst.Name = "txtHst";
            this.txtHst.ReadOnly = true;
            this.txtHst.Size = new System.Drawing.Size(100, 23);
            this.txtHst.TabIndex = 5;
            this.txtHst.Text = "13.0%";
            // 
            // txtHstTotal
            // 
            this.txtHstTotal.Location = new System.Drawing.Point(148, 100);
            this.txtHstTotal.Name = "txtHstTotal";
            this.txtHstTotal.ReadOnly = true;
            this.txtHstTotal.Size = new System.Drawing.Size(100, 23);
            this.txtHstTotal.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(148, 129);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(9, 233);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(194, 233);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbProvinces
            // 
            this.cbProvinces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvinces.FormattingEnabled = true;
            this.cbProvinces.Location = new System.Drawing.Point(148, 42);
            this.cbProvinces.Name = "cbProvinces";
            this.cbProvinces.Size = new System.Drawing.Size(100, 23);
            this.cbProvinces.TabIndex = 10;
            this.cbProvinces.SelectedIndexChanged += new System.EventHandler(this.cbProvinces_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Province";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbProvinces);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtHstTotal);
            this.groupBox1.Controls.Add(this.txtHst);
            this.groupBox1.Controls.Add(this.txtSubtotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 166);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Information";
            // 
            // rdBefore
            // 
            this.rdBefore.AutoSize = true;
            this.rdBefore.Location = new System.Drawing.Point(6, 22);
            this.rdBefore.Name = "rdBefore";
            this.rdBefore.Size = new System.Drawing.Size(89, 19);
            this.rdBefore.TabIndex = 13;
            this.rdBefore.TabStop = true;
            this.rdBefore.Text = "Before taxes";
            this.rdBefore.UseVisualStyleBackColor = true;
            // 
            // rdAfter
            // 
            this.rdAfter.AutoSize = true;
            this.rdAfter.Location = new System.Drawing.Point(172, 22);
            this.rdAfter.Name = "rdAfter";
            this.rdAfter.Size = new System.Drawing.Size(81, 19);
            this.rdAfter.TabIndex = 14;
            this.rdAfter.TabStop = true;
            this.rdAfter.Text = "After taxes";
            this.rdAfter.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdAfter);
            this.groupBox2.Controls.Add(this.rdBefore);
            this.groupBox2.Location = new System.Drawing.Point(9, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 53);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Amount entered is:";
            // 
            // frmHstTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 265);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Name = "frmHstTotal";
            this.Text = "Hst Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtHst;
        private System.Windows.Forms.TextBox txtHstTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
        public System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbProvinces;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBefore;
        private System.Windows.Forms.RadioButton rdAfter;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

