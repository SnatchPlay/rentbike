using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NP_1.RepInterface;

namespace NP_1.FileRep
{
    class PlaceFileRep:FileRepository<Place>,IPlaceRep
    {
        public PlaceFileRep(string filePath = "D:/Projects/NP_1/NP_1/TXT/str1.txt")
        {
            base.filePath = filePath;
            ReadFromFile();
        }

        ~PlaceFileRep()
        {
            Writetofile();
        }

        protected override void ConvertToObject(List<string> strObjItems)
        {
            foreach (string line in strObjItems)
            {
                string[] tmp = line.Split();
                bool avall=false;
                string street = tmp[0];
                short serialnumber = Convert.ToInt16(tmp[1]);
                short price = Convert.ToInt16(tmp[2]);

                if (tmp[3] == "True")
                {
                    avall = true;
                }
                
                //bool avall = Convert.ToBoolean(tmp[3]);
                Place t = new Place(street,3,serialnumber,price,avall);
                base.Add(t);
            }
        }

        protected override void WriteObj(StreamWriter sw)
        {
            for (int i = 0; i < Data.Count; i++)
            {
                sw.WriteLine(Data[i].ToString());
            }
            sw.Close();
        }
    }
}
