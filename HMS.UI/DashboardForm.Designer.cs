namespace HMS.UI
{
    partial class DashboardForm
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
            btnOPD = new Button();
            btnIPD = new Button();
            btnBilling = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 18);
            label1.Name = "label1";
            label1.Size = new Size(517, 47);
            label1.TabIndex = 0;
            label1.Text = "Welcome to HMS Dashboard";
            // 
            // btnOPD
            // 
            btnOPD.Location = new Point(182, 86);
            btnOPD.Name = "btnOPD";
            btnOPD.Size = new Size(114, 23);
            btnOPD.TabIndex = 1;
            btnOPD.Text = "OPD Registration";
            btnOPD.UseVisualStyleBackColor = true;
            // 
            // btnIPD
            // 
            btnIPD.Location = new Point(182, 115);
            btnIPD.Name = "btnIPD";
            btnIPD.Size = new Size(114, 23);
            btnIPD.TabIndex = 2;
            btnIPD.Text = "IPD Admission";
            btnIPD.UseVisualStyleBackColor = true;
            // 
            // btnBilling
            // 
            btnBilling.Location = new Point(182, 144);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(114, 23);
            btnBilling.TabIndex = 3;
            btnBilling.Text = "Billing";
            btnBilling.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(182, 173);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(114, 23);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnBilling);
            Controls.Add(btnIPD);
            Controls.Add(btnOPD);
            Controls.Add(label1);
            Name = "DashboardForm";
            Text = "DashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnOPD;
        private Button btnIPD;
        private Button btnBilling;
        private Button btnLogout;
    }
}