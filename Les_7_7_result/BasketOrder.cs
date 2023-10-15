using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_7_7_result
{
    internal class BasketOrder
    {
        // класс описывающий корзину продуктов, которые  выбрал пользователь для осуществления заказа
        // должен быть список коретежей 
        // в кортеж должен входить:
        // выбранный продукт;
        // кол-во выбранного продукта

        //переменная класса 
        private int idBasket;              // ID корзины продуктов, которую собирает пользователь

        // поле класса 
        public int IDBasket
        {
            get
            {
                return idBasket;
            }
            set
            {
                if (value > 0)
                {
                    idBasket = value;
                }
                else
                {
                    Console.WriteLine("Введеннный ID корзины противоречит возможным значениям!");
                }
            }
        }

        // формируем переменную типа список, состоящую из двух полей продукта и его кол-ва
        List<(Product productInBasket, double valProduct)> listProduct = new List<(Product, double)>();

        // метод класса (добавляем в список продукт и его кол-во)
        public void AddProductInBasket(Product productInBasket, double valProduct)
        {
            listProduct.Add((productInBasket, valProduct));
            Console.WriteLine("Продукт {0} в количестве {1} {2} успешно добавлен в корзину", productInBasket.NameProduct, valProduct, productInBasket.productMeasurement);
        }

        // далее метод не сам придумал - это ментор подсказал, но мне этот метод понравился
        public void ReturnAllProductsInBasket()
        {
            Console.WriteLine("Вот Ваш список продуктов: ");
            foreach (var item in listProduct)
            {
                Console.WriteLine(item.productInBasket.NameProduct + " " + item.valProduct + " " + item.productInBasket.descriptionProduct);
            }
        }
        

    }
}
