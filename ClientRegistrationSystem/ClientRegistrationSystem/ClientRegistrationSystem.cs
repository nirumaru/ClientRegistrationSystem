using ClientRegistrationSystem;
using ClientRegistrationSystem.Models;
using ClientRegistrationSystem.Repositories;
using System.Data;
using System.Drawing.Printing;

namespace ClientRegistrationSystem
{
    public partial class ClientRegistrationSystem : Form
    {
        public ClientRegistrationSystem()
        {
            InitializeComponent();
            ReadClients();
            dataGridViewClients.AllowUserToAddRows = false;
            dataGridViewClients.ReadOnly = true;
        }

        private void ReadClients()
        {
            DataTable dataTable = new DataTable();
            //creating columns for displaying the data retrieved from the database
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("PhoneNumber");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Category");

            //creating a new ClientRepository object
            var repo = new ClientRepository();
            var clients = repo.GetClients();
            foreach (var client in clients)
            {
                var row = dataTable.NewRow();

                row["ID"] = client.id;
                row["Name"] = client.name;
                row["Email"] = client.email;
                row["PhoneNumber"] = client.phonenumber;
                row["Address"] = client.address;
                row["Category"] = client.category;

                dataTable.Rows.Add(row);

            }

            this.dataGridViewClients.DataSource = dataTable;
        }

        private void OrderClients()
        {
            DataTable dataTable = new DataTable();
            //creating columns for displaying the data retrieved from the database
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("PhoneNumber");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Category");

            //creating a new ClientRepository object
            var repo = new ClientRepository();
            var clients = repo.OrderClients();
            foreach (var client in clients)
            {
                var row = dataTable.NewRow();

                row["ID"] = client.id;
                row["Name"] = client.name;
                row["Email"] = client.email;
                row["PhoneNumber"] = client.phonenumber;
                row["Address"] = client.address;
                row["Category"] = client.category;

                dataTable.Rows.Add(row);

            }

            this.dataGridViewClients.DataSource = dataTable;
        }

        private void btnEnroll_Click_1(object sender, EventArgs e)
        {
            //calling the class CreateEditForm 
            CreateEditForm form = new CreateEditForm();
            //if the dialog has returned OK, then we update the clients
            if (form.ShowDialog() == DialogResult.OK)
            {
                //update the list of clients
                ReadClients();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {


            var val = this.dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString();




            //if the value is null or the length of the value is null, the client id is invalid
            if (val == null || val.Length == 0) return;

            //reading the clientid as an integer
            int clientId = int.Parse(val);




            //using the repository to read the client with the clientId
            var repo = new ClientRepository();
            var client = repo.GetClient(clientId);



            //if there is no client with the id, return
            if (client == null) return;

            //if the client exists, display the edit form
            CreateEditForm form = new CreateEditForm();
            //providing the createeditform with the client object
            form.EditClient(client);

            //wait for the response of the createedit form, if the response is ok,
            //it means the data has been updated and now we can update the client
            if (form.ShowDialog() == DialogResult.OK)
            {
                //update the clients
                ReadClients();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //reading the value of the first cell of the selected row of the table
            var val = this.dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString();

            //if the value is null or the length of the value is null, the client id is invalid
            if (val == null || val.Length == 0) return;

            //reading the clientid as an integer
            int clientId = int.Parse(val);

            //show a confirmation dialog
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this client?",
                "Delete Client", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) { return; }

            var repo = new ClientRepository();
            repo.DeleteClient(clientId);

            ReadClients();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtboxSearch.Text))
            {
                MessageBox.Show("Please provide a clientID.", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                var val = int.Parse(txtboxSearch.Text).ToString();


                //if the value is null or the length of the value is null, the client id is invalid
                if (val == null || val.Length == 0) return;

                //reading the clientid as an integer
                int clientId = int.Parse(val);

                //using the repository to read the client with the clientId
                var repo = new ClientRepository();
                var client = repo.GetClient(clientId);

                //if there is no client with the id, return
                if (client == null) return;

                //if the client exists, display the edit form
                CreateEditForm form = new CreateEditForm();
                //providing the createeditform with the client object
                form.EditClient(client);

                //wait for the response of the createedit form, if the response is ok,
                //it means the data has been updated and now we can update the client
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //update the clients
                    ReadClients();
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create a new ClientRepository object
            var repo = new ClientRepository();

            // Call GetClients to retrieve the list of clients
            List<Client> clients = repo.GetClients(); // Assuming GetClients returns a List<Client>

            // Get the path to the desktop
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "ClientDetails.txt");

            // Save client details to a text file on the desktop
            using (StreamWriter writer = new StreamWriter(filePath, false)) // Overwrite mode
            {
                foreach (var client in clients)
                {
                    writer.WriteLine($"Client ID: {client.id}");
                    writer.WriteLine($"Name: {client.name}");
                    writer.WriteLine($"Email: {client.email}");
                    writer.WriteLine($"Phone Number: {client.phonenumber}");
                    writer.WriteLine($"Address: {client.address}");
                    writer.WriteLine($"Category: {client.category}");
                    writer.WriteLine("--------------------------------------------------");
                }
            }

            MessageBox.Show("Successfully saved the client list to desktop.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private PrintDocument printDocument = new PrintDocument();


        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e, List<Client> clients)
        {
            // Check if e.Graphics is not null
            if (e.Graphics == null)
            {
                throw new InvalidOperationException("Graphics object is null.");
            }

            // Set up fonts and starting position
            Font font = new Font("Arial", 12);
            float lineHeight = font.GetHeight(e.Graphics) + 5; // Now safe to call GetHeight
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            // Print header
            e.Graphics.DrawString("Client ID", font, Brushes.Black, x, y);
            e.Graphics.DrawString("Name", font, Brushes.Black, x + 100, y);
            e.Graphics.DrawString("Email", font, Brushes.Black, x + 300, y);
            e.Graphics.DrawString("Phone Number", font, Brushes.Black, x + 500, y);
            e.Graphics.DrawString("Address", font, Brushes.Black, x + 700, y);
            e.Graphics.DrawString("Category", font, Brushes.Black, x + 900, y);
            y += lineHeight;

            // Print each client
            foreach (var client in clients)
            {
                e.Graphics.DrawString(client.id.ToString(), font, Brushes.Black, x, y);
                e.Graphics.DrawString(client.name, font, Brushes.Black, x + 100, y);
                e.Graphics.DrawString(client.email, font, Brushes.Black, x + 300, y);
                e.Graphics.DrawString(client.phonenumber, font, Brushes.Black, x + 500, y);
                e.Graphics.DrawString(client.address, font, Brushes.Black, x + 700, y);
                e.Graphics.DrawString(client.category, font, Brushes.Black, x + 900, y);
                y += lineHeight;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Create a new ClientRepository object
            var repo = new ClientRepository();

            // Retrieve the list of clients
            List<Client> clients = repo.GetClients(); // Assuming GetClients returns a List<Client>

            // Set up the PrintPage event handler
            printDocument.PrintPage += (s, ev) => PrintDocument_PrintPage(s, ev, clients);

            // Show the Print Preview dialog
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDocument
            };
            printPreviewDialog.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderClients();
            MessageBox.Show("Clients ordered in alphabetical order.");
        }
    }
}
