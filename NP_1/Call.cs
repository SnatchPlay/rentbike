using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP_1
{
    public class Call : Person
    {
        private int stag;
        private int calls;
        public Call(string Name, string SurName, int stag, int calls) : base(Name, SurName)
        {
            this.stag = stag;
            this.calls = calls;
        }
        public override string ToString()
        {
            return $"Call {base.ToString()} {stag}\n";
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

        public int getcalls()
        {
            return calls;
        }

        public void setcall(int calls)
        {
            this.calls = calls;
        }
    }
}
