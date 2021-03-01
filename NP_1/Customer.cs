using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP_1
{
    public class Customer:Person
    {
        private int number;
		public Customer(string Name, string SurName, int number):base(Name,SurName)
		{
			
			this.number = number;
		}
		public override string ToString()
		{
			return $"Customer info:\n{base.ToString()} Phone:{number}\n";
		}
		public string getname()
		{
			return Name;
		}
		public string getsurname()
		{
			return SurName;
		}
		public int getnumber()
		{
			return number;
		}
	}
}
