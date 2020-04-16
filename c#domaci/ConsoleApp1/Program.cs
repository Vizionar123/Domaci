using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            


                double prvi, drugi, rezultat;
                string znak;
                Console.WriteLine("Unesi prvi broj:");
                prvi = double.Parse(Console.ReadLine());
                Console.WriteLine("Unesi drugi broj");
                drugi = double.Parse(Console.ReadLine());
                Console.WriteLine("Unesite odgovarajuci znak: S-za sabiranje; O-za oduzimanje; M-za mnozenje; D-za deljenje");
                znak = Console.ReadLine();
                rezultat = Izracunaj(prvi, drugi, znak);
                if (rezultat == 0) { Console.WriteLine("Niste uneli validan znak"); }
                else { Console.WriteLine("Rezultat je: {0}", rezultat); }


                Console.ReadKey();


         }


            public static double Izracunaj(double prvi, double drugi, string znak)
            {
                double pom;
                pom = 0;
                switch (znak)
                {
                    case "S":
                        pom = prvi + drugi;
                        break;
                    case "O":
                        pom = prvi - drugi;
                        break;
                    case "M":
                        pom = prvi * drugi;
                        break;
                    case "D":
                        pom = prvi / drugi;
                        break;
                    default:
                        Console.WriteLine("Nije dobar unos");
                        break;
                }
                return (pom);

            }







     }
 }
