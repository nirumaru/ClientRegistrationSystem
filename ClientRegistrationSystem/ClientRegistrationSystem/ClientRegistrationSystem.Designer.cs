
namespace ClientRegistrationSystem
{
    partial class ClientRegistrationSystem
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
            dataGridViewClients = new DataGridView();
            btnEnroll = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            txtboxSearch = new TextBox();
            btnSearch = new Button();
            btnSave = new Button();
            btnPrint = new Button();
            mainLabel = new Label();
            btnOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClients.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.ImeMode = ImeMode.NoControl;
            dataGridViewClients.Location = new Point(14, 143);
            dataGridViewClients.MultiSelect = false;
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.ReadOnly = true;
            dataGridViewClients.RowHeadersVisible = false;
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClients.Size = new Size(828, 303);
            dataGridViewClients.TabIndex = 2;
            // 
            // btnEnroll
            // 
            btnEnroll.Location = new Point(12, 107);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(75, 23);
            btnEnroll.TabIndex = 1;
            btnEnroll.Text = "Enroll";
            btnEnroll.UseVisualStyleBackColor = true;
            btnEnroll.Click += btnEnroll_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(765, 107);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(684, 107);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtboxSearch
            // 
            txtboxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtboxSearch.Location = new Point(253, 107);
            txtboxSearch.Name = "txtboxSearch";
            txtboxSearch.PlaceholderText = "Enter the Client ID";
            txtboxSearch.Size = new Size(182, 23);
            txtboxSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(441, 108);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.Location = new Point(522, 108);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrint.Location = new Point(603, 108);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 7;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // mainLabel
            // 
            mainLabel.Anchor = AnchorStyles.Top;
            mainLabel.AutoSize = true;
            mainLabel.Font = new Font("Segoe UI", 31F);
            mainLabel.Location = new Point(156, 9);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(508, 57);
            mainLabel.TabIndex = 8;
            mainLabel.Text = "Client Registration System";
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(93, 106);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(75, 23);
            btnOrder.TabIndex = 9;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // ClientRegistrationSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 458);
            Controls.Add(btnOrder);
            Controls.Add(mainLabel);
            Controls.Add(btnPrint);
            Controls.Add(btnSave);
            Controls.Add(btnSearch);
            Controls.Add(txtboxSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnEnroll);
            Controls.Add(dataGridViewClients);
            Name = "ClientRegistrationSystem";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dataGridViewClients;
        private Button btnEnroll;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox txtboxSearch;
        private Button btnSearch;
        private Button btnSave;
        private Button btnPrint;
        private Label mainLabel;
        private Button btnOrder;
    }
}
