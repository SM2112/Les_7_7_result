using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_7_7_result
{
    internal class PickPointDelivery : Delivery
    {
        // описание класса с доставкой на пункт выдачи
        // поля класса
        // не уверен что здесь будет область видимости корректная
        DateTime timeOpen = new DateTime();
        DateTime timeClose = new DateTime();

        // конструктор класса
        public PickPointDelivery(string adres, DateTime open, DateTime close) : base(adres)
        {
            timeOpen = open;
            timeClose = close;
        }

        public override void GetInfoAboutDelivery()
        {
            Console.WriteLine("Адрес доставки: {0}", AdresDelivery);
            Console.WriteLine("Время открытия точки: {0}", timeOpen);
            Console.WriteLine("Время закрытия точки: ", timeClose);
        }



    }
}
