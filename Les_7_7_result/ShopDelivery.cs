using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_7_7_result
{
    internal class ShopDelivery : Delivery
    {
        // описание класса с доставкой в магазин
        // лениво писать сначала переменные потом свойства

        public string NameShop { get; set; }
        public string ContactFace { get; set; }

        // конструктор класса
        public ShopDelivery (string adres, string shop, string face) : base(adres)
        {
            NameShop = shop;
            ContactFace = face;
        }

        // метод класса
        public override void GetInfoAboutDelivery()
        {
            Console.WriteLine("Адрес доставки: {0}", AdresDelivery);
            Console.WriteLine("Название магазина: {0}", NameShop);
            Console.WriteLine("Контактное лицо в магаазине: ", ContactFace);
        }

    }
}
