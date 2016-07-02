using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.SqlServer.Server;
using Shopping_spree.Models;

namespace Shopping_spree
{
    class Startup
    {
        static void Main()
        {
            try
            {
                var persons = new Dictionary<string, Person>();
                var products = new Dictionary<string, Product>();

                string[] personsInfo = Console.ReadLine()
                    .Split(new[] {';', '='}, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < personsInfo.Length; i += 2)
                {
                    var currentPerson = new Person(personsInfo[i], decimal.Parse(personsInfo[i + 1]));

                    persons.Add(personsInfo[i], currentPerson);
                }

                string[] productsInfo = Console.ReadLine()
                    .Split(new[] {';', '='}, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < productsInfo.Length; i += 2)
                {
                    var currentProduct = new Product(productsInfo[i], decimal.Parse(productsInfo[i + 1]));

                    products.Add(productsInfo[i], currentProduct);
                }

                string command = Console.ReadLine();

                while (command != "END")
                {
                    string[] commandArgs = command.Split();
                    var personName = commandArgs[0];
                    var productName = commandArgs[1];

                    Person person = persons[personName];
                    Product product = products[productName];

                    try
                    {
                        person.BuyProduct(product);
                        Console.WriteLine($"{person.Name} bought {product.Name}");
                    }
                    catch (InvalidOperationException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }

                    command = Console.ReadLine();
                }

                foreach (Person person in persons.Values)
                {
                    Console.WriteLine(person);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
