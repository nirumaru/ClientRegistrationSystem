namespace ClientRegistrationApp
{
    partial class CreateEditForm
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
            lblEnroll = new Label();
            lblClientId = new Label();
            lblClientIdNumber = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            lblAddress = new Label();
            txtboxName = new TextBox();
            txtboxEmail = new TextBox();
            txtboxPhoneNumber = new TextBox();
            txtboxAddress = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblEnroll
            // 
            lblEnroll.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEnroll.Font = new Font("Segoe UI", 27F);
            lblEnroll.Location = new Point(12, 9);
            lblEnroll.Name = "lblEnroll";
            lblEnroll.Size = new Size(650, 54);
            lblEnroll.TabIndex = 0;
            lblEnroll.Text = "Enroll Client";
            lblEnroll.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblClientId
            // 
            lblClientId.AutoSize = true;
            lblClientId.Location = new Point(83, 80);
            lblClientId.Name = "lblClientId";
            lblClientId.Size = new Size(52, 15);
            lblClientId.TabIndex = 1;
            lblClientId.Text = "Client ID";
            // 
            // lblClientIdNumber
            // 
            lblClientIdNumber.AutoSize = true;
            lblClientIdNumber.Location = new Point(220, 80);
            lblClientIdNumber.Name = "lblClientIdNumber";
            lblClientIdNumber.Size = new Size(0, 15);
            lblClientIdNumber.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(83, 124);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(83, 158);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(83, 191);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(85, 15);
            lblPhoneNumber.TabIndex = 1;
            lblPhoneNumber.Text = "PhoneNumber";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(83, 229);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Address";
            // 
            // txtboxName
            // 
            txtboxName.Location = new Point(220, 118);
            txtboxName.Margin = new Padding(3, 2, 3, 2);
            txtboxName.Name = "txtboxName";
            txtboxName.Size = new Size(364, 23);
            txtboxName.TabIndex = 3;
            // 
            // txtboxEmail
            // 
            txtboxEmail.Location = new Point(220, 152);
            txtboxEmail.Margin = new Padding(3, 2, 3, 2);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(364, 23);
            txtboxEmail.TabIndex = 3;
            // 
            // txtboxPhoneNumber
            // 
            txtboxPhoneNumber.Location = new Point(220, 186);
            txtboxPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtboxPhoneNumber.Name = "txtboxPhoneNumber";
            txtboxPhoneNumber.Size = new Size(364, 23);
            txtboxPhoneNumber.TabIndex = 3;
            // 
            // txtboxAddress
            // 
            txtboxAddress.Location = new Point(220, 226);
            txtboxAddress.Margin = new Padding(3, 2, 3, 2);
            txtboxAddress.Name = "txtboxAddress";
            txtboxAddress.Size = new Size(364, 23);
            txtboxAddress.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(220, 272);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(426, 272);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 344);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtboxAddress);
            Controls.Add(txtboxPhoneNumber);
            Controls.Add(txtboxEmail);
            Controls.Add(txtboxName);
            Controls.Add(lblClientIdNumber);
            Controls.Add(lblAddress);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(lblClientId);
            Controls.Add(lblEnroll);
            Name = "CreateEditForm";
            Text = "Enroll Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnroll;
        private Label lblClientId;
        private Label lblClientIdNumber;
        private Label lblName;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblAddress;
        private TextBox txtboxName;
        private TextBox txtboxEmail;
        private TextBox txtboxPhoneNumber;
        private TextBox txtboxAddress;
        private Button btnSave;
        private Button btnCancel;
    }
}