using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_7_7_result
{
    // здесь просто  используем предложенный класс с доставкой
    internal abstract class Delivery
    {
        // поле класса
        private string adresDelivery;

        // свойства класса
        public string AdresDelivery
        {
            get 
            {
                return adresDelivery;
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Адрес не заполнен!");
                }
                else
                {
                    adresDelivery = value;
                }
            }
        }

        // конструктор класса
        public Delivery(string adres)
        {
            adresDelivery = adres;
        }

        // метод класса 
        public abstract void GetInfoAboutDelivery();
       


    }
}
