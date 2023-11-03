using csharp_exercise_enum_comp.Entities;
using csharp_exercise_enum_comp.Entities.Enums;
using System.Globalization;

namespace csharp_exercise_enum_comp
{
    class Program
    {
        static void Main(string[] agrs)
        {   
            Console.WriteLine("Enter Client Data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Order data");
            Console.WriteLine("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine("How many items to this order");
            int n = int.Parse(Console.ReadLine());
            Order order = new Order(new Client(name, email, birthDate), status);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{n+1} item data");
                Console.WriteLine("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.WriteLine("Product price");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(nameProduct, priceProduct);
                order.addItem(quantity, product);
            }

            Console.WriteLine(order.ToString());
        }
    }
}