namespace Matrix2
{
    partial class frmMain
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
            this.groupOps = new System.Windows.Forms.GroupBox();
            this.radioAEqualsB = new System.Windows.Forms.RadioButton();
            this.radioSubtract = new System.Windows.Forms.RadioButton();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.radioMultiply = new System.Windows.Forms.RadioButton();
            this.txtFullMatrixC = new System.Windows.Forms.TextBox();
            this.txtFullMatrixB = new System.Windows.Forms.TextBox();
            this.txtFullMatrixA = new System.Windows.Forms.TextBox();
            this.txtMatrixBCols = new System.Windows.Forms.TextBox();
            this.txtMatrixACols = new System.Windows.Forms.TextBox();
            this.txtMatrixBRows = new System.Windows.Forms.TextBox();
            this.txtMatrixARows = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMakeBIdentity = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnCreateMatrixB = new System.Windows.Forms.Button();
            this.btnCreateMatrixA = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBCopyOfA = new System.Windows.Forms.Button();
            this.groupOps.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupOps
            // 
            this.groupOps.Controls.Add(this.radioAEqualsB);
            this.groupOps.Controls.Add(this.radioSubtract);
            this.groupOps.Controls.Add(this.radioAdd);
            this.groupOps.Controls.Add(this.radioMultiply);
            this.groupOps.Location = new System.Drawing.Point(16, 258);
            this.groupOps.Name = "groupOps";
            this.groupOps.Size = new System.Drawing.Size(259, 51);
            this.groupOps.TabIndex = 27;
            this.groupOps.TabStop = false;
            this.groupOps.Text = "Select Operation";
            // 
            // radioAEqualsB
            // 
            this.radioAEqualsB.AutoSize = true;
            this.radioAEqualsB.Location = new System.Drawing.Point(195, 20);
            this.radioAEqualsB.Name = "radioAEqualsB";
            this.radioAEqualsB.Size = new System.Drawing.Size(57, 17);
            this.radioAEqualsB.TabIndex = 11;
            this.radioAEqualsB.TabStop = true;
            this.radioAEqualsB.Text = "A == B";
            this.radioAEqualsB.UseVisualStyleBackColor = true;
            // 
            // radioSubtract
            // 
            this.radioSubtract.AutoSize = true;
            this.radioSubtract.Location = new System.Drawing.Point(123, 20);
            this.radioSubtract.Name = "radioSubtract";
            this.radioSubtract.Size = new System.Drawing.Size(65, 17);
            this.radioSubtract.TabIndex = 10;
            this.radioSubtract.TabStop = true;
            this.radioSubtract.Text = "Subtract";
            this.radioSubtract.UseVisualStyleBackColor = true;
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Location = new System.Drawing.Point(73, 20);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(44, 17);
            this.radioAdd.TabIndex = 9;
            this.radioAdd.TabStop = true;
            this.radioAdd.Text = "Add";
            this.radioAdd.UseVisualStyleBackColor = true;
            // 
            // radioMultiply
            // 
            this.radioMultiply.AutoSize = true;
            this.radioMultiply.Location = new System.Drawing.Point(7, 20);
            this.radioMultiply.Name = "radioMultiply";
            this.radioMultiply.Size = new System.Drawing.Size(60, 17);
            this.radioMultiply.TabIndex = 8;
            this.radioMultiply.TabStop = true;
            this.radioMultiply.Text = "Multiply";
            this.radioMultiply.UseVisualStyleBackColor = true;
            // 
            // txtFullMatrixC
            // 
            this.txtFullMatrixC.Location = new System.Drawing.Point(328, 30);
            this.txtFullMatrixC.Multiline = true;
            this.txtFullMatrixC.Name = "txtFullMatrixC";
            this.txtFullMatrixC.ReadOnly = true;
            this.txtFullMatrixC.Size = new System.Drawing.Size(150, 150);
            this.txtFullMatrixC.TabIndex = 23;
            this.txtFullMatrixC.TabStop = false;
            // 
            // txtFullMatrixB
            // 
            this.txtFullMatrixB.Location = new System.Drawing.Point(172, 30);
            this.txtFullMatrixB.Multiline = true;
            this.txtFullMatrixB.Name = "txtFullMatrixB";
            this.txtFullMatrixB.ReadOnly = true;
            this.txtFullMatrixB.Size = new System.Drawing.Size(150, 150);
            this.txtFullMatrixB.TabIndex = 24;
            this.txtFullMatrixB.TabStop = false;
            // 
            // txtFullMatrixA
            // 
            this.txtFullMatrixA.Location = new System.Drawing.Point(16, 30);
            this.txtFullMatrixA.Multiline = true;
            this.txtFullMatrixA.Name = "txtFullMatrixA";
            this.txtFullMatrixA.ReadOnly = true;
            this.txtFullMatrixA.Size = new System.Drawing.Size(150, 150);
            this.txtFullMatrixA.TabIndex = 25;
            this.txtFullMatrixA.TabStop = false;
            // 
            // txtMatrixBCols
            // 
            this.txtMatrixBCols.Location = new System.Drawing.Point(241, 231);
            this.txtMatrixBCols.Name = "txtMatrixBCols";
            this.txtMatrixBCols.Size = new System.Drawing.Size(100, 20);
            this.txtMatrixBCols.TabIndex = 26;
            // 
            // txtMatrixACols
            // 
            this.txtMatrixACols.Location = new System.Drawing.Point(241, 202);
            this.txtMatrixACols.Name = "txtMatrixACols";
            this.txtMatrixACols.Size = new System.Drawing.Size(100, 20);
            this.txtMatrixACols.TabIndex = 21;
            // 
            // txtMatrixBRows
            // 
            this.txtMatrixBRows.Location = new System.Drawing.Point(135, 231);
            this.txtMatrixBRows.Name = "txtMatrixBRows";
            this.txtMatrixBRows.Size = new System.Drawing.Size(100, 20);
            this.txtMatrixBRows.TabIndex = 22;
            this.txtMatrixBRows.TextChanged += new System.EventHandler(this.txtMatrixBRows_TextChanged);
            // 
            // txtMatrixARows
            // 
            this.txtMatrixARows.Location = new System.Drawing.Point(135, 202);
            this.txtMatrixARows.Name = "txtMatrixARows";
            this.txtMatrixARows.Size = new System.Drawing.Size(100, 20);
            this.txtMatrixARows.TabIndex = 16;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(291, 315);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 23);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear &Matrices";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMakeBIdentity
            // 
            this.btnMakeBIdentity.Location = new System.Drawing.Point(347, 228);
            this.btnMakeBIdentity.Name = "btnMakeBIdentity";
            this.btnMakeBIdentity.Size = new System.Drawing.Size(120, 23);
            this.btnMakeBIdentity.TabIndex = 31;
            this.btnMakeBIdentity.Text = "Make B Identity";
            this.btnMakeBIdentity.UseVisualStyleBackColor = true;
            this.btnMakeBIdentity.Click += new System.EventHandler(this.btnMakeBIdentity_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(406, 315);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 315);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 30;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnCreateMatrixB
            // 
            this.btnCreateMatrixB.Location = new System.Drawing.Point(16, 231);
            this.btnCreateMatrixB.Name = "btnCreateMatrixB";
            this.btnCreateMatrixB.Size = new System.Drawing.Size(113, 23);
            this.btnCreateMatrixB.TabIndex = 29;
            this.btnCreateMatrixB.Text = "Make Matrix B";
            this.btnCreateMatrixB.UseVisualStyleBackColor = true;
            this.btnCreateMatrixB.Click += new System.EventHandler(this.btnCreateMatrixB_Click);
            // 
            // btnCreateMatrixA
            // 
            this.btnCreateMatrixA.Location = new System.Drawing.Point(16, 202);
            this.btnCreateMatrixA.Name = "btnCreateMatrixA";
            this.btnCreateMatrixA.Size = new System.Drawing.Size(113, 23);
            this.btnCreateMatrixA.TabIndex = 28;
            this.btnCreateMatrixA.Text = "Make Matrix A";
            this.btnCreateMatrixA.UseVisualStyleBackColor = true;
            this.btnCreateMatrixA.Click += new System.EventHandler(this.btnCreateMatrixA_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cols";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Matrix C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Matrix B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Matrix A";
            // 
            // btnBCopyOfA
            // 
            this.btnBCopyOfA.Location = new System.Drawing.Point(347, 198);
            this.btnBCopyOfA.Name = "btnBCopyOfA";
            this.btnBCopyOfA.Size = new System.Drawing.Size(120, 23);
            this.btnBCopyOfA.TabIndex = 34;
            this.btnBCopyOfA.Text = "Make B Copy of A";
            this.btnBCopyOfA.UseVisualStyleBackColor = true;
            this.btnBCopyOfA.Click += new System.EventHandler(this.btnBCopyOfA_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 349);
            this.Controls.Add(this.btnBCopyOfA);
            this.Controls.Add(this.groupOps);
            this.Controls.Add(this.txtFullMatrixC);
            this.Controls.Add(this.txtFullMatrixB);
            this.Controls.Add(this.txtFullMatrixA);
            this.Controls.Add(this.txtMatrixBCols);
            this.Controls.Add(this.txtMatrixACols);
            this.Controls.Add(this.txtMatrixBRows);
            this.Controls.Add(this.txtMatrixARows);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMakeBIdentity);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnCreateMatrixB);
            this.Controls.Add(this.btnCreateMatrixA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupOps.ResumeLayout(false);
            this.groupOps.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupOps;
        private System.Windows.Forms.RadioButton radioAEqualsB;
        private System.Windows.Forms.RadioButton radioSubtract;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.RadioButton radioMultiply;
        private System.Windows.Forms.TextBox txtFullMatrixC;
        private System.Windows.Forms.TextBox txtFullMatrixB;
        private System.Windows.Forms.TextBox txtFullMatrixA;
        private System.Windows.Forms.TextBox txtMatrixBCols;
        private System.Windows.Forms.TextBox txtMatrixACols;
        private System.Windows.Forms.TextBox txtMatrixBRows;
        private System.Windows.Forms.TextBox txtMatrixARows;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMakeBIdentity;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnCreateMatrixB;
        private System.Windows.Forms.Button btnCreateMatrixA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBCopyOfA;
    }
}

