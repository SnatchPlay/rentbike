using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using NP_1.RepInterface;

namespace NP_1.FileRep
{
    public class TechFileRep:FileRepository<Technic>,ITechRep
    {

            public TechFileRep(string filePath = "D:/Projects/NP_1/NP_1/TXT/Tech.txt")
            {
                base.filePath = filePath;
                ReadFromFile();
            }

            ~TechFileRep()
            {
                Writetofile();
            }

            protected override void ConvertToObject(List<string> strObjItems)
            {
                foreach (string line in strObjItems)
                {
                    string[] tmp = line.Split();

                    string Name = tmp[0];
                    string SurName = tmp[1];
                    short stag = Convert.ToInt16(tmp[2]);
                    short rate = Convert.ToInt16(tmp[3]);
                    short cr = Convert.ToInt16(tmp[4]);
                    Technic t = new Technic(Name, SurName, stag, rate,cr);
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
        public void Remove(short ind)
        {
            base.Remove(ind);
        }
    }
}
