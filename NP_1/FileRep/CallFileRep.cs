using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NP_1.RepInterface;

namespace NP_1.FileRep
{
    public class CallFileRep:FileRepository<Call>,ICallRep
    {
        public CallFileRep(string filePath = "D:/Projects/NP_1/NP_1/TXT/call.txt")
        {
            base.filePath = filePath;
          ReadFromFile();
        }

        ~CallFileRep()
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
                short calls = Convert.ToInt16(tmp[3]);
                Call t = new Call(Name,SurName,stag,calls);
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
