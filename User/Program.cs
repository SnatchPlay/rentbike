using NP_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
			Command com=new Command(); int sr;
			string street;
			while (true)
			{
				Console.WriteLine("         LET'S GO!         \n");
				Console.WriteLine("Choose option:\n");
				Console.WriteLine("1.Rent a bike\n");
				Console.WriteLine("2.Return the bicycle\n");
				Console.WriteLine("3.Call a technic\n" );
				Console.WriteLine("4.Exit\n" );
				char user;
				user = Convert.ToChar(Console.ReadLine());
				if (user == '1')
				{
					com.readcust();

                    Console.WriteLine("Our points:\n");
					com.streets();
					Console.WriteLine("Choose a street:"); street=Console.ReadLine();
					if (com.avalsom(street) == false)
					{
						Console.WriteLine("Choose another street.\n");
					}
					else
					{
						com.showjustaval(street);
						Console.WriteLine("Choose the bike.\n");
						Console.WriteLine("Type serial number:\n"); sr=Convert.ToInt32(Console.ReadLine());
						com.rent(sr);
					}
				}

				else if (user == '2')
				{
					Console.WriteLine("Where do you want to leave your bike?\n");
					Console.WriteLine("Our points:\n");
					com.streets();
					Console.WriteLine("Choose a street:\n");street=Console.ReadLine();

					if (com.Avalbystr(street) == true)
					{
						Console.WriteLine("Choose another street.");
					}
					else
					{
						Console.WriteLine("Please type serial number:"); sr = Convert.ToInt32(Console.ReadLine());
						com.shownotavlbystr(street, sr);
						com.returnb(sr);


					}
				}
				
				else if (user == '3')
				{
					string tech;int nr;
					Console.WriteLine("Choose a tech and type a name.\n");
					com.showtech();
					tech = Console.ReadLine();
					Console.WriteLine("Wait for a tech.\n");
					Console.WriteLine("Available option:\n 1.Set a rating\n2.Make a report\n3.Main menu\n");
					user = Convert.ToChar(Console.ReadLine());
					while (true)
					{
						if (user == '1')
						{
							Console.WriteLine("Type a new rating:\n");nr=Convert.ToInt32(Console.ReadLine());
							com.setratetech(tech, nr);
							break;
						}
						else if (user == '2')
						{
							Console.WriteLine("Thank you for a report\n");
							com.repplus(tech);
							break;
						}
						else
						{
							Console.WriteLine("Wow.\n");
							break;
						}
					}
				}
				else
				{
					break;
				}

				}
			}
		}
    }

