namespace HMS.UI
{
    partial class OPDRegistrationForm
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
            label1 = new Label();
            this.txtName = new TextBox();
            this.txtAge = new TextBox();
            label2 = new Label();
            this.cmbGender = new TextBox();
            label3 = new Label();
            txtMobile = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 56);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Patient Name";
            // 
            // txtName
            // 
            this.txtName.Location = new Point(234, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(100, 23);
            this.txtName.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Location = new Point(234, 82);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new Size(100, 23);
            this.txtAge.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 85);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "Age";
            // 
            // cmbGender
            // 
            this.cmbGender.Location = new Point(234, 111);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new Size(100, 23);
            this.cmbGender.TabIndex = 5;
            this.cmbGender.Text = "`";
            this.cmbGender.TextChanged += this.textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 114);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Gender";
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(234, 140);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(100, 23);
            txtMobile.TabIndex = 7;
            txtMobile.Text = "`";
            txtMobile.TextChanged += this.textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(149, 143);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 6;
            label4.Text = "Mobile No";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(234, 169);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 9;
            textBox5.Text = "`";
            textBox5.TextChanged += this.textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(149, 172);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 8;
            label5.Text = "Address";
            // 
            // OPDRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(txtMobile);
            Controls.Add(label4);
            Controls.Add(this.cmbGender);
            Controls.Add(label3);
            Controls.Add(this.txtAge);
            Controls.Add(label2);
            Controls.Add(this.txtName);
            Controls.Add(label1);
            Name = "OPDRegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "`";
            WindowState = FormWindowState.Maximized;
            Load += this.OPDRegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox txtMobile;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
    }
}