using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP_1
{
    public class Place
    {
        public string street { get; }
        public int count { get; }
        public int serialnumb { get; set; }
        public int price { get; }
        public bool available { get; set; }
        public Place(string street, int count=3, int serialnumb=0, int price=50, bool available=true)
        {
            this.street = street;
            this.count = count;
            this.serialnumb = serialnumb;
            this.price = price;
            this.available = available;
        }
        public override string ToString()
        {
            return $"{street} {serialnumb} {price} {available}";
        }

        public string Writejustbike()
        {
            return $"Bicycle info:{serialnumb} {price}$ {available}\n";
        }
        public string Write()
        {
            return $"Street:{street}\n  Bicycle info:{serialnumb} {price}$ {available}\n";


        }
        //void showaval()
        //{
        //    if (available == true)
        //    {
        //        return Writejustbike();
        //    }
        //}
    }
}
