using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.net___HW_5___Linq
{
	public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public string City { get; set; }
		public override string ToString() => Name + " " + Age + " years old, from " + City;
	}
}
