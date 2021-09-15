using System;

namespace DeliveryProject_7_7.Classes.Helpers
{
    internal class Basket
    {
        public string Data { get; private set; }

        public Basket(string Data)
        {
            this.Data = Data;
        }

        public void DisplayBasket()
        {
            var userBasket = Data.Split(',');

            Console.WriteLine("\nКорзина :");

            foreach (string product in userBasket)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("\n");
        }
    }
}
