using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP_1
{
    public class Place
    {
        private string street;
        private int count;
        private int serialnumb;
        private int price;
        private bool available;
        public Place(string street, int count=3, int serialnumb=0, int price=50, bool available=true)
        {
            this.street = street;
            this.count = count;
            this.serialnumb = serialnumb;
            this.price = price;
            this.available = available;
        }
        public string getstreet()
        {
            return street;
        }
        public string Writejustbike()
        {
            return $"Bicycle info:{serialnumb} {price}$ {available}\n";
        }
        public string Write()
        {
            return $"Street:{street}\n Count of avalaible:{count} \n Bicycle info:{serialnumb} {price}$ {available}\n";


        }
        //void showaval()
        //{
        //    if (available == true)
        //    {
        //        return Writejustbike();
        //    }
        //}
        public bool avall()
        {
            return available;
        }
        public int pri()
        {
            return price;
        }
        public int sr()
        {
            return serialnumb;
        }
        public void seta(bool a)
        {
            this.available = a;
        }
        public void setsr(int a)
        {
            this.serialnumb = a;
        }
        public int getcount()
        {
            return count;
        }
    }
}
