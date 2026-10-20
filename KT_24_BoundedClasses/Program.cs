using System;

namespace KT_24_BoundedClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<Product> productRepo = new Repository<Product>();
            Repository<Customer> customerRepo = new Repository<Customer>();

            Console.WriteLine("=== Ввод товаров (Product) ===");
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine($"Введите данные для товара #{i}:");
                Console.Write("  Введите Id (целое число): ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("  Введите название товара: ");
                string name = Console.ReadLine();

                productRepo.Add(new Product(id, name));
            }

            Console.WriteLine("\n=== Ввод клиентов (Customer) ===");
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine($"Введите данные для клиента #{i}:");
                Console.Write("  Введите Id (целое число): ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("  Введите Email: ");
                string email = Console.ReadLine();

                customerRepo.Add(new Customer(id, email));
            }

            Console.WriteLine("\n--- Проверка поиска товаров (GetById) ---");
            Console.Write("Введите Id товара для поиска: ");
            int searchProductId = int.Parse(Console.ReadLine());
            Product? foundProduct = productRepo.GetById(searchProductId);
            Console.WriteLine($"Результат: {(foundProduct == null ? "null (не найден)" : foundProduct.ToString())}");

            Console.WriteLine("\n--- Проверка поиска клиентов (GetById) ---");
            Console.Write("Введите Id клиента для поиска: ");
            int searchCustomerId = int.Parse(Console.ReadLine());
            Customer? foundCustomer = customerRepo.GetById(searchCustomerId);
            Console.WriteLine($"Результат: {(foundCustomer == null ? "null (не найден)" : foundCustomer.ToString())}");
        }
    }
}