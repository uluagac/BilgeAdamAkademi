using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _19_Class_Study_.Abstract;

namespace _19_Class_Study_.Data
{
    public class Seller : User, ISellerService
    {
        // Fields
        private string _email;
        private List<Product> _products;


        // Constructor
        public Seller(string email, List<Product> products) : base(email)
        {
            Email = email;
            _products = products;
        }


        // Properties
        public string Email
        {
            get
            {
                return _email.Split('@')[0];
            }
            set
            {
                _email = value.ToLower();
            }
        }


        // Override Method
        public override void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine($"Hoş geldin {Email}. Ne yapmak istersin?\n");
            Console.WriteLine("1 - Ürünleri Listele\t2 - Ürün Ekle\t3 - Ürün Kaldır\t4 - Ürün Güncelle");
            string MenuSelection = Console.ReadLine();
            switch (MenuSelection)
            {
                case "1":
                    ListAllProducts();
                    break;
                case "2":
                    AddProduct();
                    break;
                case "3":
                    DeleteProduct();
                    break;
                case "4":
                    UpdateProduct();
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Geçersiz bir işlem seçildi...");
                    Thread.Sleep(500);
                    Console.ResetColor();
                    Console.Clear();
                    ShowMenu();
                    break;
            }
        }


        // Methods
        public void ListAllProducts(bool showMenuMessage = true)
        {
            Console.Clear();
            Console.WriteLine("Ürün Listesi:\n");
            foreach (Product product in _products)
            {
                Console.WriteLine(product.ToString());
            }
            if (showMenuMessage)
            {
                Console.WriteLine("\nMenüye dönmek için bir tuşa basın!");
                Console.ReadKey();
                ShowMenu();
            }
        }
        public void AddProduct()
        {
            Console.Write("Lütfen ürün adını girin:");
            string PName = Console.ReadLine();
            Console.Write("Lütfen ürün fiyatını girin:");
            double PPrice = double.Parse(Console.ReadLine());
            Console.Write("Lütfen stok girin: ");
            int PStock = int.Parse(Console.ReadLine());
            Product product = new Product(PName, PPrice, PStock);
            _products.Add(product);
            ListAllProducts(true);
        }
        public void DeleteProduct()
        {
            ListAllProducts(false);
            Console.Write("Lütfen silmek istediğiniz ürünün id'sini seçin: ");
            int SelectId = int.Parse(Console.ReadLine());
            Product ProductToRemove = null;
            foreach (Product product in _products)
            {
                if (product.Id == SelectId)
                {
                    ProductToRemove = product;
                }
            }
            if (ProductToRemove == null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Listede böyle bir ürün yok.");
                Console.ResetColor();
                Thread.Sleep(1000);
                DeleteProduct();
            }
            _products.Remove(ProductToRemove);
            ListAllProducts(true);
        }
        public void UpdateProduct()
        {
            ListAllProducts(false);
        }
    }
}
