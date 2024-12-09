using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRegistrationApp.Models
{

    //defining a class named Client so that a Client object can be created
    public class Client
    {
        // the fields id, name, email, phonenumer, address will serve as attributes of the Client class
        // TODO: use get set on each of these fields or attributes
        public int id;
        public string name = "";
        public string email = "";
        public string phonenumber = "";
        public string address = "";
    }
}
