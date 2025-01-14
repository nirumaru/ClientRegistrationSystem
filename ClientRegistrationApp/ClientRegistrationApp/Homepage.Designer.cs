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
            lblMain = new Label();
            btnEnroll = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            dataGridViewClientsTable = new DataGridView();
            btnSearch = new Button();
            txtboxClientId = new TextBox();
            btnPrint = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientsTable).BeginInit();
            SuspendLayout();
            // 
            // lblMain
            // 
            lblMain.Font = new Font("Segoe UI", 27F);
            lblMain.Location = new Point(12, 9);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(760, 58);
            lblMain.TabIndex = 0;
            lblMain.Text = "Client Registration Sytem";
            lblMain.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnEnroll
            // 
            btnEnroll.Location = new Point(12, 70);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(75, 23);
            btnEnroll.TabIndex = 1;
            btnEnroll.Text = "Enroll";
            btnEnroll.UseVisualStyleBackColor = true;
            btnEnroll.Click += btnEnroll_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(697, 70);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(616, 70);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
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
            dataGridViewClientsTable.Location = new Point(12, 99);
            dataGridViewClientsTable.MultiSelect = false;
            dataGridViewClientsTable.Name = "dataGridViewClientsTable";
            dataGridViewClientsTable.RowHeadersVisible = false;
            dataGridViewClientsTable.RowHeadersWidth = 51;
            dataGridViewClientsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientsTable.Size = new Size(760, 300);
            dataGridViewClientsTable.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(373, 70);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // txtboxClientId
            // 
            txtboxClientId.Location = new Point(267, 70);
            txtboxClientId.Name = "txtboxClientId";
            txtboxClientId.Size = new Size(100, 23);
            txtboxClientId.TabIndex = 4;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrint.Location = new Point(454, 70);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.Location = new Point(535, 71);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ClientRegistrationSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(btnSave);
            Controls.Add(btnPrint);
            Controls.Add(txtboxClientId);
            Controls.Add(btnSearch);
            Controls.Add(dataGridViewClientsTable);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnEnroll);
            Controls.Add(lblMain);
            Name = "ClientRegistrationSystem";
            Text = "Client Registration System";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMain;
        private Button btnEnroll;
        private Button btnDelete;
        private Button btnEdit;
        private DataGridView dataGridViewClientsTable;
        private Button btnSearch;
        private TextBox txtboxClientId;
        private Button btnPrint;
        private Button btnSave;
    }
}
