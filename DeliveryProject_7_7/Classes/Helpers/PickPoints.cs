using System;

namespace DeliveryProject_7_7.Classes.Helpers
{
    internal class PickPoints : PickPointDelivery
    {
        public string Data { get; private set; }

        public PickPoints(string Data)
        {
            this.Data = Data;

            PickUpPoints = Data.Split(',');
        }

        public override void DisplayAvailablePickPoints()
        {
            foreach (string point in PickUpPoints)
            {
                Console.WriteLine(point);
            }
        }

        public void DisplaySelectedPickPoint(byte SelectedPickPoint)
        {
            Console.WriteLine("Выбран пункт выдачи : {0}", PickUpPoints[SelectedPickPoint]);
        }
    }
}
