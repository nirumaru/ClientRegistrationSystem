using ClientRegistrationApp.Models;
using ClientRegistrationApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientRegistrationApp
{
    public partial class CreateEditForm : Form
    {
        public CreateEditForm()
        {
            InitializeComponent();

            
            //turning this form into a dialog box and setting the default dialog result to cancel
            this.DialogResult = DialogResult.Cancel;

        }


        //creating a private field
        //0 means we create a new client
        private int clientId = 0;



        //creating a new method that lets us display the client details
        public void EditClient(Client client)
        {
            //changing the name and the title of the form
            this.Text = "Edit Cient";
            this.lblEnroll.Text = "Edit Client";

            //adding empty string before client id because the label asks for string
            this.lblClientIdNumber.Text = "" + client.id;
            this.txtboxName.Text = client.name;
            this.txtboxEmail.Text = client.email;
            this.txtboxPhoneNumber.Text = client.phonenumber;
            this.txtboxAddress.Text = client.address;

            this.clientId = client.id;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //creating a client object and filling it using the data of the form
            Client client = new Client();

            //based on this.clitnId value, a new client is created or an existing one is edited
            client.id = this.clientId;
            client.name = this.txtboxName.Text;
            client.email = this.txtboxEmail.Text;
            client.phonenumber = this.txtboxPhoneNumber.Text;
            client.address = this.txtboxAddress.Text;

            //saving the client data into the database
            //creating an object named repo using the class ClientRepository
            var repo = new ClientRepository();

            if (client.id == 0)
            {
                //calling the CreateClient method in the ClientRepository class 
                repo.CreateClient(client);
            }
            else
            {
                //calling the UpdateClient method in the ClientRepository class
                repo.UpdateClient(client);
                
            }




            //returning the dialog result as OK
            this.DialogResult = DialogResult.OK;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //returning the dialog result as cancel
            this.DialogResult= DialogResult.Cancel;

        }
    }
}
