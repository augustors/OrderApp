using CompositionExercise3.Entities.Enums;
using CompositionExercise3.Entities;

namespace CompositionExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string? clientname = Console.ReadLine();
            Console.Write("Email: ");
            string? clientemail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            Client c = new Client(clientname, clientemail, birthdate);

            Order order = new Order(DateTime.Now, c, orderStatus);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #" + i + " item data: ");
                Console.Write("Product name: ");
                string? productname = Console.ReadLine();
                Console.Write("Product price: ");
                double productprice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int qtd = int.Parse(Console.ReadLine());

                Product product = new Product(productname,productprice);

                OrderItem item = new OrderItem(qtd, productprice, product);

                order.AddItem(item);
            }

            Console.WriteLine(order.ToString()); 
        }
    }
}