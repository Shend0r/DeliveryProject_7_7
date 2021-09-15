using System;

namespace DeliveryProject_7_7.Classes
{
    internal class HomeDelivery : Delivery
    {
        public string[] Services { get; set; }
        public byte SelectedService { get; private set; }

        public HomeDelivery() { }

        public HomeDelivery(byte SelectedService)
        {
            this.SelectedService = SelectedService;
        }

        public virtual void DisplayAvailableServices()
        {
            foreach (string Service in Services)
            {
                Console.WriteLine(Service);
            }
        }
    }
}
