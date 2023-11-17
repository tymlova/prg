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
            Console.WriteLine("zadejte číslo a (počet řádků)");
            int a = inputControl(Console.ReadLine());
            Console.WriteLine("zadejte číslo b (počet sloupců)");
            int b = inputControl(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("toto je vaše matice:");
            int[,] myArray = new int[a, b];
            Random rnd = new Random();
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = rnd.Next(1, a * b);
                    Console.Write(myArray[i, j].ToString().PadLeft((a*b).ToString().Length +1)); //pomoc interneru, link dodam
                }
                Console.Write("\n");
            }
            Console.WriteLine(" ");

            int operation = ChooseOperation();
            

            //switch - dle zadane operace zavola danou fci
          while(true)
          { 
            switch (operation)
            {
                case 1: //prohazování prvků
                    myArray = ElementSwitch(myArray);
                    writeArray(myArray, a, b);
                    operation = ChooseOperation();
                    break;
                case 2: //prohazování řádků
                    myArray = RowSwitch(myArray);
                    writeArray(myArray, a, b);
                    operation = ChooseOperation();
                    break;
                case 3: //prohazování sloupců
                    myArray = ColumnSwitch(myArray);
                    writeArray(myArray, a, b);
                    operation = ChooseOperation();
                    break;
                case 4: //otáčení prvků na hlavní diagonále
                    myArray = MainDiagElSwitch(myArray, a, b);
                    writeArray(myArray, a, b);
                    operation = ChooseOperation();
                    break;
                case 5: //otáčení prvků na vedlejší diagonále - pro a == b
                    while (true)
                    {
                        if (a == b)
                        {
                            myArray = SecDiagElSwitch(myArray);
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
                    operation = ChooseOperation();
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
                    operation = ChooseOperation();
                    break;
                case 7: //násobení dvou matic
                    myArray = MultiplicationOf2Arr(myArray, rnd, a,b);
                    writeArray(myArray,a,b);
                    operation = ChooseOperation();
                    break;
                case 8://sčítání matic
                    myArray = Addition(myArray, a, b, rnd);
                    Console.WriteLine("sečtené matice:");
                    writeArray(myArray, a, b);
                    operation = ChooseOperation();
                    break;
                case 9: //odčítání matic
                    myArray = Subtraction(myArray, a, b, rnd);
                    Console.WriteLine("odečtené matice");
                    writeArray(myArray, a, b);
                    operation = ChooseOperation();
                    break;
                case 10: //násobení matice (celé/řádku/sloupce)
                    myArray = MultiplicationNormal(myArray);
                    writeArray(myArray, a, b);
                    operation = ChooseOperation();
                    break;
                case 11:
                    Environment.Exit(0);
                    break;
            }
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

        public static int iControl(int[,] myArray) //kontrola zadávání počtu řádků (case1,2)
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

        public static int jControl(int[,] myArray) //kontrola počtu sloupců (case 1, 3)
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

        public static void writeArray(int[,] myArray, int a, int b) //vypsání matice
        {
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j].ToString().PadLeft((a*b).ToString().Length + 1)); //vypsání s mezerami a zarovnáním - výpomoc internetu, link ještě dodám
                }
                Console.Write("\n");
            }
        }

        public static int ChooseOperation()
        {
            Console.WriteLine(" ");
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
            Console.WriteLine("11 - ukončit program");
            int operation = inputControl(Console.ReadLine());
            return operation;
        }

        public static int[,] ElementSwitch(int[,] myArray) //prohazování prvků
        {
            Console.WriteLine("zadejte souřadnici řádku prvního prohazovaného prvku"); 
            int xFirst = iControl(myArray);
            Console.WriteLine("zadejte souřadnici sloupce prvního prohazovanéhodruhého prvku");
            int yFirst = jControl(myArray);
            Console.WriteLine("zadejte souřadnici řádku druhého prohazovaného prvku");
            int xSecond = iControl(myArray);
            Console.WriteLine("zadejte souřadnici sloupce druhého prohazovaného prvku");
            int ySecond = jControl(myArray);
            int temporary = myArray[xFirst, yFirst];
            myArray[xFirst, yFirst] = myArray[xSecond, ySecond];
            myArray[xSecond, ySecond] = temporary;
            return myArray;
        }

        public static int[,] RowSwitch(int[,] myArray) //prohazování řádků
        {
            
            Console.WriteLine("zadejte číslo prvního prohazovaného řádku (0 - " + (myArray.GetLength(0) - 1));
            int n = iControl(myArray);
            Console.WriteLine("zadejte číslo prvního prohazovaného řádku (0 - " + (myArray.GetLength(0) - 1));
            int m = iControl(myArray);
            int[] tempArray = new int[myArray.GetLength(0)];
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                tempArray[j] = myArray[n, j];
            }
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                myArray[n, j] = myArray[m, j];
            }
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                myArray[m, j] = tempArray[j];
            }
            return myArray;
        }

       public static int[,] ColumnSwitch(int[,] myArray) //prohazování sloupců
        {
            Console.WriteLine("zadejte číslo prvního prohazovaného sloupce (0 - " + (myArray.GetLength(1)-1));
            int n = jControl(myArray);
            Console.WriteLine("zadejte číslo druhého prohazovaného sloupce (0 - " + (myArray.GetLength(1)-1));
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

        public static int[,] MainDiagElSwitch(int[,] myArray, int a, int b) //otáčení prvků na hlavní diagonále
        {
            if (a > b) //rozdeleni na pripady - matice je vertikalni nebo horizontalni (+ a==b)
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

        public static int[,] SecDiagElSwitch(int[,] myArray) //otáčení prvků na vedlejší diagonále - pro a == b
        {
            for (int i = 0; i < myArray.GetLength(0) / 2; i++)
            {

                int temp = myArray[i, myArray.GetLength(0) - 1 - i];
                myArray[i, myArray.GetLength(0) - 1 - i] = myArray[myArray.GetLength(0) - 1 - i, i];
                myArray[myArray.GetLength(0) - 1 - i, i] = temp;
            }
            return myArray;
        }

        public static int[,] MultiplicationOf2Arr(int[,] myArray, Random rnd, int a, int b) //nasobeni matic
        {
            Console.WriteLine("zadejte první dimenzi matice, kterou budete násobit (musí být rovna druhé dimenzi první matice, což je " + b +")");
            int x = inputControl(Console.ReadLine());
            Console.WriteLine("zadejte druhou dimenzi matice, kterou budete násobit");
            int y = inputControl(Console.ReadLine());
            while (x != b)//poočet sloupců první matice se musí rovnat počtu řádků druhé matice
            {
                Console.WriteLine("nauč se číst/psát (zadej správné číslo ("+ b +"))");
                x = inputControl(Console.ReadLine());
            }
            int[,] myArray2 = new int[x, y];
            int[,] result = new int[a, y];
            Console.WriteLine("toto je matice, kterou budete násobit:");
            for (int i = 0; i < myArray2.GetLength(0); i++) //matice kterou nasobim
            {
                for (int j = 0; j < myArray2.GetLength(1); j++)
                {
                    myArray2[i, j] = rnd.Next(1, x * y);
                    Console.Write(myArray2[i, j].ToString().PadLeft((a * b).ToString().Length + 1));
                }
                Console.Write("\n");
            }
            for (int i = 0; i < myArray.GetLength(0); i++) //nasobeni
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

        public static int[,] Addition(int[,] myArray, int a, int b, Random rnd) //scitani dvou matic (stejny rozmer)
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

        public static int[,] Subtraction(int[,] myArray, int a, int b, Random rnd) //odcitani dvou matic (stejny rozmer)
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

        public static int[,] MultiplicationNormal(int[,] myArray) //nasobeni matice (cele, radku, sloupce)
        {
            Console.WriteLine("co chcete násobit?");
            Console.WriteLine("1 - celou matici");
            Console.WriteLine("2 - daný řádek");
            Console.WriteLine("3 - daný sloupec");
            int operation = inputControl(Console.ReadLine());
            Console.WriteLine("čím budete násobit?");
            int number = inputControl(Console.ReadLine()); //cinitel
            switch(operation)
            {
                case 1: //cela
                    for (int i = 0; i < myArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < myArray.GetLength(1); j++)
                        {
                            myArray[i, j] = myArray[i, j] * number;
                        }
                    }
                    break;
                case 2: //radek
                    Console.WriteLine("zadejte číslo řádku který chcete vynásobit");
                    int row = iControl(myArray);
                    for (int j = 0; j < myArray.GetLength(1); j++)
                    {
                        myArray[row, j] = myArray[row, j] * number;
                    }
                    break;
                case 3: //sloupec
                    Console.WriteLine("zadejte číslo sloupce který chcete vynásobit");
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
