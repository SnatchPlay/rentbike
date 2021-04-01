using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace NP_1
{
   public class Person
    {
        
	   protected string Name;
       protected string SurName;


        public Person(string Name = "", string SurName = "") {
            this.Name = Name;
            this.SurName = SurName;
        }
        public override string ToString()
        {
            return $"{Name} {SurName}";
        }
    }
}
