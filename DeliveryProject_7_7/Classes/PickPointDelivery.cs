using System;

namespace DeliveryProject_7_7.Classes
{
    internal class PickPointDelivery : Delivery
    {
        public string[] PickUpPoints { get; set; }

        public byte SelectedPoint { get; private set; }

        public byte StorageDays { get; private set; }

        public PickPointDelivery() { }

        public PickPointDelivery(byte SelectedPoint) 
        {
            this.SelectedPoint = SelectedPoint;
        }

        public virtual void DisplayAvailablePickPoints()
        {
            foreach (string Point in PickUpPoints)
            {
                Console.WriteLine(Point);
            }
        }

        public byte GetStorageDays(byte Value = 0)
        {
            if (Value == 0)
            {
                Value = (byte)StorageDaysValue.Default;
            }

            return Value;
        }

        public enum StorageDaysValue
        {
            Default = 5
        }
    }
}
