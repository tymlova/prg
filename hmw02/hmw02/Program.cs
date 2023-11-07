using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmw02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zadejte čísla a & b (a je počet řádků, b je počet sloupců)");
          /*  int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());*/
            string strA = Console.ReadLine();
            string strB = Console.ReadLine();
            bool inputCheck = true;
            if (int.TryParse(string , out int a) = true)
            {

            }
            
            int b;
            Console.WriteLine(" ");
            Console.WriteLine("toto je vaše pole:");
            int[,] myArray = new int[a,b];
            Random rnd = new Random();
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = rnd.Next(1, a * b);
                    Console.Write(myArray[i, j]+" ");
                }
                Console.Write("\n");
            }
            Console.WriteLine(" ");
            //textwall
            Console.WriteLine("Zadejte číslo dle operace, kterou chcete udělat");
            Console.WriteLine("1 - prohazování prvků");
            Console.WriteLine("2 - prohazování řádků");
            Console.WriteLine("3 - prohazování sloupců");
            int operation = Convert.ToInt32(Console.ReadLine());

            //switch 
            switch (operation)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                
            }

            Console.ReadKey();
        }
    }
}
