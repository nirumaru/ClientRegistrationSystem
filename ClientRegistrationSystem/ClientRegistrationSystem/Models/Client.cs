using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRegistrationSystem.Models
{
    //defining Client class
    public class Client
    {
        // the fields id, name, email, phonenumer, address will serve as attributes of the Client class
        public int id;
        public string name { get; set; } = "";
        public string email { get; set; } = "";
        public string phonenumber { get; set; } = "";
        public string address { get; set; } = "";
        public string category { get; set; } = "";


    }
}
