using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP_1
{
    public class Technic:Person
    {
        private int stag;
        private int rate;
        private int cr;
		public Technic(string Name, string SurName, int stag, int rate, int cr = 0) : base(Name, SurName)
    {
	this.stag = stag;
	this.rate = rate;
	this.cr = cr;
    }
		public override string ToString()
		{
			return $"Tech {base.ToString()} {stag} {rate} {cr}\n";
		}
		public string getName()
		{
			return Name;
		}

		public string getSurname()
		{
			return SurName;
		}

		public int getstag()
		{
			return stag;
		}

		public int getrate()
		{
			return rate;
		}

		public void setrate(int rate)
		{
			this.rate = rate;
		}

		public void setcr(int cr)
		{
			this.cr = cr;
		}

		public int getcr()
		{
			return cr;
		}

	}
}
