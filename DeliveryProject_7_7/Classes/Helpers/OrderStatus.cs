using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryProject_7_7.Classes.Helpers
{
    internal class OrderStatus
    {
        public OrderStatus() { }

        public static string GetOrderStatus(byte OrderStatusID)
        {
            var value = default(string);

            switch (OrderStatusID)
            {
                case (byte)OrderStatus.OrderStatusID.NotStarted:
                    value = "NotStarted";
                    break;

                case (byte)OrderStatus.OrderStatusID.Packaging:
                    value = "Packaging";
                    break;

                case (byte)OrderStatus.OrderStatusID.Sending:
                    value = "Sending";
                    break;

                case (byte)OrderStatus.OrderStatusID.Delivered:
                    value = "Delivered";
                    break;
            }

            return value;
        }

        public enum OrderStatusID
        {
            NotStarted,
            Packaging,
            Sending,
            Delivered
        }
    }
}
