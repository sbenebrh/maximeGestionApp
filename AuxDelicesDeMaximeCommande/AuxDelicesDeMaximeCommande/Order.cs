using System;
using System.Collections.Generic;
using System.Text;

namespace AuxDelicesDeMaximeCommande
{
    class Order
    {
        public Client m_client { get; }

        public DateTime m_bookedDay { get; }
        public DateTime m_deliveryDay { get; set; }

        public List<SweetedPlate> m_sweetedPlates { get; set; }
        public Dictionary<SaltedPlate, int > m_saltedPlates { get; set; }


        public Order(Client client, DateTime deliveryDay)
        {
            this.m_client = client;
            this.m_deliveryDay = deliveryDay;

            this.m_bookedDay = DateTime.Now;

            this.m_sweetedPlates = new List<SweetedPlate>();
            this.m_saltedPlates = new Dictionary<SaltedPlate, int>();
        }

        public void AddSweetPlate(SweetedPlate plate)
        {
            this.m_sweetedPlates.Add(plate);
        }

        public void AddSaltedPlate(SaltedPlate plate, int quantity)
        {
            bool res = this.m_saltedPlates.ContainsKey(plate);
            if (res)
            {
                m_saltedPlates[plate] += quantity;
            }
            else
            {
                this.m_saltedPlates.Add(plate, quantity);
            }
        }

        public override string ToString()
        {
            string result = m_client.ToString();
            result += "delivrance le " + m_deliveryDay + "\n";
            result += "............Delivery details ..............." + "\n";
            foreach (var obj in m_sweetedPlates)
            {
                result += obj.ToString() + "\n";
            }

            foreach (var obj in m_saltedPlates)
            {
                result += obj.Key + obj.Value.ToString() + "\n";
            }

            return result;
        }
    }

    
}
