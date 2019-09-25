using System;
using System.Collections.Generic;
using System.Text;


namespace AuxDelicesDeMaximeCommande
{
    public class SaltedPlate:IEquatable<SaltedPlate>
    {

        public string m_name { get; }
        public double m_price { get; set; }

        public SaltedPlate(string m_name, double m_price)
        {
            this.m_name = m_name;
            this.m_price = m_price;
        }

        public override string ToString()
        {
            string res = "plateau de " + this.m_name + "\n";
  
            return res;
        }

        public override int GetHashCode()
        {
            return this.m_name.GetHashCode();
        }
        public  bool Equals(SaltedPlate other)
        {
            return this.m_name.Equals(other.m_name);
        }
    }
}
