namespace Les_7_7_result
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // сюда не надо смотреть!!!
            // здесь я проводил отдельные эксперименты!!!!!!!!!!!!!!!!!!!!!!

            int i = 100;
            string name = "Хлеб";
            decimal price = 15.25m;
            long j = 155;
            double valPart = 187.2;

            Product product1 = new Product(i, name);
            product1.descriptionProduct = "gdfgg";
            product1.productCategory = ProductCategory.Фрукты;
            product1.productMeasurement = ProductMeasurement.кг;

            product1.GetProductInfo();

            ProductPart productPart1 = new ProductPart(i, name, j, valPart);

            Console.WriteLine(productPart1.IDProduct.ToString());
            Console.WriteLine(productPart1.NameProduct);
            Console.WriteLine(productPart1.IDProductPart);
            Console.WriteLine(productPart1.ValuePart);

            productPart1.GetProductInfo();

            BasketOrder basketOrder1 = new BasketOrder();
            basketOrder1.AddProductInBasket(product1, 25);
            basketOrder1.ReturnAllProductsInBasket();

        }
    }
}