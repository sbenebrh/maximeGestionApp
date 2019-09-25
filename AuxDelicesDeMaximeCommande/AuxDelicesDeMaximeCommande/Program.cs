using System;

namespace AuxDelicesDeMaximeCommande
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("samuel", "benibgui", "0000000", "benebrhi@gmail.com");
            DateTime date = DateTime.Today.AddDays(1);
            Order order = new Order(client, date);

            for(int i = 0; i < 10;++i)
            {
                SweetedPlate plate = new SweetedPlate("Coco Passion", 10, 3, "Joyeux Anniversaire");
                order.AddSweetPlate(plate);
            }

            for (int i = 0; i < 10; ++i)
            {
                SaltedPlate plate = new SaltedPlate("fricasser",  30.0 );
                order.AddSaltedPlate(plate, i);
            }

            Console.Write(order.ToString());
           
        }
    }
}
