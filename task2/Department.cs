﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	class Department
	{
		public int Id { get; set; }
		public string Country { get; set; }
		public string City { get; set; }
		public override string ToString() => Id + " " + Country + " " + City;
	}
}
