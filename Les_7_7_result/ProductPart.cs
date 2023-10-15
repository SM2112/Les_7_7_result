using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_7_7_result
{
    internal class ProductPart : Product
    {
        // описание партии продукта,  который организация купила в рразличнное время
        // поля класса
        private long    idProductPart;         // ID партии прродукта
        public  string  provider;              // поставщик 
        private double  valuePart;             // объем партии
        public  decimal priceIn;               // закупочная цена за единицу товара

        // поля класса 
        public long IDProductPart
        {
            get
            {
                return idProductPart;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Передан некорректный ID");
                }
                else
                {
                    idProductPart = value;
                }
            } 
        }

        public double ValuePart
        {
            get 
            {
                return valuePart;
            }
            set 
            {
                if (value <= 0)
                {
                    Console.WriteLine("Вы ввели некоррректный объем купленной партии товара!");
                }
                else
                {
                    valuePart = value;
                }
            }
        }

        // конструктор класса + мы используем конструктор базового класса для сокращения кода
        public ProductPart(int idProduct, string nameProduct, long idProductPart, double valuePart) : base(idProduct, nameProduct)
        {
            this.idProductPart = idProductPart;
            this.valuePart = valuePart;
        }

        // ну и для полноты картины добавляем метод класса, который осннован на методе родительского класса
        // здесь конечно лучше бы его переименовать так, как мы выводим информацию не про продукт а про его часть
        // ну чего не сделаешь ради того, что бы показать как научились за ОДНУ неделю ООП
        public virtual void GetProductInfo()
        {
            base.GetProductInfo();
            Console.WriteLine("ID партии продукта: {0}", IDProductPart);
            Console.WriteLine("Количество купленного продукта {0} ", ValuePart);
            if (provider != null)
            {
                Console.WriteLine("Поставщик: ", provider);
            }
            Console.WriteLine("Закупочная цена партии: ", priceIn);
        }
    }
}
