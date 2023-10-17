using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti čísly.
            int[] array = { 2, 5, 4, 7, 1, 9 };

            //TODO 2: Vypiš do konzole všechny prvky pole, zkus klasický for, kde i využiješ jako index v poli, a foreach (vysvětlíme si).
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            int sum = 0;
            for (int i = 0;i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("součet čísel v poli je: " + sum);

            foreach (int number in array)
            {
                Console.WriteLine("vypsano foreachem " + number);
            }

            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            float average = sum/array.Length;
            Console.WriteLine("průměr pole je: " + average);

            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i]; 
                }
                
            }
            Console.WriteLine("největší prvek pole je: " + max);


            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("nejmenší prvek pole je: " + min);

            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            int index = 0;
            Console.WriteLine("zadejte číslo, které chcete vyhledat");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == input)
                {
                    index = i;
                }
            }
            Console.WriteLine("index zadaneho cisla je: " + index);

            //TODO 8: Změň tvorbu integerového pole tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9. Vytvoř si na to proměnnou typu Random.
            Random rnd = new Random();
            int[] randomArray = new int[100];
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rnd.Next(0, 10);
                Console.Write(randomArray[i] + " ");
            }

            Console.WriteLine(" ");
            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];
            int[] array09 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int counting = 0;
            for (int i = 0; i < counts.Length; i++)
            {
                for (int j = 0; j < randomArray.Length; j++)
                {
                    if (array09[i] == randomArray[j])
                    {
                        counting++;    
                    }
                }
                counts[i] = counting;
                Console.WriteLine(counts[i]);
            }
            

            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.


            Console.ReadKey();
        }
    }
}
