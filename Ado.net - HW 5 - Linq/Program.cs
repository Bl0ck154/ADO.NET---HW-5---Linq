using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.net___HW_5___Linq
{
	class Program
	{
		/*1) Выбрать людей, старших 25 лет.
2) Выбрать людей, проживающих не в Киеве.
3) Выбрать имена людей, проживающих в Киеве.
4) Выбрать людей старших 35 лет с именем Sergey.
5) Выбрать людей, проживающих в Москве. */
		static void Main(string[] args)
		{
			List<Person> persons = new List<Person>()
			{
				new Person(){ Name = "Andrey", Age = 24, City = "Kyiv" },
				new Person(){ Name = "Liza", Age = 18, City = "Moscow" },
				new Person(){ Name = "Oleg", Age = 15, City = "London" },
				new Person(){ Name = "Sergey", Age = 55, City = "Kyiv" },
				new Person(){ Name = "Sergey", Age = 32, City = "Kyiv" }
			};

			Console.WriteLine("Выбрать людей, старших 25 лет.");
			foreach (var item in persons.Where(p => p.Age > 25))
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();

			Console.WriteLine("Выбрать людей, проживающих не в Киеве.");
			foreach (var item in persons.Where(p => p.City != "Kyiv"))
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();

			Console.WriteLine("Выбрать имена людей, проживающих в Киеве");
			foreach (var item in persons.Where(p => p.City == "Kyiv"))
			{
				Console.WriteLine(item.Name);
			}
			Console.WriteLine();

			Console.WriteLine("Выбрать людей старших 35 лет с именем Sergey.");
			foreach (var item in persons.Where(p => p.Name == "Sergey" && p.Age > 35))
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();

			Console.WriteLine("Выбрать людей, проживающих в Москве.");
			foreach (var item in persons.Where(p => p.City == "Moscow"))
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();
		}
	}
}
