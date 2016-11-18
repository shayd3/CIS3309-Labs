namespace RyanRossLab3
{
    partial class Form5
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
            this.btnNextForm = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTaxOwed = new System.Windows.Forms.TextBox();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNextForm
            // 
            this.btnNextForm.Location = new System.Drawing.Point(15, 85);
            this.btnNextForm.Name = "btnNextForm";
            this.btnNextForm.Size = new System.Drawing.Size(75, 23);
            this.btnNextForm.TabIndex = 7;
            this.btnNextForm.Text = "7-1";
            this.btnNextForm.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(96, 85);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(177, 85);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtTaxOwed
            // 
            this.txtTaxOwed.Location = new System.Drawing.Point(152, 38);
            this.txtTaxOwed.Name = "txtTaxOwed";
            this.txtTaxOwed.ReadOnly = true;
            this.txtTaxOwed.Size = new System.Drawing.Size(100, 20);
            this.txtTaxOwed.TabIndex = 5;
            // 
            // txtIncome
            // 
            this.txtIncome.Location = new System.Drawing.Point(152, 12);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(100, 20);
            this.txtIncome.TabIndex = 6;
            this.txtIncome.TextChanged += new System.EventHandler(this.txtIncome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Income Tax Owed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Taxable Income:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 120);
            this.Controls.Add(this.btnNextForm);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTaxOwed);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Income Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNextForm;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTaxOwed;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}