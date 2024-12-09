using ClientRegistrationApp.Repositories;
using System.Data;

namespace ClientRegistrationApp
{
    public partial class ClientRegistrationSystem : Form
    {


        public ClientRegistrationSystem()
        {
            InitializeComponent();
            ReadClients();
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

                dataTable.Rows.Add(row);

            }

            this.dataGridViewClientsTable.DataSource = dataTable;
        }

        private void btnEnroll_Click(object sender, EventArgs e)
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
            //reading the value of the first cell of the selected row of the table
            var val = this.dataGridViewClientsTable.SelectedRows[0].Cells[0].Value.ToString();

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
            var val = this.dataGridViewClientsTable.SelectedRows[0].Cells[0].Value.ToString();

            //if the value is null or the length of the value is null, the client id is invalid
            if (val == null || val.Length == 0) return;

            //reading the clientid as an integer
            int clientId = int.Parse(val);

            //show a confirmation dialog
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this client?",
                "Delete Client", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) {  return; }
            
            var repo = new ClientRepository();
            repo.DeleteClient(clientId);

            ReadClients();

        }
    }
}
