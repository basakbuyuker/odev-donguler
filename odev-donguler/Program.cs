using System;

namespace odev_donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pro = new Product();
            pro.UrunAdi = "Bilgiaayr";
            pro.Fiyati = 1000;

            Product pro2 = new Product();
            pro2.UrunAdi = "Telefon";
            pro2.Fiyati = 2000;

            Product pro3 = new Product();
            pro3.UrunAdi = "Buzdolabı";
            pro3.Fiyati = 700;

            Product pro4 = new Product();
            pro4.UrunAdi = "Ayakkabı";
            pro4.Fiyati = 800;

            Product[] products = new Product[] { pro, pro2, pro3, pro4 };

            Console.WriteLine("----------FOR DONGUSU----------");
            for(int a = 0; a < products.Length; a++)
            {
                Console.WriteLine(products[a].UrunAdi + " : " + products[a].Fiyati);
            }

            Console.WriteLine("----------FOREACH DONGUSU----------");
            foreach (Product product in products)
            {
                Console.WriteLine(product.UrunAdi + " : " + product.Fiyati);
            }


            Console.WriteLine("----------WHILE DONGUSU----------");
            int i = 0;
            while (i < products.Length)
            {
                Console.WriteLine(products[i].UrunAdi + " : " + products[i].Fiyati);
                i++;
            }
        }
    }
}
