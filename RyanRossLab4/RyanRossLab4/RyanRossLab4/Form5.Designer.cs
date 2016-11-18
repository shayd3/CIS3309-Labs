namespace RyanRossLab4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSalad = new System.Windows.Forms.RadioButton();
            this.radioPizza = new System.Windows.Forms.RadioButton();
            this.radioHamburger = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.check3 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnNextForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSalad);
            this.groupBox1.Controls.Add(this.radioPizza);
            this.groupBox1.Controls.Add(this.radioHamburger);
            this.groupBox1.Location = new System.Drawing.Point(13, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main course";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioSalad
            // 
            this.radioSalad.AutoSize = true;
            this.radioSalad.Location = new System.Drawing.Point(6, 66);
            this.radioSalad.Name = "radioSalad";
            this.radioSalad.Size = new System.Drawing.Size(88, 17);
            this.radioSalad.TabIndex = 0;
            this.radioSalad.Text = "Salad - $4.95";
            this.radioSalad.UseVisualStyleBackColor = true;
            this.radioSalad.CheckedChanged += new System.EventHandler(this.radioSalad_CheckedChanged);
            // 
            // radioPizza
            // 
            this.radioPizza.AutoSize = true;
            this.radioPizza.Location = new System.Drawing.Point(7, 43);
            this.radioPizza.Name = "radioPizza";
            this.radioPizza.Size = new System.Drawing.Size(86, 17);
            this.radioPizza.TabIndex = 0;
            this.radioPizza.Text = "Pizza - $5.95";
            this.radioPizza.UseVisualStyleBackColor = true;
            this.radioPizza.CheckedChanged += new System.EventHandler(this.radioPizza_CheckedChanged);
            // 
            // radioHamburger
            // 
            this.radioHamburger.AutoSize = true;
            this.radioHamburger.Checked = true;
            this.radioHamburger.Location = new System.Drawing.Point(7, 20);
            this.radioHamburger.Name = "radioHamburger";
            this.radioHamburger.Size = new System.Drawing.Size(113, 17);
            this.radioHamburger.TabIndex = 0;
            this.radioHamburger.TabStop = true;
            this.radioHamburger.Text = "Hamburger - $6.95";
            this.radioHamburger.UseVisualStyleBackColor = true;
            this.radioHamburger.CheckedChanged += new System.EventHandler(this.radioHamburger_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.check3);
            this.groupBox2.Controls.Add(this.check2);
            this.groupBox2.Controls.Add(this.check1);
            this.groupBox2.Location = new System.Drawing.Point(182, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 93);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add-on items ($.75/each)";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // check3
            // 
            this.check3.AutoSize = true;
            this.check3.Location = new System.Drawing.Point(6, 66);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(81, 17);
            this.check3.TabIndex = 0;
            this.check3.Text = "French fries";
            this.check3.UseVisualStyleBackColor = true;
            this.check3.CheckedChanged += new System.EventHandler(this.check3_CheckedChanged);
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Location = new System.Drawing.Point(7, 43);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(161, 17);
            this.check2.TabIndex = 0;
            this.check2.Text = "Ketchup, mustard, and mayo";
            this.check2.UseVisualStyleBackColor = true;
            this.check2.CheckedChanged += new System.EventHandler(this.check2_CheckedChanged);
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Location = new System.Drawing.Point(7, 20);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(158, 17);
            this.check1.TabIndex = 0;
            this.check1.Text = "Lettuce, tomato, and onions";
            this.check1.UseVisualStyleBackColor = true;
            this.check1.CheckedChanged += new System.EventHandler(this.check1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.txtTax);
            this.groupBox3.Controls.Add(this.txtSubtotal);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order total";
            // 
            // txtTotal
            // 
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Location = new System.Drawing.Point(115, 70);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 1;
            // 
            // txtTax
            // 
            this.txtTax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTax.Location = new System.Drawing.Point(115, 44);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 1;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubtotal.Location = new System.Drawing.Point(115, 18);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Order total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tax (7.75%):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(286, 121);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnNextForm
            // 
            this.btnNextForm.Location = new System.Drawing.Point(286, 198);
            this.btnNextForm.Name = "btnNextForm";
            this.btnNextForm.Size = new System.Drawing.Size(75, 23);
            this.btnNextForm.TabIndex = 2;
            this.btnNextForm.Text = "10-3";
            this.btnNextForm.UseVisualStyleBackColor = true;
            this.btnNextForm.Click += new System.EventHandler(this.btnNextForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(286, 150);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form5
            // 
            this.AcceptButton = this.btnOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(394, 231);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNextForm);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "Lunch Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSalad;
        private System.Windows.Forms.RadioButton radioPizza;
        private System.Windows.Forms.RadioButton radioHamburger;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox check3;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnNextForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
    }
}