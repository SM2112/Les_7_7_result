using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_7_7_result
{
    
    /// <summary>
    /// здесь будет описываться класс Product
    /// а так же перечисление категорий продуктов
    /// а так же перечисление 
    /// </summary>
   

    enum ProductCategory
    { 
        Фрукты = 1,
        Овощи,
        Напитки,
        Хлеб,
        Мясо
    }

    enum ProductMeasurement
    { 
        шт = 1,
        л,
        кг   
    }

    internal class Product
    {
        
        // переменные класса
        public ProductCategory productCategory;
        public ProductMeasurement productMeasurement;  // в чем измеряется продукт
        private int idProduct;                         // есть соответствующее свойство
        private string nameProduct;                    // есть соответствующее свойство
        public  string descriptionProduct;
        public  decimal priceOut;                      // цена продажи продукта
                                                       // под нее не буду делать свойства хотя и надо
                                                

        // свойства класса
        public int IDProduct
        {
            get 
            {
                return idProduct;
            }
            set
            {
                // считаем, что нельзя ставить ID продукта меньше -1
                // в принципе можно было поставить тип uint но что бы удовлетворить желание скилов сделаю проверку set
                if (value > 0)
                {
                    idProduct = value;
                }
                else
                {
                    Console.WriteLine("ID продукта  не может быть меньше 1!");
                }
            
            }
        
        }
        public string NameProduct
        {
            get 
            {
                return nameProduct;
            }
            set 
            {
                // делаем проверку на null или пустую строку
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Вы не ввели значение продукта! Пожалуйста внимательно работайте с данными!");
                }
                else
                { 
                    nameProduct = value;
                }      
            }
        
        }

        // конструктор класса
        // в конструктор передаем только ID и название. Остальное можно и потом добавить
        public Product(int idProduct, string nameProduct)
        {
            this.idProduct   = idProduct;
            this.nameProduct = nameProduct;
        }

        // метод класса 
        public virtual void GetProductInfo()
        {
            Console.WriteLine("ID продукта: {0}", IDProduct);
            Console.WriteLine("Продукт: {0}", NameProduct);
            if (descriptionProduct != null)
            {
                Console.WriteLine("Описание продукта: {0}", descriptionProduct);
            }

            if (productCategory != null && productCategory != 0)
            {
                Console.WriteLine("Категория продукта: {0}", productCategory);
            }
            if (productMeasurement != 0 && productMeasurement != 0)
            {
                Console.WriteLine("Продукт измеряется в {0}", productMeasurement);
            }
            Console.WriteLine("Отпускная цена продукта: {0}", priceOut);
        }



    }
}
