using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace tickTackToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            playingArray array2 = new playingArray();
            char[,] array = array2.array;
            Console.WriteLine("Vítejte ve hře piškvorky. Zde si můžete zahrát proti počítači piškvorky 3x3, což znamená, že máte mřížku 3x3 a snažíte se do ní umístit X/O, tak abyste měli sloupec," +
                " řádek a nebo diagonálu zaplněnou pouze svými znaky, dříve než váš soupeř. Na začátku hry se náhodně vybere, kdo začne - vám i počítači se vygeneruje náhodné číslo a kdo má " +
                "vyšší číslo, tak bude začínat. Na začátku hry se zobrazí prázdná mřížka, kde se budou zobrazovat všechny tahy. Váš znak zakreslíte tak, že napíšete souřadnice, kam chcete znak" +
                " umístit - vždy zadáte číslo (0, 1, 2), které popisuje řádek a poté číslo (0, 1, 2), které popisuje daný sloupec. Souřadnice zadáváte zvlášť dle pokynů hry. Znaky " +
                "nelze přepisovat. Dále si také můžete vybrat zda chcete hrát 1, 3 či 5 kol hry - body za vítězství z každého kola se vám sečtou a na konci bude vyhrášen vítěz. Tak se do" +
                " toho pojďme pustit");
            Console.WriteLine();
            char usersAtt = AttributeChooser();
            char compsAtt;
            if (usersAtt == 'X')
            {
                compsAtt = 'O';
            }
            else
            {
                compsAtt = 'X';
            }
            Console.WriteLine();
            Console.WriteLine("Zadejte číslo 1, 3 nebo 5 a vyberte si tak variantu hry, kterou chcete hrát:");
            int roundsNumber = RoundsInputControl(Console.ReadLine());
            
            switch (roundsNumber) //volání fcí podle toho kolik kol si hráč zvolí
            {
                case 1:OneRoundGame(rnd, array, compsAtt, usersAtt);
                    break;
                case 3:ThreeRoundGame(rnd, array, compsAtt, usersAtt);
                    break;
                case 5:FiveRoundGame(rnd, array, compsAtt, usersAtt);
                    break;
            }


            Console.ReadKey();
        }

       public static void OneRoundGame(Random rnd, char[,] array, char compsAtt, char usersAtt)
        {
            playingArray array2 = new playingArray();
            array2.DrawArray();
            if (WhoStarts(rnd) == 0)
            {
                TheGameUserStarts(array, rnd, compsAtt, usersAtt);
            }
            else
            {
                TheGameCompStarts(array, rnd, compsAtt, usersAtt);
            }
        }

        public static void ThreeRoundGame(Random rnd, char[,] array, char compsAtt, char usersAtt)
        {
            playingArray array2 = new playingArray();
            array2.DrawArray();
            int userScore = 0;
            int compScore = 0;
            int whoWon;
            for (int i = 0; i < 3; i++)
            {
                if (WhoStarts(rnd) == 0)
                {
                    whoWon = TheGameUserStarts(ArrayReset(array), rnd, compsAtt, usersAtt);
                    if (whoWon == 0)
                    {
                        userScore++;
                    }
                    else if(whoWon == 1)
                    {
                        compScore++;
                    }   
                }
                else
                {
                    whoWon = TheGameCompStarts(ArrayReset(array), rnd, compsAtt, usersAtt);
                    if (whoWon == 0)
                    {
                        userScore++;
                    }
                    else if (whoWon == 1)
                    {
                        compScore++;
                    }
                }
            }
            Console.WriteLine();
            Result(userScore, compScore); 
        }

        public static void FiveRoundGame(Random rnd, char[,] array, char compsAtt, char usersAtt)
        {
            playingArray array2 = new playingArray();
            array2.DrawArray();
            int whoWon;
            int userScore = 0;
            int compScore = 0;
            for (int i = 0; i < 5; i++)
            {
                if (WhoStarts(rnd) == 0)
                {
                    whoWon = TheGameUserStarts(ArrayReset(array), rnd, compsAtt, usersAtt);
                    if (whoWon == 0)
                    {
                        userScore++;
                    }
                    else if (whoWon == 1)
                    {
                        compScore++;
                    }

                }
                else
                {
                    whoWon = TheGameCompStarts(ArrayReset(array), rnd, compsAtt, usersAtt);
                    if (whoWon == 0)
                    {
                        userScore++;
                    }
                    else if (whoWon == 1)
                    {
                        compScore++;
                    }
                }
            }
            Console.WriteLine();
            Result(userScore, compScore);
        }

        public static int RoundsInputControl(string str) //kontrola vstupů
        {
            while (true)
            {
                if (int.TryParse(str, out int roundsNumber)) 
                {
                    if (roundsNumber == 1 || roundsNumber == 3 || roundsNumber == 5) //je vstup 1, 3 nebo 5?
                    {
                        return roundsNumber;
                    }
                    else
                    {
                        Console.WriteLine("zadejte 1. 3 nebo 5");
                        str = Console.ReadLine();
                    }

                }
                else
                {
                    Console.WriteLine("zadejte 1. 3 nebo 5");
                    str = Console.ReadLine();
                }
            }
        }

        public static int NumbersInput(string str)
        {
            while (true)
            {
                if (int.TryParse(str, out int a))
                {
                    if (a >=0 && a < 3)
                    {
                        return a;
                    }
                    else
                    {
                        Console.WriteLine("zadejte prosím číslo ve správném rozsahu, to jest 0-2");
                        str = Console.ReadLine();
                    }

                }
                else
                {
                    Console.WriteLine("zadejte prosím číslo ve správném rozsahu, to jest 0-2");
                    str = Console.ReadLine();
                }
            }
        }

        public static int WhoStarts(Random rnd)
        {
            int usersRoll;
            int compsRoll;
            int whoStarts = 0;
            do
            {
                Console.WriteLine("nyní házíte kostkou vy");
                usersRoll = rnd.Next(1, 7);
                Console.ReadKey();
                Console.WriteLine("hodili jste: " + usersRoll);
                Console.WriteLine("nyní hází počítač");
                Console.ReadKey();
                compsRoll = rnd.Next(1, 7);
                Console.WriteLine("počítač hodil: " + compsRoll);
                if (usersRoll > compsRoll)
                {
                    Console.WriteLine("začínáte");
                    whoStarts = 0;

                }
                else if(usersRoll < compsRoll)
                {
                    Console.WriteLine("začíná počítač");
                    whoStarts = 1;
                }
                
            }
            while (usersRoll == compsRoll);
            return whoStarts;
        }

        public static char AttributeChooser()
        {
            Console.WriteLine("vyberte si znak, za který chcete hrát O/X");
            string str = Console.ReadLine();
            while (true)
            {
                if (char.TryParse(str, out char attribut))
                {
                    if (attribut == 'X' || attribut == 'x') //je vstup 1, 3 nebo 5?
                    {
                        Console.WriteLine("hrajete za znak X");
                        attribut = 'X';
                        return attribut;
                    }
                    else if(attribut == 'O' || attribut == 'o'|| attribut == '0')
                    {
                        
                        Console.WriteLine("hrajete za znak O");
                        attribut = 'O';
                        return attribut;
                    }
                    else
                    {
                        Console.WriteLine("zadejte X nebo O");
                        str = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("zadejte X nebo O");
                     str = Console.ReadLine();
                }
            }
        }

        public static bool ValidMoveComp(int row, int column, char compsAtt, char[,] array)
        {
            
            if (array[row, column] != '_' || row < 0 || row >= 3 || column < 0 || column >= 3 )
            {
                Console.WriteLine("Tento tah nemůžete provést, pole je buď obsazené nebo jste překročili hranici. Zadejte prosím správný vstup");
                return false;
            }
            
            array[row, column] = compsAtt;
            return true;
        }

        public static bool ValidMoveUser(int row, int column, char usersAtt, char[,] array)
        {

            if (array[row, column] != '_' || row < 0 || row >= 3 || column < 0 || column >=3)
            {
                Console.WriteLine("Tento tah nemůžete provést, pole je buď obsazené nebo jste překročili hranici. Zadejte prosím správný vstup");
                return false;
            }
            
            array[row, column] = usersAtt;
            
            return true;
        }

        public static bool WinCheck(char[,] array)
        {
            for (int i = 0; i < 3; i++) //kontrola shody v řádcích
            {
                if (array[i, 0] != '_' && array[i, 0] == array[i, 1] && array[i, 1] == array[i, 2]) //kontrola řádků
                {
                    return true;
                }
            }
            for (int i = 0; i < 3; i++) //kontrola shody ve sloupcích
            {
                if (array[0, i] != '_' && array[0, i] == array[1, i] && array[1, i] == array[2, i]) //kontrola řádků
                {
                    return true;
                }
            }

            //kontrola hlavní diagonály
            if (array[0, 0] != '_' && array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2])
            {
                return true;
            }

            //kontrola vedlejší diagonály
            if (array[2, 0] != '_' && array[2, 0] == array[1, 1] && array[1, 1] == array[0, 2])
            {
                return true;
            }

            return false;
        }

        public static bool FullPlayground(char[,] array)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (array[i, j] == '_')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool GameOver(char[,] array)
        {
            return WinCheck(array) || FullPlayground(array);
        }


        public static int TheGameUserStarts(char[,] array, Random rnd, char compsAtt, char usersAtt)
        {
            int whoWon;
            while (!GameOver(array))
            {
                int userRow;
                int userCol;
                Console.WriteLine("Jste na tahu - zadejte číslo řádku");
                userRow = NumbersInput(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Zadejte číslo sloupce");
                userCol = NumbersInput(Console.ReadLine());
                Console.WriteLine();

                if (ValidMoveUser(userRow, userCol, usersAtt, array))
                {
                   
                    if (GameOver(array))
                    {
                        Draw(array);
                        if (WinCheck(array))
                        {
                            Console.WriteLine("Vyhráli jste");
                            whoWon = 0;
                            ArrayReset(array);
                            return whoWon;
                        }
                        
                        if (FullPlayground(array))
                        {
                            Console.WriteLine("je to remíza");
                            whoWon = 2;
                            return whoWon;
                        }
                        
                    }
                    Console.WriteLine();
                }
                Draw(array);
                Console.WriteLine();
                Console.WriteLine("Hraje počítač");
                int compRow;
                int compCol;
                do
                {
                    compRow = rnd.Next(0, 3);
                    compCol = rnd.Next(0, 3);
                } while (!ValidMoveComp(compRow, compCol, compsAtt, array));

                Draw(array);
                Console.WriteLine();
                if (GameOver(array))
                {
                    Draw(array);
                    if (WinCheck(array))
                    {
                        Console.WriteLine("Vyhrál počítač");
                        whoWon = 1;
                        ArrayReset(array);
                        return whoWon;
                    }

                    if (FullPlayground(array))
                    {
                        Console.WriteLine("je to remíza");
                        whoWon = 2;
                        return whoWon;
                    }
                }
            }

            Draw(array);
            Console.WriteLine();
            Console.WriteLine("Je to nerozhodně");
            whoWon = 2;
            ArrayReset(array);
            return whoWon;
        }

        public static int TheGameCompStarts(char[,] array, Random rnd, char compsAtt, char usersAtt)
        {
            int whoWon;
            while (!GameOver(array))
            {
                Console.WriteLine();
                Console.WriteLine("Hraje počítač");
                int compRow;
                int compCol;
                do
                {
                    compRow = rnd.Next(0, 3);
                    compCol = rnd.Next(0, 3);
                } while (!ValidMoveComp(compRow, compCol, compsAtt, array));

                if(GameOver(array))
                {
                    Draw(array);
                    if (WinCheck(array))
                    {
                        Console.WriteLine("Vyhrál počítač");
                        whoWon = 1;
                        ArrayReset(array);
                        return whoWon;
                    }

                    if (FullPlayground(array))
                    {
                        Console.WriteLine("je to remíza");
                        whoWon = 2;
                        return whoWon;
                    }



                }

                Draw(array);

                int userRow;
                int userCol;
                Console.WriteLine();
                Console.WriteLine("Jste na tahu - zadejte číslo řádku");
                userRow = NumbersInput(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Zadejte číslo sloupce");
                userCol = NumbersInput(Console.ReadLine());

                if(ValidMoveUser(userRow, userCol, usersAtt, array))
                {
                    if (GameOver(array))
                    {
                        Draw(array);
                        if (WinCheck(array))
                        {
                            Console.WriteLine("Vyhráli jste");
                            whoWon = 0;
                            ArrayReset(array);
                            return whoWon;
                        }

                        if (FullPlayground(array))
                        {
                            Console.WriteLine("je to remíza");
                            whoWon = 2;
                            return whoWon;
                        }


                    }
                    Console.WriteLine();
                }
            }

            Draw(array);
            Console.WriteLine();
            Console.WriteLine("Je to nerozhodně");
            ArrayReset(array);
            whoWon = 2;
            return whoWon;
            

        }

        public static void Draw(char[,] array)
        {
            Console.WriteLine("  0 1 2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        
        public static char[,] ArrayReset(char[,] array)
        {
             array = new char[3, 3]
                        {
                            { '_','_','_'},
                            { '_','_','_'},
                            { '_','_','_'}
                        };
            return array;
        }

        public static void Result(int userScore, int compScore)
        {
            Console.WriteLine("konečné skóre je počítač: " + compScore + " vy: " + userScore);
            if (compScore > userScore)
            {
                Console.WriteLine("POČÍTAČ TĚ ULTIMÁTNĚ PORAZIL!!!");
            }
            else if (compScore < userScore)
            {
                Console.WriteLine("ULTIMÁTNĚ JSTE VYHRÁLI, GRATULUJI!!!");
            }
            else
            {
                Console.WriteLine("Je to remíza");
            }
        }
    }
}
