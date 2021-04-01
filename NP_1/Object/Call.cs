using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP_1
{
    public class Call : Person
    {
        public int stag { get; set; }
        public int calls { get; set; }
        public Call(string Name, string SurName, int stag, int calls) : base(Name, SurName)
        {
            this.stag = stag;
            this.calls = calls;
        }
        public override string ToString()
        {
            return $"{base.ToString()} {stag} {calls}";
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
