using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP_1
{
    public class Customer:Person
    {
		public int number { get; }
		public Customer(string Name, string SurName, int number):base(Name,SurName)
		{
			
			this.number = number;
		}
		public override string ToString()
		{
			return $"{base.ToString()} {number}";
		}
		public string getname()
		{
			return Name;
		}
		public string getsurname()
		{
			return SurName;
		}

	}
}
