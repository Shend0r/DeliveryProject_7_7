using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryProject_7_7.Classes
{
    internal class Order<DeliveryNumber> : Delivery
    {
        private static PickPointDelivery pickPointDelivery;
        private static HomeDelivery homeDelivery;

        public DeliveryNumber ID { get; set; }
        private protected string senderName { get; set; }
        private protected string userName { get; set; }

        public string SenderName
        {
            get
            {
                return senderName;
            }

            private set
            {
                senderName = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            private set
            {
                userName = value;
            }
        }

        public Order () { }

        public Order (byte DeliveryType, string SenderName, string UserName)
        {
            this.DeliveryType = DeliveryType;
            this.senderName = SenderName;
            this.userName = UserName;

            switch (DeliveryType)// Незнаю зачем здесь оператор свитч, пока ещё не придумал
            {
                case (byte)Type.ShopDelivery:
                    this.Address = "thisStoreAddress";
                    break;
            }// вспомнил, не хотел переписывать код под if / else, как-то топорненько выглядеть будет в данных обстоятельствах это
        }

        public Order(byte DeliveryType, string Address, string SenderName, string UserName)
        {
            this.senderName = SenderName;
            this.userName = UserName;

            switch (DeliveryType) // Хотя нет, в этом изначально был смысл, но спустя сотни лет и изнурительной битвы кровью и потом с ООП я понял что ничего не понял (На самом деле понял, намног больше нежели знал год назад)
            {
                case (byte)Type.HomeDelivery:
                    this.Address = Address;
                    break;

                    //Будем считать что есть ещё Тип доставки, где-то на улице или у метро, типо как на дом, но не совсем (типо скидочка за доставку, мб?)
            }
        }

        private protected void DisplayDeliveryNumber()
        {
            Console.WriteLine("Номер заказа : {0}", this.ID);
        }

        private protected void DisplaySenderName()
        {
            Console.WriteLine("Отправитель : {0}", this.SenderName);
        }

        private protected void DisplayUserName()
        {
            Console.WriteLine("Получатель : {0}", this.UserName);
        }

        private protected void DisplayDeliveryAddress()
        {
            Console.WriteLine("Адрес выдачи : {0}", this.Address);
        }

        public void DisplayOrder(string Basket, StoreDelivery storeDelivery)
        {
            DisplayDeliveryNumber(); // Показываем айдишку
            DisplaySenderName(); // Имя отправителя
            DisplayUserName(); // И конечно-же заказчика

            switch (this.DeliveryType)
            {
                case (byte)Type.HomeDelivery:
                    homeDelivery = new HomeDelivery(0); // Будем считать, что 0 это данные из Интерфейса
                    //Будем считать что здесь дополнительная логика, но так-как нету конкретной задачи что должно находится в сервисе доставки, мои полномочия всё, как говорится
                    Helpers.DeliveryServices deliveryServices = new Helpers.DeliveryServices("КрутойСервисДоставки1,КрутойСервисДоставки2");
                    deliveryServices.DisplaySelectedService(homeDelivery.SelectedService);
                    // storeDelivery что-то там, поскольку StoreDelivery имеет основную логику, и что бы нам не писать тысячу строчек кода во всех Delivery Типах и не заниматься не нужным в данном случае обобщением
                    break;

                case (byte)Type.PickUpDelivery:
                    pickPointDelivery = new PickPointDelivery(0); // И тут тоже данные из Интерфейса
                    // И тут дополнительная логика
                    Helpers.PickPoints pickPoints = new Helpers.PickPoints("КрутойСервисВыдачи1,КрутойСервисВыдачи2");
                    pickPoints.DisplaySelectedPickPoint(pickPoints.SelectedPoint);
                    this.Address = "Где-то потерялся Адрес Пункта Выдачи (Это не ошибка ес что)";
                    // тут так же storeDelivery что-то там
                    break;

                case (byte)Type.ShopDelivery:
                    // storeDelivery что-то там :)
                    break;
            }

            DisplayDeliveryAddress(); // Показываем адрес выдачи

            Helpers.Basket basket = new Helpers.Basket(Basket);
            basket.DisplayBasket(); // Ну и про корзину тоже не забываем
        }
    }
}
