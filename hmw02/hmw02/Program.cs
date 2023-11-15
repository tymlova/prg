using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zadejte čísla a & b (a je počet řádků, b je počet sloupců)");
            
            string strA = Console.ReadLine();
            string strB = Console.ReadLine();
            int a = inputControl(strA);
            int b = inputControl(strB);

            Console.WriteLine(" ");
            Console.WriteLine("toto je vaše matice:");
            int[,] myArray = new int[a, b];
            Random rnd = new Random();
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = rnd.Next(1, a * b);
                    Console.Write(myArray[i, j].ToString().PadLeft((a*b).ToString().Length +1));
                }
                Console.Write("\n");
            }
            Console.WriteLine(" ");
            //textwall
            Console.WriteLine("Zadejte číslo dle operace, kterou chcete udělat");
            Console.WriteLine("1 - prohazování prvků");
            Console.WriteLine("2 - prohazování řádků");
            Console.WriteLine("3 - prohazování sloupců");
            Console.WriteLine("4 - otáčení prvků na hlavní diagonále");
            Console.WriteLine("5 - otáčení prvků na vedlejší diagonále (pouze pro matice se stejným počtem řádků a sloupců");
            Console.WriteLine("6 - transpozice");
            Console.WriteLine("7 - násobení dvou matic");
            Console.WriteLine("8 - sčítání dvou matic");
            Console.WriteLine("9 - odčítání dvou matic");
            Console.WriteLine("10 - násobení matice (celé/řádku/sloupce)");
            

            int operation = inputControl(Console.ReadLine());

            //switch 
            switch (operation)
            {
                case 1: //prohazování prvků
                    myArray = case1(myArray);
                    writeArray(myArray, a, b);
                    break;
                case 2: //prohazování řádků
                    myArray = case2(myArray);
                    writeArray(myArray, a, b);
                    break;
                case 3: //prohazování sloupců
                    myArray = case3(myArray);
                    writeArray(myArray, a, b);
                    break;
                case 4: //otáčení prvků na hlavní diagonále
                    myArray = case4(myArray, a, b);
                    writeArray(myArray, a, b);
                    break;
                case 5: //otáčení prvků na vedlejší diagonále
                    while (true)
                    {
                        if (a == b)
                        {
                            myArray = case5(myArray);
                            writeArray(myArray, a, b);
                            break;
                        }

                        else
                        {
                            Console.WriteLine("matice musí mít stejný počet řádků a sloupců");
                            a = inputControl(Console.ReadLine());
                            b = inputControl(Console.ReadLine());
                            myArray =  new int[a, b];
                            Console.WriteLine("souměrná matice:");
                            for (int i = 0; i < myArray.GetLength(0); i++)
                            {
                                for (int j = 0; j < myArray.GetLength(1); j++)
                                {
                                    myArray[i, j] = rnd.Next(1, a * b);
                                    Console.Write(myArray[i, j] + " ");
                                }
                                Console.Write("\n");
                            }
                            Console.WriteLine(" ");
                        }
                    }
                    break;
                case 6: //transpozice
                    for (int i = 0; i < myArray.GetLength(1); i++)
                    {
                        for (int j = 0; j < myArray.GetLength(0); j++)
                        {
                            Console.Write(myArray[j, i] + " ");
                        }
                        Console.Write("\n");
                    }
                    break;
                case 7: //násobení dvou matic
                    myArray = case7(myArray, rnd, a,b);
                    writeArray(myArray, Math.Pow(Convert.ToDouble(a), Convert.ToDouble(2)), Math.Pow(Convert.ToDouble(a), Convert.ToDouble(2));
                    break;
                case 8:
                    myArray = case8(myArray, a, b, rnd);
                    Console.WriteLine("sečtené matice:");
                    writeArray(myArray, a, b);
                    break;
                case 9:
                    myArray = case9(myArray, a, b, rnd);
                    Console.WriteLine("odečtené matice");
                    writeArray(myArray, a, b);
                    break;
                case 10:
                    myArray = case10(myArray);
                    writeArray(myArray, a, b);
                    break;
            }

            Console.ReadKey();
        }
        public static int inputControl(string str) //kontrola vstupů
        {
            while (true)
            {
                if (int.TryParse(str, out int a))
                {
                    return a;
                }
                else
                {
                    Console.WriteLine("zadejte číslo");
                    str = Console.ReadLine();
                }
            }
        }

        public static int iControl(int[,] myArray)
        {
            int x = inputControl(Console.ReadLine());
            while (true)
            {
                if (x < myArray.GetLength(0))
                {
                    return x;
                }
                else
                {
                    Console.WriteLine("zadejte souřadnici čísla dané matice");
                    x = inputControl(Console.ReadLine());
                }
            }
            
        }

        public static int jControl(int[,] myArray)
        {
            int x = inputControl(Console.ReadLine());
            while (true)
            {
                if (x < myArray.GetLength(1))
                {
                    return x;
                }
                else
                {
                    Console.WriteLine("zadejte souřadnici čísla dané matice");
                    x = inputControl(Console.ReadLine());
                }
            }
        }

        public static void writeArray(int[,] myArray, int a, int b)
        {
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j].ToString().PadLeft((a*b).ToString().Length + 1));
                }
                Console.Write("\n");
            }
        }
        public static int[,] case1(int[,] myArray) //první je číslo řádku (i)
        {
            Console.WriteLine("zadejte souřadnice prvního prvku"); //TODO: KOTROLA ROZSAHU
            int xFirst = iControl(myArray);
            int yFirst = jControl(myArray);
            Console.WriteLine("zadejte souřadnice druhého prvku");
            int xSecond = iControl(myArray);
            int ySecond = jControl(myArray);
            int temporary = myArray[xFirst, yFirst];
            myArray[xFirst, yFirst] = myArray[xSecond, ySecond];
            myArray[xSecond, ySecond] = temporary;
            return myArray;
        }

        public static int[,] case2(int[,] myArray)
        {
            Console.WriteLine("zadejte souřadnici prvního prohazovaného sloupce");
            int n = jControl(myArray);
            Console.WriteLine("zadejte souřadnici druhého prohazovaného sloupce");
            int m = jControl(myArray);
            int[] tempArray = new int[myArray.GetLength(0)];
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                tempArray[i] = myArray[i, n];
            }
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                myArray[i, n] = myArray[i, m];
            }
            for (int i = 0; i < myArray.GetLength(1); i++)
            {
                myArray[i, m] = tempArray[i];
            }
            return myArray;
        }

       public static int[,] case3(int[,] myArray)
        {
            Console.WriteLine("zadejte souřadnici prvního prohazovaného sloupce");
            int n = iControl(myArray);
            Console.WriteLine("zadejte souřadnici druhého prohazovaného sloupce");
            int m = iControl(myArray);
            int[] tempArray = new int[myArray.GetLength(0)];
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                tempArray[j] = myArray[j, n];
            }
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                myArray[j, n] = myArray[j, m];
            }
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                myArray[j, m] = tempArray[j];
            }
            return myArray;
        }

        public static int[,] case4(int[,] myArray, int a, int b)
        {
            if (a > b)
            {
                for (int i = 0; i <= b / 2; i++)
                {
                    int temp = myArray[i, i];
                    myArray[i, i] = myArray[myArray.GetLength(0) - i - 1, myArray.GetLength(0) - i - 1];
                    myArray[myArray.GetLength(0) - i - 1, myArray.GetLength(0) - i - 1] = temp;
                }
            }
            else
            {
                for (int i = 0; i <= a / 2; i++)
                {
                    int temp = myArray[i, i];
                    myArray[i, i] = myArray[myArray.GetLength(0) - i - 1, myArray.GetLength(0) - i - 1];
                    myArray[myArray.GetLength(0) - i - 1, myArray.GetLength(0) - i - 1] = temp;
                }
            }
            return myArray;
        }

        public static int[,] case5(int[,] myArray)
        {
            for (int i = 0; i < myArray.GetLength(0) / 2; i++)
            {

                int temp = myArray[i, myArray.GetLength(0) - 1 - i];
                myArray[i, myArray.GetLength(0) - 1 - i] = myArray[myArray.GetLength(0) - 1 - i, i];
                myArray[myArray.GetLength(0) - 1 - i, i] = temp;
            }
            return myArray;
        }

        public static int[,] case7(int[,] myArray, Random rnd, int a, int b) //TODO: NÁSOBENÍ MATIC
        {
            Console.WriteLine("zadejte dimenze matice kterou budete násobit");
            Console.WriteLine("první dimenze musí být rovna druhé dimenzi první matice, což je " + b);
            int x = inputControl(Console.ReadLine());
            int y = inputControl(Console.ReadLine());
            while (x != b)//poočet sloupců první matice se musí rovnat počtu řádků druhé matice
            {
                Console.WriteLine("nauč se číst/psát");
                x = inputControl(Console.ReadLine());
            }
            int[,] myArray2 = new int[x, y];
            int[,] result = new int[a, y];
            Console.WriteLine("toto je matice, kterou budete násobit:");
            for (int i = 0; i < myArray2.GetLength(0); i++)
            {
                for (int j = 0; j < myArray2.GetLength(1); j++)
                {
                    myArray2[i, j] = rnd.Next(1, x * y);
                    Console.Write(myArray2[i, j].ToString().PadLeft((a * b).ToString().Length + 1));
                }
                Console.Write("\n");
            }
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray2.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(1); k++)
                    {
                        result[i, j] += myArray[i, k] * myArray2[k, j];
                    }
                    
                }
            }
            
            return result;
        }

        public static int[,] case8(int[,] myArray, int a, int b, Random rnd)
        {
            int[,] myArray2 = new int[a, b];
            Console.WriteLine("druhá matice");
            for (int i = 0; i < myArray2.GetLength(0); i++)
            {
                for (int j = 0; j < myArray2.GetLength(1); j++)
                {
                    myArray2[i, j] = rnd.Next(1, a * b);
                    Console.Write(myArray2[i, j] + " ");
                }
                Console.Write("\n");
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] += myArray2[i, j];
                    
                }
            }
            return myArray;
        }

        public static int[,] case9(int[,] myArray, int a, int b, Random rnd)
        {
            int[,] myArray2 = new int[a, b];
            Console.WriteLine("druhá matice");
            for (int i = 0; i < myArray2.GetLength(0); i++)
            {
                for (int j = 0; j < myArray2.GetLength(1); j++)
                {
                    myArray2[i, j] = rnd.Next(1, a * b);
                    Console.Write(myArray2[i, j] + " ");
                }
                Console.Write("\n");
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] -= myArray2[i, j];

                }
            }
            return myArray;
        }

        public static int[,] case10(int[,] myArray)
        {
            Console.WriteLine("co chcete násobit?");
            Console.WriteLine("1 - celou matici");
            Console.WriteLine("2 - daný řádek");
            Console.WriteLine("3 - daný sloupec");
            int operation = inputControl(Console.ReadLine());
            Console.WriteLine("čím budete násobit?");
            int number = inputControl(Console.ReadLine());
            switch(operation)
            {
                case 1:
                    for (int i = 0; i < myArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < myArray.GetLength(1); j++)
                        {
                            myArray[i, j] = myArray[i, j] * number;
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("zadejte číslo řádku který chcete vynásobit");
                    int row = iControl(myArray);
                    for (int j = 0; j < myArray.GetLength(1); j++)
                    {
                        myArray[row, j] = myArray[row, j] * number;
                    }
                    break;
                case 3:
                    Console.WriteLine("zadejte číslo řádku který chcete vynásobit");
                    int column = jControl(myArray);
                    for (int i = 0; i < myArray.GetLength(0); i++)
                    {
                        myArray[i, column] = myArray[i, column] * number;
                    }
                    break;
            }
            return myArray;
        }
    }
}
