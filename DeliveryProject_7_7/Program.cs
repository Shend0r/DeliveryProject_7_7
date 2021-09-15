using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryProject_7_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // THIS IS демонстрация и то, на сколько я понял, не весь код задействовал, чутка заблудився в нём (с непривычки кодинга на аристократическом ООП)

            Console.WriteLine("----------------------------------------------------------------------------------------\n");

            // Полгода назад моей любовью были публики и стутики, но вы когда нибудь окрашивали строчку кода в 5 цветов ?
            Classes.Order<uint> order = new Classes.Order<uint>((byte)Classes.Delivery.Type.ShopDelivery, "thisShop", "myName");
            order.ID = 1;
            order.DisplayOrder("storeToy1,storeToy2", new Classes.StoreDelivery()); // Будем считать что StoreDelivery имеет основную логику, для всех типов Delivery, поэтому здесь объявлен именно он

            Console.WriteLine("----------------------------------------------------------------------------------------\n");

            //Реально жесть, Белый, Берюзовый, голубой, салатовый и цвет текста ( то ли рыжий, то ли смугло телесный, не разберёшь)
            Classes.Order<uint> order2 = new Classes.Order<uint>((byte)Classes.Delivery.Type.HomeDelivery, "myAddress", "thisShop", "myName");
            order2.ID = 2;
            order2.DisplayOrder("homeToy1,homeToy2", new Classes.StoreDelivery()); // Основная логика в StoreDelivery, бла-бла-бла

            Console.WriteLine("----------------------------------------------------------------------------------------\n");

            Classes.Order<uint> order3 = new Classes.Order<uint>((byte)Classes.Delivery.Type.PickUpDelivery, "thisShop", "myName");
            order3.ID = 3;
            order3.DisplayOrder("pointToy1,pointToy2", new Classes.StoreDelivery()); // бла-бла

            Console.WriteLine("----------------------------------------------------------------------------------------\n");

            Console.ReadLine();

            // По истине, меня в программировании ничего не пугает (Assembler и прочие машинные кода не в счёт), но вот это ООП, брррр
        }
    }
}
