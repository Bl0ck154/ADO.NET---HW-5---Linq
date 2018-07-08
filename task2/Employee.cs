using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	class Employee
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public int DepId { get; set; }
		public override string ToString()
		{
			return FirstName + " " + LastName + " " + Age + " years old.";
		}
	}
}
