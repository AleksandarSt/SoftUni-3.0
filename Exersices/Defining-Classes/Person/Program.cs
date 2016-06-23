using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Person
{
	class Program
	{
		static void Main()
		{
		    int numberOfLines = int.Parse(Console.ReadLine());
            List<Person> persons =new List<Person>();

		    for (int i = 0; i < numberOfLines; i++)
		    {
		        string[] line = Console.ReadLine().Split();

		        persons.Add(new Person(int.Parse(line[1]), line[0]));
		    }

		    foreach (var person in persons.Where(x=>x.age>30).OrderBy(x=>x.name))
		    {
		        Console.WriteLine($"{person.name} - {person.age}");
		    }
		}

	}
}
