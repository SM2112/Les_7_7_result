using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_7_7_result
{
    internal class Order <TDelivery> where TDelivery : Delivery
    {
        // возможно нужно было наоборот 
        // что родитель заказ, а дочка корзина
        // но обычно сначала поокупатель набирает корзину и только потом собрав ее делает заказ
        // кроме того, например в Ашане в личном кабинете последняя корзина сохраняется

        // поля класса
        private int numberOrder;
        private string client;
        public BasketOrder basketOrder = new BasketOrder(); // у каждого заказа должна быть корзина
        
        
        // свойства класса
        public int NumberOrder
        {
            get
            {
                return numberOrder;
            }
            set 
            {
                if (value > 0)
                {
                    numberOrder = value;
                }
                else
                {
                    Console.WriteLine("Введенный ID заказа противоречит диапазону  возможных знначений!");
                }
            } 
        }

        public string Client
        {
            get
            {
                return client;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Значение клиента не заполнено!");
                }
                else 
                {
                    client = value;
                }
            }
        }


    }
}
