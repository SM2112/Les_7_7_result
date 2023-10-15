using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_7_7_result
{
    internal class HomeDelivery : Delivery
    {
        // описание класса доставки на дом
        // переменные класса 
        public string ClientFIO { get; set; }
        public string ContactPhoneNumber { get; set; }

        public HomeDelivery(string adres, string client, string number) : base (adres)
        {
            ClientFIO = client;
            ContactPhoneNumber = number;
        }

        public override void GetInfoAboutDelivery()
        {
            Console.WriteLine("Адрес доставки: {0}", AdresDelivery);
            Console.WriteLine("Клиент: {0}", ClientFIO);
            Console.WriteLine("Контактный номер: ", ContactPhoneNumber);
        }
    }
}
