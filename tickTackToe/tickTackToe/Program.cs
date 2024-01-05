using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tickTackToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
           
            Console.WriteLine("Vítejte ve hře piškvorky. Zde si můžete zahrát proti počítači piškvorky 3x3, což znamená, že máte mřížku 3x3 a snažíte se do ní umístit X/O, tak abyste měli sloupec," +
                " řádek a nebo diagonálu zaplněnou pouze svými znaky, dříve než váš soupeř. Na začátku hry se náhodně vybere, kdo začne - vám i počítači se vygeneruje náhodné číslo a kdo má " +
                "vyšší číslo, tak bude začínat. Na začátku hry se zobrazí prázdná mřížka, kde se budou zobrazovat všechny tahy. Váš znak zakreslíte tak, že napíšete souřadnice, kam chcete znak" +
                " umístit - vždy zadáte číslo (0, 1, 2), které popisuje řádek a poté číslo (0, 1, 2), které popisuje daný sloupec. Souřadnice zadáváte zvlášť dle pokynů hry. Znaky " +
                "nelze přepisovat. Dále si také můžete vybrat zda chcete hrát 1, 3 či 5 kol hry - body za vítězství z každého kola se vám sečtou a na konci bude vyhrášen vítěz. Tak se do" +
                " toho pojďme pustit");

            AttributeChooser(); //hráč si vybírá za jaký znak bude hrát
            int whoStarts = WhoStarts(rnd); //losování hráče, který bude začínat
            Console.WriteLine("Zadejte číslo 1, 3 nebo 5 a vyberte si tak variantu hry, kterou chcete hrát:");
            int roundsNumber = RoundsInputControl(Console.ReadLine());
            
            switch (roundsNumber) //volání fcí podle toho kolik kol si hráč zvolí
            {
                case 1:
                    break;
                case 3:
                    break;
                case 5:
                    break;
            }


            Console.ReadKey();
        }

       public static void OneRoundGame()
        {

        }

        public static void ThreeRoundGame()
        {

        }

        public static void FiveRoundGame()
        {

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
                        return attribut;
                    }
                    else if(attribut == 'O' || attribut == 'o'|| attribut == '0')
                    {
                        
                        Console.WriteLine("hrajete za znak O");
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

        public static bool ValidMoveComp(int row, int column, char compsAtt, int[,] array)
        {
            
            if (array[row, column] == '_' || row >= 0 || row < 3 || column >= 0 || column < 3 )
            {

            }
        }


       public static void TheGameUserStarts()
        {
            playingArray array = new playingArray();
            array.DrawArray();
        }

        public static void TheGameCompStarts()
        {
            playingArray array = new playingArray();
            array.DrawArray();
            char usersAtt = AttributeChooser();
            char compsAtt = 'a';
            if (AttributeChooser() == 'X')
            {
                 compsAtt = 'O';
            }
            else
            {
                 compsAtt = 'X';
            }

            while (/*!GameOver()*/)
            {

            }

        }


    }
}
