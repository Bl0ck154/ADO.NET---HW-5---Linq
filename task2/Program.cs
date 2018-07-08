using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Department> departments = new List<Department>()
			{
			new Department(){ Id = 1, Country = "Ukraine", City = "Donetsk" },
			new Department(){ Id = 2, Country = "Ukraine", City = "Kyiv" },
			new Department(){ Id = 3, Country = "France", City = "Paris" },
			new Department(){ Id = 4, Country = "Russia", City = "Moscow" }
			};

			List<Employee> employees = new List<Employee>()
			{
			new Employee()
			{ Id = 1, FirstName = "Tamara", LastName = "Ivanova", Age = 22, DepId = 2 },
			new Employee()
			{ Id = 2, FirstName = "Nikita", LastName = "Larin", Age = 33, DepId = 1 },
			new Employee()
			{ Id = 3, FirstName = "Alica", LastName = "Ivanova", Age = 43, DepId = 3 },
			new Employee()
			{ Id = 4, FirstName = "Lida", LastName = "Marusyk", Age = 22, DepId = 2 },
			new Employee()
			{ Id = 5, FirstName = "Lida", LastName = "Voron", Age = 36, DepId = 4 },
			new Employee()
			{ Id = 6, FirstName = "Ivan", LastName = "Kalyta", Age = 22, DepId = 2 },
			new Employee()
			{ Id = 7, FirstName = "Nikita", LastName = " Krotov ", Age = 27,DepId = 4 }
			};

			/*1) Выбрать имена и фамилии сотрудников, работающих в Украине, но не в Донецке.
2) Вывести список стран без повторений.
3) Выбрать 3-x первых сотрудников, возраст которых превышает 25 лет.
4) Выбрать имена, фамилии и возраст студентов из Киева, возраст которых превышает
23 года */
			Console.WriteLine("Выбрать имена и фамилии сотрудников, работающих в Украине, но не в Донецке.");
			var result = from item in employees
						 join dep in departments on item.DepId equals dep.Id
						 where dep.Country == "Ukraine" && dep.City != "Donetsk"
						 select item.FirstName + " " + item.LastName;
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();

			Console.WriteLine("Вывести список стран без повторений.");
			foreach (var item in departments.Select(c => c.Country).Distinct())
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();
			
			Console.WriteLine("Выбрать 3-x первых сотрудников, возраст которых превышает 25 лет.");
			foreach (var item in employees.Where(e => e.Age > 25).Take(3))
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();

			Console.WriteLine("Выбрать имена, фамилии и возраст студентов из Киева, возраст которых превышает 23 года");
			foreach (var item in from emp in employees
								 join dep in departments on emp.DepId equals dep.Id
								 where dep.City == "Kyiv" && emp.Age > 23
								 select emp.FirstName + " " + emp.LastName + " " + emp.Age)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();

			/*task 3 
			 * 1) Упорядочить имена и фамилии сотрудников по алфавиту, которые проживают в
Украине. Выполнить запрос немедленно. 
2) Отсортировать сотрудников по возрастам, по убыванию. Вывести Id, FirstName,
LastName, Age. Выполнить запрос немедленно.
3) Сгруппировать студентов по возрасту. Вывести возраст и сколько раз он встречается
в списке. */
			Console.WriteLine("Упорядочить имена и фамилии сотрудников по алфавиту, которые проживают в Украине.Выполнить запрос немедленно. ");
			var result2 = (from emp in employees
						   join dep in departments on emp.DepId equals dep.Id
						   where dep.Country == "Ukraine"
						   orderby emp.FirstName, emp.LastName
						   select emp).ToArray();
			foreach (var item in result2)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();

			Console.WriteLine("Отсортировать сотрудников по возрастам, по убыванию. Вывести Id, FirstName,LastName, Age.");
			var result3 = employees.OrderByDescending(e => e.Age).ToList();
			foreach (var item in from e in result3 select e.Id + " " + e.FirstName + " " + e.LastName + " " + e.Age)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();

			Console.WriteLine("Сгруппировать студентов по возрасту. Вывести возраст и сколько раз он встречается в списке.");
			var result4 = from emp in employees
						  group emp by emp.Age into g
						  select new { Name=g.Key, Count=g.Count() };
			foreach (var item in result4)
			{
				Console.WriteLine(item);
			}
		}
	}
}
