namespace DeliveryProject_7_7.Classes
{
    internal abstract class Delivery
    {
        public byte DeliveryType { get; set; }
        public string Address { get; set; }
        public string[] Products { get; set; }

        public enum Type
        {
            HomeDelivery = 0,
            PickUpDelivery = 1,
            ShopDelivery = 2
        }
    }
}
