using System;

namespace DeliveryProject_7_7.Classes.Helpers
{
    internal class DeliveryServices : HomeDelivery
    {
        public string Data { get; private set; }

        public DeliveryServices(string Data)
        {
            this.Data = Data;

            Services = Data.Split(',');
        }

        public override void DisplayAvailableServices()
        {
            foreach (string Service in Services)
            {
                Console.WriteLine(Service);
            }
        }

        public void DisplaySelectedService(byte SelectedService)
        {
            Console.WriteLine("Выбран сервис доставки : {0}", Services[SelectedService]);
        }
    }
}
