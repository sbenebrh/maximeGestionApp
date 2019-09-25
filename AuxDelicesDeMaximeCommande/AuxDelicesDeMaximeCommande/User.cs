using System;
using System.Collections.Generic;
using System.Text;

namespace AuxDelicesDeMaximeCommande
{

    class User
    {

        public string m_name { get; set; }
        public string m_password { get; set; }
        public int m_status { get; set; }

        public User(string m_name, string m_password, int m_status)
        {
            this.m_name = m_name;
            this.m_password = m_password;
            this.m_status = m_status;
        }

    }
}
