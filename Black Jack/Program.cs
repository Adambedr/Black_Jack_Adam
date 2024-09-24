using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Xml;

namespace Black_Jack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int point = 0;
            int pointDealer = 0;
            Console.WriteLine("Hej, jag ser att du vill köra lite black jack");

            string player = Console.ReadLine();

            Console.WriteLine("vill du slå eller stanna?");
           
            while (player != "stanna")
            {
                player = Console.ReadLine();

                if (player == "slå")
                {
                    
                    Random rand = new Random();
                    int randomnumber = rand.Next(1, 7);

                    Random rand2 = new Random();
                    int randomnumber2 = rand.Next(1, 7);

                    point += randomnumber;
                    Console.WriteLine("du fick " + randomnumber + ", du har totalt " + point);
                    

                    Console.WriteLine("");

                    pointDealer += randomnumber2;
                    Console.WriteLine("Dealern fick " + randomnumber2 + " han har totalt " + pointDealer);

                    Console.WriteLine("");

                    Console.WriteLine("vill du slå eller stanna?");

                    if (pointDealer >= 22)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" dealer fick över 22, du van");
                        break;
                    }if (point >= 22)
                    {
                        Console.WriteLine();
                        Console.WriteLine("du förlorar, pga du fick över 22");
                        break;
                    } 



                } 

            }
            if (pointDealer < 22 &&  point < pointDealer)
            {
                Console.WriteLine();
                Console.WriteLine("du förlora lika till nästa gång");
            }
            else if (point > 22 && point > pointDealer)
            {
                Console.WriteLine();
                Console.WriteLine("du van, lets go, få din motståndare att ha en bra dag");
            }
            else if (point == pointDealer)
            {
                Console.WriteLine();
                Console.WriteLine("soory, du fick lika mycket, det blir lika.");
            }
            

        }
    }
}
