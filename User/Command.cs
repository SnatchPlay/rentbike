using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NP_1;

namespace User
{
    public class Command
    {
        public IRepository<Technic> techRepositorty = new TechRep();
        public IRepository<Call> callRepository = new CallRep();
        public IRepository<Place> placerep = new PlaceRep();
        public IRepository<Place> difstreet = new PlaceRep();
        List<Customer> custcommand = new List<Customer>();
        public bool Avalbystr(string street)
        {//all zaynato= true
            int k = 0;
            for (int i = 0; i < placerep.Data.Count(); i++)
            {

                if ((street == placerep.Data[i].getstreet()) && ((placerep.Data[i].avall()) == true))
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
                if ((street1 == placerep.Data[i].getstreet()) && ((placerep.Data[i].avall()) == true))
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
                string tempstr = placerep.Data[i].getstreet();
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
                if (streeet == ((placerep.Data[i]).getstreet()))
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
            for (int i = 0; i < placerep.Data.Count(); i++)
            {
                if (s == (placerep.Data[i]).sr())
                {
                    placerep.Data[i].seta(false);
                }
            }
        }

        public void shownotavlbystr(string stret, int sr)
        {
            int f = 1;

            for (int i = 0; i < placerep.Data.Count(); i++)
            {
                if ((stret == ((placerep.Data[i]).getstreet())) && (((placerep.Data[i]).avall()) == false))
                {
                    if (f > 1)
                    {
                        break;
                    }
                   (placerep.Data[i]).seta(true);
                    (placerep.Data[i]).setsr(sr);
                    f++;
                }
            }
        }

        public void returnb(int ar)
        {
            for (int i = 0; i < placerep.Data.Count(); i++)
            {
                if (placerep.Data[i].sr() == ar)
                {
                    placerep.Data[i].seta(true);
                }
            }
            custcommand.RemoveAt(0);
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
                    (techRepositorty.Data[i]).setrate(newrate);

                }
            }
        }
        public void repplus(string name)
        {

            for (int i = 0; i < techRepositorty.Data.Count(); i++)
            {
                if (name == ((techRepositorty.Data[i]).getName()))
                {
                    (techRepositorty.Data[i]).setcr(((techRepositorty.Data[i]).getcr() + 1));

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
                    (callRepository.Data[i]).setcall(((callRepository.Data[i]).getcalls() + 1));

                }
            }
        }


        public void showjustaval(string street2)
        {
            for (int i = 0; i < placerep.Data.Count(); i++)
            {
                if ((street2 == placerep.Data[i].getstreet()) && ((placerep.Data[i].avall()) == true))
                {
                    placerep.Data[i].Writejustbike();

                }
            }

        }

    }
}
