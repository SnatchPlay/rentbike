using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NP_1.RepInterface;
using NP_1;
using NP_1.FileRep;
using NP_1.Factories;
using System.Configuration;
using System.IO;

namespace User
{
    public class Command
    {
        public ICallRep callRepository = FactoryProvider.GetFactory().GetCallRep();
        public ITechRep techRepositorty = FactoryProvider.GetFactory().GetTechRep();
        public IPlaceRep placerep = FactoryProvider.GetFactory().GetPlaceRep();

        //public IRepository<Place> difstreet = new PlaceRep();
        List<Customer> custcommand = new List<Customer>();
        public bool Avalbystr(string street)
        {//all zaynato= true
            int k = 0;
            for (int i = 0; i < placerep.Data.Count(); i++)
            {

                if ((street == placerep.Data[i].street) && ((placerep.Data[i].available) == true))
                {
                    k++;

                }


                if (3 == k)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public bool avalsom(string street1)
        {
            for (int i = 0; i < placerep.Data.Count(); i++)
            {
                if ((street1 == placerep.Data[i].street) && ((placerep.Data[i].available) == true))
                {
                    return true;//ye bike
                }

            }

            return false;
        }

        public void streets()
        {
            List<string> difstreet = new List<string>();

            for (int i = 0; i < placerep.Data.Count(); i++)
            {
                string tempstr = placerep.Data[i].street;
                if (difstreet.Contains(tempstr)) { continue; }
                else
                {
                    difstreet.Add(tempstr);
                }
            }

            difstreet.Sort();
            for (int k = 0; k < difstreet.Count(); k++)
            {
                Console.WriteLine(difstreet[k]);
            }
        }

        public void showbystreet(string streeet)
        {
            for (int i = 0; i < placerep.Data.Count(); i++)
            {
                if (streeet == ((placerep.Data[i]).street))
                {

                    (placerep.Data[i]).Writejustbike();
                }
                else
                {
                    continue;
                }
            }
        }
        public void rent(int s)
        {
            string filePath = "D:/Projects/NP_1/NP_1/TXT/cus.txt";
            string newline;
            var factoryType = ConfigurationManager.AppSettings["factoryType"];
            StreamWriter sw = new StreamWriter(filePath, true);
            for (int i = 0; i < placerep.Data.Count(); i++)
            {
                if (s == (placerep.Data[i]).serialnumb)
                {
                    placerep.Data[i].available=false;
                }
            }
            if (factoryType == "file")
            {
                newline = s + " " + custcommand[custcommand.Count() - 1].ToString();
                
                sw.WriteLine(newline);
                sw.Close();

            };
        }

        public void shownotavlbystr(string stret, int sr)
        {
            int f = 1;

            for (int i = 0; i < placerep.Data.Count(); i++)
            {
                if ((stret == ((placerep.Data[i]).street)) && (((placerep.Data[i]).available) == false))
                {
                    if (f > 1)
                    {
                        break;
                    }
                   (placerep.Data[i]).available=true;
                    (placerep.Data[i]).serialnumb=sr;
                    f++;
                }
            }
        }

        public void returnb(int ar)
        {
            string filePath = "D:/Projects/NP_1/NP_1/TXT/cus.txt";
            string line, newline;
            List<int> srn = new  List<int>();
            List<string> filelines = new List<string>();
            for (int i = 0; i < placerep.Data.Count(); i++)
            {
                if (placerep.Data[i].serialnumb == ar)
                {
                    placerep.Data[i].available=true;
                }
            }
            
            var factoryType = ConfigurationManager.AppSettings["factoryType"];
            
            
            if (factoryType == "file")
            {
                StreamReader sr = new StreamReader(filePath);
                while ((line = sr.ReadLine()) != null)
                {
                    filelines.Add(line);
                }
                sr.Close();
                custcommand.Clear();
                foreach (string line1 in filelines)
                {
                    string[] tmp = line1.Split();
                    int sern = Convert.ToInt32(tmp[0]);
                    string Name = tmp[1];
                    string SurName = tmp[2];
                    int number = Convert.ToInt32(tmp[3]);
                    Customer cs = new Customer(Name, SurName, number);
                    custcommand.Add(cs);
                    srn.Add(sern);
                }
                for (int i = 0; i < custcommand.Count(); i++)
                {
                    if (srn[i] == ar)
                    {
                        custcommand.RemoveAt(i);
                        srn.RemoveAt(i);
                    }
                }
                StreamWriter sw = new StreamWriter(filePath, false);
                for (int l = 0; l < custcommand.Count(); l++)
                {
                    newline = srn[l] + " " + custcommand[l].ToString();
                    sw.WriteLine(newline);
                    
                }
                sw.Close();

            }
            else {
                custcommand.RemoveAt(0);
            };
        }
        public void readcust()
        {
            
            Customer css;
            string name, surname; int phone;
            Console.WriteLine("Please type info about you:\n");
            Console.WriteLine("Name:"); name = Console.ReadLine();
            Console.WriteLine("Surname:"); surname = Console.ReadLine();
            Console.WriteLine("Phone:"); phone = Convert.ToInt32(Console.ReadLine());
            css = new Customer(name, surname, phone);
            custcommand.Add(css);


        }
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        public void setratetech(string name, int newrate)
        {
            for (int i = 0; i < techRepositorty.Data.Count(); i++)
            {
                if (name == ((techRepositorty.Data[i]).getName()))
                {
                    (techRepositorty.Data[i]).rate=newrate;

                }
            }
        }
        public void repplus(string name)
        {

            for (int i = 0; i < techRepositorty.Data.Count(); i++)
            {
                if (name == ((techRepositorty.Data[i]).getName()))
                {
                    (techRepositorty.Data[i]).cr=(((techRepositorty.Data[i]).cr + 1));

                }
            }
        }
        public void showtech()
        {
            for (int i = 0; i < techRepositorty.Data.Count(); i++)
            {
                (techRepositorty.Data[i]).ToString();

            }
        }
        //////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        public void showcaller()
        {
            for (int i = 0; i < callRepository.Data.Count(); i++)
            {
                (callRepository.Data[i]).ToString();

            }
        }

        public void callplus(string name)
        {
            for (int i = 0; i < callRepository.Data.Count(); i++)
            {
                if (name == ((callRepository.Data[i]).getName()))
                {
                    (callRepository.Data[i]).calls=(((callRepository.Data[i]).calls + 1));

                }
            }
        }


        public string showjustaval(string street2,int i)
        {
            string str = "";
            
                if (( placerep.Data[i].street==street2 ) && ((placerep.Data[i].available) == true))
                {
                    str=placerep.Data[i].Writejustbike();

                }
            return str;

        }

    }
}
