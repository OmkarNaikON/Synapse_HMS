using System;
using System.Drawing;
using System.Windows.Forms;

namespace HMS.UI
{
    partial class OPDRegistrationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtMobile = new TextBox();
            txtAddress = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cmbGender = new ComboBox();
            btnSave = new Button();
            btnClear = new Button();
            dgvPatients = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 85);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "Age";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(149, 143);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 6;
            label4.Text = "Mobile No";
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
            // txtName
            // 
            txtName.Location = new Point(234, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 23);
            txtName.TabIndex = 1;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(234, 82);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(150, 23);
            txtAge.TabIndex = 3;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(234, 140);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(150, 23);
            txtMobile.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(234, 169);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 60);
            txtAddress.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(234, 111);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(121, 23);
            cmbGender.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(295, 241);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save Patients";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(198, 241);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(89, 23);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvPatients
            // 
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Dock = DockStyle.Bottom;
            dgvPatients.Location = new Point(0, 300);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.Size = new Size(800, 150);
            dgvPatients.TabIndex = 14;
            // 
            // OPDRegistrationForm
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPatients);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(cmbGender);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtAge);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtMobile);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Name = "OPDRegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OPD Registration";
            WindowState = FormWindowState.Maximized;
            Load += OPDRegistrationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;

        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtMobile;
        private TextBox txtAddress;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox cmbGender;
        private Button btnSave;
        private Button btnClear;
        private DataGridView dgvPatients;
    }
}
