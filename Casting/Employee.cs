﻿using System;
namespace Casting
{
	public class Employee
	{
		public int Age { get; set; }
		public int Id { get; set; }

		public static bool operator >(Employee emp1,Employee emp2)
		{
			return emp1.Age > emp2.Age;
		}

        public static bool operator <(Employee emp1, Employee emp2)
        {
            return emp1.Age < emp2.Age;
        }
    }
}

