namespace ClientRegistrationApp
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
            label1 = new Label();
            btnEnroll = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            dataGridViewClientsTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientsTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 27F);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(869, 77);
            label1.TabIndex = 0;
            label1.Text = "Client Registration Sytem";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnEnroll
            // 
            btnEnroll.Location = new Point(14, 93);
            btnEnroll.Margin = new Padding(3, 4, 3, 4);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(86, 31);
            btnEnroll.TabIndex = 1;
            btnEnroll.Text = "Enroll";
            btnEnroll.UseVisualStyleBackColor = true;
            btnEnroll.Click += btnEnroll_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.Location = new Point(797, 93);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEdit.Location = new Point(704, 93);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 31);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // dataGridViewClientsTable
            // 
            dataGridViewClientsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewClientsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClientsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientsTable.Location = new Point(14, 132);
            dataGridViewClientsTable.Margin = new Padding(3, 4, 3, 4);
            dataGridViewClientsTable.MultiSelect = false;
            dataGridViewClientsTable.Name = "dataGridViewClientsTable";
            dataGridViewClientsTable.RowHeadersVisible = false;
            dataGridViewClientsTable.RowHeadersWidth = 51;
            dataGridViewClientsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientsTable.Size = new Size(869, 400);
            dataGridViewClientsTable.TabIndex = 2;
            // 
            // ClientRegistrationSystem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 548);
            Controls.Add(dataGridViewClientsTable);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnEnroll);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClientRegistrationSystem";
            Text = "Client Registration System";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnEnroll;
        private Button btnDelete;
        private Button btnEdit;
        private DataGridView dataGridViewClientsTable;
    }
}
