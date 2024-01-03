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
            Console.WriteLine("Vítejte ve hře piškvorky. Zde si můžete zahrát proti počítači piškvorky 3x3, což znamená, že máte mřížku 3x3 a snažíte se do ní umístit X/O, tak abyste měli sloupec," +
                " řádek a nebo diagonálu zaplněnou pouze svými znaky, dříve než váš soupeř. Na začátku hry se náhodně vybere, kdo začne - vám i počítači se vygeneruje náhodné číslo a kdo má " +
                "vyšší číslo, tak bude začínat. Na začátku hry se zobrazí prázdná mřížka, kde se budou zobrazovat všechny tahy. Váš znak zakreslíte tak, že napíšete souřadnice, kam chcete znak" +
                " umístit - vždy zadáte malé písmeno (a, b, c), které popisuje řádek a poté číslo (1, 2, 3), které popisuje daný sloupec. Souřadnice zadáváte zvlášť dle pokynů hry. Znaky " +
                "nelze přepisovat. Dále si také můžete vybrat zda chcete hrát 1, 3 či 5 kol hry - body za vítězství z každého kola se vám sečtou a na konci bude vyhrášen vítěz. Tak se do" +
                " toho pojďme pustit");
            Console.WriteLine("Zadejte číslo 1, 3 nebo 5 a vyberte si tak variantu hry, kterou chcete hrát:");
            int roundsNumber = Convert.ToInt32(Console.ReadLine());
            switch (roundsNumber)
            {
                case 1:
                    break;
                case 3:
                    break;
                case 5:
                    break;
            }
        }

       public static void oneRoundGame()
        {

        }

        public static void threeRoundGame()
        {

        }

        public static void fiveRoundGame()
        {

        }
    }
}
