using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP_1
{
    public class Technic:Person
    {
		public int stag { get; }
		public int rate { get; set; }
		public int cr { get; set; }
		public Technic(string Name, string SurName, int stag, int rate, int cr = 0) : base(Name, SurName)
    {
	this.stag = stag;
	this.rate = rate;
	this.cr = cr;
    }
		public override string ToString()
		{
			return $"{base.ToString()} {stag} {rate} {cr}";
		}
		public string getName()
		{
			return Name;
		}

		public string getSurname()
		{
			return SurName;
		}

	}
}
