using System;
using System.Collections.Generic;
using System.Text;

namespace AuxDelicesDeMaximeCommande
{
    class Client
    {

        public string m_firstname { get; }
        public string m_lastname { get; }

        public string m_phoneNumber { get; set; }

        public string m_email { get; set; }

        public Client(string firstname, string lastname, string phoneNumber, string email ="")
        {
            this.m_firstname = firstname;
            this.m_lastname = lastname;
            this.m_phoneNumber = phoneNumber;
            this.m_email = email;
        }

        public override string ToString()
        {
            string result = this.m_firstname + " " + this.m_lastname + "\n";
            result += this.m_phoneNumber + "\n";
            result += this.m_email + "\n";

            return result;
        }
    }
}
