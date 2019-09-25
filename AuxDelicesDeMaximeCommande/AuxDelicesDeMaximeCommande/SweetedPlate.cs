using System;
using System.Collections.Generic;
using System.Text;

namespace AuxDelicesDeMaximeCommande
{
    class SweetedPlate
    {


        public string m_name { get; }
        public int m_part { get; set; }
        public double m_price { get; }
        public string m_payload { get; set; }


        public SweetedPlate(string name, int part, double price, string payload = "")
        {
            this.m_name = name;
            this.m_part = part;
            this.m_price = price;
            this.m_payload = payload;
        }

        public override string ToString()
        {
            string res = "gateau  " + this.m_name + " de " + this.m_part + "parts\n";
            res += this.m_payload + "\n";
            return res;
        }

    }

}
