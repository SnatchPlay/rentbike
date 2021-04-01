using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NP_1;


namespace Admin
{
    class Program
    {
        static void Main(string[] args)
        {
			Command com = new Command();
			while (true)
			{
				Console.WriteLine ("         Welcome to admin menu.         \n");
				Console.WriteLine("Choose option:\n") ;
				Console.WriteLine("1.Add tech\n") ;
				Console.WriteLine("2.Add caller\n") ;
				Console.WriteLine("3.Add street\n") ;
				Console.WriteLine("4.Show all call\n");
				Console.WriteLine("5.Show all tech\n");
				Console.WriteLine("6.Show all points\n");
				Console.WriteLine("7.Delete technic\n");
				Console.WriteLine("8.Exit\n") ;
				char user;
				user = Convert.ToChar(Console.ReadLine());
				if (user == '1')
				{
					Console.WriteLine("Type name:");
					string name = Console.ReadLine();
					Console.WriteLine("Type surname:");
					string surname = Console.ReadLine();
					com.AddTech(name,surname);
				}

				else if (user == '2')
				{
					Console.WriteLine("Type name:");
					string name = Console.ReadLine();
					Console.WriteLine("Type surname:");
					string surname = Console.ReadLine();
					Console.WriteLine("Type count of stag:");
					int stag = Convert.ToInt16(Console.ReadLine());
					com.AddCall(name,surname,stag);
				}
				else if (user == '3')
				{
					Console.WriteLine("Type street:");
					string street = Console.ReadLine();
					com.AddPoint(street);
					
				}
				else if (user == '4')
                {
					for (int i = 0; i < com.callRepository.Data.Count(); i++)
					{
						Console.Write(com.AllCall(i));
					}
                }
				else if (user == '5')
                {
					for (int i = 0; i < com.techRepository.Data.Count(); i++)
					{
						Console.Write(com.AllTech(i));
					}
                }
				else if (user == '6')
                {
					for (int i = 0; i < com.placeRepository.Data.Count(); i++)
					{
						Console.Write(com.AllPoints(i));
					}
                }
				else if (user == '7')
				{
					for (int i = 0; i < com.techRepository.Data.Count(); i++)
					{
						Console.Write(i+" "+com.AllTech(i));
					}
					Console.WriteLine("Position of tech:");
					com.DeleteTech(Convert.ToInt16( Console.ReadLine()));
				}

				else
				{
					break;
				}

				}
			}
    }
}
