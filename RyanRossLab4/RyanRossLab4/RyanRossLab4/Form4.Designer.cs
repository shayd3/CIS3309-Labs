namespace RyanRossLab4
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblBeforeConversion = new System.Windows.Forms.Label();
            this.lblAfterConversion = new System.Windows.Forms.Label();
            this.boxConversion = new System.Windows.Forms.ComboBox();
            this.txtFromValue = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnNextForm = new System.Windows.Forms.Button();
            this.lblToValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversion:";
            // 
            // lblBeforeConversion
            // 
            this.lblBeforeConversion.AutoSize = true;
            this.lblBeforeConversion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBeforeConversion.Location = new System.Drawing.Point(29, 43);
            this.lblBeforeConversion.Name = "lblBeforeConversion";
            this.lblBeforeConversion.Size = new System.Drawing.Size(34, 13);
            this.lblBeforeConversion.TabIndex = 0;
            this.lblBeforeConversion.Text = "Miles:";
            this.lblBeforeConversion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAfterConversion
            // 
            this.lblAfterConversion.AutoSize = true;
            this.lblAfterConversion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAfterConversion.Location = new System.Drawing.Point(29, 68);
            this.lblAfterConversion.Name = "lblAfterConversion";
            this.lblAfterConversion.Size = new System.Drawing.Size(58, 13);
            this.lblAfterConversion.TabIndex = 0;
            this.lblAfterConversion.Text = "Kilometers:";
            this.lblAfterConversion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // boxConversion
            // 
            this.boxConversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxConversion.FormattingEnabled = true;
            this.boxConversion.Location = new System.Drawing.Point(106, 12);
            this.boxConversion.Name = "boxConversion";
            this.boxConversion.Size = new System.Drawing.Size(166, 21);
            this.boxConversion.TabIndex = 1;
            this.boxConversion.SelectedIndexChanged += new System.EventHandler(this.boxConversion_SelectedIndexChanged);
            // 
            // txtFromValue
            // 
            this.txtFromValue.Location = new System.Drawing.Point(106, 40);
            this.txtFromValue.Name = "txtFromValue";
            this.txtFromValue.Size = new System.Drawing.Size(145, 20);
            this.txtFromValue.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 91);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(116, 91);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnNextForm
            // 
            this.btnNextForm.Location = new System.Drawing.Point(12, 91);
            this.btnNextForm.Name = "btnNextForm";
            this.btnNextForm.Size = new System.Drawing.Size(75, 23);
            this.btnNextForm.TabIndex = 3;
            this.btnNextForm.Text = "10-2";
            this.btnNextForm.UseVisualStyleBackColor = true;
            this.btnNextForm.Click += new System.EventHandler(this.btnNextForm_Click);
            // 
            // lblToValue
            // 
            this.lblToValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblToValue.Location = new System.Drawing.Point(106, 64);
            this.lblToValue.Name = "lblToValue";
            this.lblToValue.Size = new System.Drawing.Size(145, 20);
            this.lblToValue.TabIndex = 31;
            this.lblToValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblToValue.Click += new System.EventHandler(this.lblCalculatedLength_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 129);
            this.Controls.Add(this.lblToValue);
            this.Controls.Add(this.btnNextForm);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtFromValue);
            this.Controls.Add(this.boxConversion);
            this.Controls.Add(this.lblAfterConversion);
            this.Controls.Add(this.lblBeforeConversion);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Conversions";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblToValue;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblBeforeConversion;
        internal System.Windows.Forms.Label lblAfterConversion;
        internal System.Windows.Forms.ComboBox boxConversion;
        internal System.Windows.Forms.TextBox txtFromValue;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnCalculate;
        internal System.Windows.Forms.Button btnNextForm;
    }
}