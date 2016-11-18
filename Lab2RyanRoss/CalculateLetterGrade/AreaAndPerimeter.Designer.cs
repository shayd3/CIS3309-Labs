namespace CalculateLetterGrade
{
    partial class AreaAndPerimeter
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textLength = new System.Windows.Forms.TextBox();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.textArea = new System.Windows.Forms.TextBox();
            this.textPerimeter = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnScoreCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Area:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Perimeter:";
            // 
            // textLength
            // 
            this.textLength.Location = new System.Drawing.Point(110, 17);
            this.textLength.Name = "textLength";
            this.textLength.Size = new System.Drawing.Size(100, 20);
            this.textLength.TabIndex = 4;
            // 
            // textWidth
            // 
            this.textWidth.Location = new System.Drawing.Point(110, 43);
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(100, 20);
            this.textWidth.TabIndex = 5;
            // 
            // textArea
            // 
            this.textArea.Location = new System.Drawing.Point(110, 69);
            this.textArea.Name = "textArea";
            this.textArea.ReadOnly = true;
            this.textArea.Size = new System.Drawing.Size(100, 20);
            this.textArea.TabIndex = 6;
            // 
            // textPerimeter
            // 
            this.textPerimeter.Location = new System.Drawing.Point(110, 95);
            this.textPerimeter.Name = "textPerimeter";
            this.textPerimeter.ReadOnly = true;
            this.textPerimeter.Size = new System.Drawing.Size(100, 20);
            this.textPerimeter.TabIndex = 7;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(36, 132);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(135, 132);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnScoreCalc
            // 
            this.btnScoreCalc.Location = new System.Drawing.Point(84, 161);
            this.btnScoreCalc.Name = "btnScoreCalc";
            this.btnScoreCalc.Size = new System.Drawing.Size(75, 23);
            this.btnScoreCalc.TabIndex = 10;
            this.btnScoreCalc.Text = "Score Calc";
            this.btnScoreCalc.UseVisualStyleBackColor = true;
            this.btnScoreCalc.Click += new System.EventHandler(this.btnScoreCalc_Click);
            // 
            // AreaAndPerimeter
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(239, 207);
            this.Controls.Add(this.btnScoreCalc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.textPerimeter);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.textWidth);
            this.Controls.Add(this.textLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AreaAndPerimeter";
            this.Text = "Area and Perimeter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textLength;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.TextBox textArea;
        private System.Windows.Forms.TextBox textPerimeter;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnScoreCalc;
    }
}