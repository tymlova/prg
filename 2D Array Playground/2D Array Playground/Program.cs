using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace _2D_Array_Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové 2D pole velikosti 5 x 5, naplň ho čísly od 1 do 25 a vypiš ho do konzole (5 řádků po 5 číslech).
            int[,] my2DArray = new int[5,5];
            int numberToAdd = 1;
            for (int i = 0; i < my2DArray.GetLength(0); i++) //i je index řádku //0 je první dimenze
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++) //j je index sloupce //1 je druhá dimenze
                {
                    my2DArray[i, j] = numberToAdd;
                    numberToAdd++;
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            //TODO 2: Vypiš do konzole n-tý řádek pole, kde n určuje proměnná nRow.
            int nRow = 3;
            for (int j = 0; j < my2DArray.GetLength(1); j++)
            {
                Console.Write(my2DArray[nRow, j] + " ");
            }
            Console.Write("\n");
            Console.Write("\n");


            //TODO 3: Vypiš do konzole n-tý sloupec pole, kde n určuje proměnná nColumn.
            int nColumn = 0;
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                Console.Write(my2DArray[i, nColumn] + " ");
            }
            Console.Write("\n");
            Console.Write("\n");

            //BONUS TODO: vypsat prvky hlavní diagonály
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                 Console.Write(my2DArray[i, i] + " ");
            }
            Console.Write("\n");
            Console.Write("\n");
            //prvky vedlejší diagonály
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    if (i + j == 4)
                    {
                        Console.Write(my2DArray[i, j] + " ");
                    }
                }
            }
            Console.Write("\n");
            Console.Write("\n");

            //TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
            //Nápověda: Budeš potřebovat proměnnou navíc, do které si uložíš první z prvků před tím, než ho přepíšeš druhým, abys hodnotou prvního prvku potom mohl přepsat druhý
            int xFirst = 0;
            int yFirst = 0;
            int xSecond = 3;
            int ySecond = 1;
            //int first = my2DArray[xFirst, yFirst];
            //int second = my2DArray[xSecond, ySecond];
            int temporary = my2DArray[xFirst, yFirst];
            my2DArray[xFirst, yFirst] = my2DArray[xSecond, ySecond];
            my2DArray[xSecond, ySecond] = temporary;
            for (int i = 0; i < my2DArray.GetLength(0); i++) //i je index řádku //0 je první dimenze
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++) //j je index sloupce //1 je druhá dimenze
                {
                    
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }

            Console.Write("\n");
            Console.Write("\n");

            //TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
            int nRowSwap = 0;
            int mRowSwap = 1;
            int[] tempArray = new int[my2DArray.GetLength(0)];
            for (int j = 0; j < my2DArray.GetLength(1); j++)
            {
                tempArray[j] = my2DArray[nRowSwap, j];
            }
            for (int j = 0; j < my2DArray.GetLength(1); j++)
            {
                my2DArray[nRowSwap, j] = my2DArray[mRowSwap, j];
            }
            for (int j = 0; j < my2DArray.GetLength(1); j++)
            {
                my2DArray[mRowSwap, j] = tempArray[j];
            }
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[i,j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.Write("\n");

            //TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.
            int nColSwap = 0;
            int mColSwap = 1;
            int[] tempArray2 = new int[my2DArray.GetLength(0)];
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                tempArray2[i] = my2DArray[i, nColSwap];
            }
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                my2DArray[i, nColSwap] = my2DArray[i, mColSwap];
            }
            for (int i = 0;i < my2DArray.GetLength(1); i++)
            {
                my2DArray[i, mColSwap] = tempArray2[i];
            }
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.Write("\n");
            //TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.
            
            int[] mainDiagonal = new int[5];
            
            for (int i = 0; i < 5; i++)
            {
                mainDiagonal[i] = my2DArray[i, i]; 
            }
            for (int i = 0; i < mainDiagonal.Length; i++)
            {
                Console.Write(mainDiagonal[i] + " ");
            }
            Console.Write("\n");
            Console.Write("\n");

            for (int i = 0; i <= my2DArray.GetLength(0)/2; i++)
            {
                int temp = my2DArray[i,i];
                my2DArray[i,i ] = my2DArray[my2DArray.GetLength(0) - i -1, my2DArray.GetLength(0) - i-1];
                my2DArray[my2DArray.GetLength(0) - i - 1, my2DArray.GetLength(0) - i - 1] = temp;
            }

            /*for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                temp = my2DArray[i, i];
            }
            for (int j = 4; j > -1; j--)
            {
                my2DArray[j, j] = temp;
            }*/
            
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.Write("\n");

            //TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.
            for (int i = 4; i >= my2DArray.GetLength(0)/2; i--)
            {
               
                 int temp = my2DArray[i, my2DArray.GetLength(0) - 1- i];
                 my2DArray[i, my2DArray.GetLength(0) - 1-i] = my2DArray[my2DArray.GetLength(0) - 1 - i, i];
                 my2DArray[my2DArray.GetLength(0) - 1 - i, i] = temp;       
                 
            }
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.Write("\n");
            Console.ReadKey();
        }
    }
}
