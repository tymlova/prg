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
            Console.WriteLine("VÍTEJTE VE HŘE PIŠKVORKY!");
            Console.WriteLine();
            Console.WriteLine("Hrací pole je velikosti 3x3 - postupně se v tazích střídáte s počítačem v zakreslování znaků, dokud jeden z vás nemá 3 své znaky ve sloupci, " +
                "řádku nebo plnou diagonálu. Když k tomu nedojde nastává remíza");
            Console.WriteLine("Na začátku hry si vyberete zda chcete hrát za O nebo X a poté zvolíte kolik kol hry chcete hrát");
            Console.WriteLine("Poté už jen hrajete - zadáváte číslo řádku a poté číslo sloupce, dle toho, kam chcete umístit svůj znak. Znaky nelze přepisovat ani zapisovat mimo vymezenou hrací plochu");
            Console.WriteLine("Všechny vstupy zadáváte po pokynu hry. Pokud není třeba nic zadávat mačkáte klávesu Enter.");
            Console.WriteLine("DŮLEŽITÉ: kdykoliv kdy budete chtít hru resetovat/ukončit/vybrat jinou, tak stačí při zadávání souřadnic napsat slovo 'menu' a vybrat si možnost, která vám vyhovuje.");
            Console.WriteLine();
            Console.WriteLine("Tak se do toho pojďme pustit!");
            Console.WriteLine();
            char usersAtt = AttributeChooser(); //volani fce, kde si hrac vybira za jaky znak bude hrat
            char compsAtt;
            if (usersAtt == 'X') //urceni znaku pro pocitac
            {
                compsAtt = 'O';
            }
            else
            {
                compsAtt = 'X';
            }
            Console.WriteLine();
            Console.WriteLine("Zadejte číslo 1, 3 nebo 5 a vyberte si tak variantu hry, kterou chcete hrát:");
            int roundsNumber = RoundsInputControl(Console.ReadLine()); //hrac zadava pocet kol
            Console.WriteLine();
            Rounds(rnd, array, compsAtt, usersAtt, roundsNumber); //volani fce, dle poctu zadanych kol
            Console.ReadKey();
        }

        public static void Rounds(Random rnd, char[,] array, char compsAtt, char usersAtt, int roundsNumber)
        {
            switch (roundsNumber) //volání fcí podle toho kolik kol si hráč zvolí
            {
                case 1:
                    OneRoundGame(rnd, array, compsAtt, usersAtt, roundsNumber);//1 kolo
                    break;
                case 3:
                    ThreeRoundGame(rnd, array, compsAtt, usersAtt, roundsNumber);//3 kola
                    break;
                case 5:
                    FiveRoundGame(rnd, array, compsAtt, usersAtt, roundsNumber);//5 kol
                    break;
            }
        }

       public static void OneRoundGame(Random rnd, char[,] array, char compsAtt, char usersAtt, int roundsNumber) //hra na 1 kolo
        {
            playingArray array2 = new playingArray();
            array2.DrawArray(); //vykresleni pole pomoci tridy a jeji fce
            Console.WriteLine();
            if (WhoStarts(rnd) == 0) //volani fce kdy hru zacina hrac nebo pocitac, podle toho jak dopadne losovani
            {
                TheGameUserStarts(array, rnd, compsAtt, usersAtt, roundsNumber);
                Menu(rnd, array, compsAtt,usersAtt, roundsNumber);//vypsani menu, kde hrac voli z moznosti zda chce pokracovat ve stejne hre, vybrat si jinou hru nebo hru uplne ukoncit
            }
            else
            {
                TheGameCompStarts(array, rnd, compsAtt, usersAtt, roundsNumber);
                Menu(rnd, array, compsAtt, usersAtt, roundsNumber);//vypsani menu, kde hrac voli z moznosti zda chce pokracovat ve stejne hre, vybrat si jinou hru nebo hru uplne ukoncit
            }
        }

        public static void ThreeRoundGame(Random rnd, char[,] array, char compsAtt, char usersAtt, int roundsNumber)//hra se tremi koly
        {
            playingArray array2 = new playingArray();
            array2.DrawArray();
            Console.WriteLine();
            int userScore = 0; //promenne ktere nacitaji skore hrace a pocitace
            int compScore = 0;
            int whoWon; //promenna uchovavajici hodnotu 0, 1 nebo 2 (0- hrac vyhral, 1 - pocitac vyhral, 2 remiza) - dulezite ve fci Result
            for (int i = 0; i < 3; i++)
            {
                if (WhoStarts(rnd) == 0)//volani fce kdy hru zacina hrac nebo pocitac, podle toho jak dopadne losovan
                {
                    whoWon = TheGameUserStarts(ArrayReset(array), rnd, compsAtt, usersAtt, roundsNumber);
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
                    whoWon = TheGameCompStarts(ArrayReset(array), rnd, compsAtt, usersAtt, roundsNumber);
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
            Result(userScore, compScore, rnd, array, compsAtt, usersAtt, roundsNumber); //vypsani vysledku
        }

        public static void FiveRoundGame(Random rnd, char[,] array, char compsAtt, char usersAtt, int roundsNumber)//5 kol
        {
            playingArray array2 = new playingArray();
            array2.DrawArray();
            Console.WriteLine();
            int whoWon;//pomocna promenna na vypisovani skore - pouziti v ifech
            int userScore = 0;//promenne na vypsani vysledku
            int compScore = 0;
            for (int i = 0; i < 5; i++)
            {
                if (WhoStarts(rnd) == 0)//volani fce kdy hru zacina hrac nebo pocitac, podle toho jak dopadne losovan
                {
                    whoWon = TheGameUserStarts(ArrayReset(array), rnd, compsAtt, usersAtt, roundsNumber);
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
                    whoWon = TheGameCompStarts(ArrayReset(array), rnd, compsAtt, usersAtt, roundsNumber);
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
            Result(userScore, compScore, rnd, array, compsAtt, usersAtt, roundsNumber);
        }

        public static int RoundsInputControl(string str) //kontrola vstupu, kdyz uzivatel zadava pocet kol
        {
            while (true)
            {
                if (int.TryParse(str, out int roundsNumber)) 
                {
                    if (roundsNumber == 1 || roundsNumber == 3 || roundsNumber == 5) //je vstup 1, 3 nebo 5?
                    {
                        return roundsNumber;
                    }
                    else //jine cislo
                    {
                        Console.WriteLine("zadejte 1. 3 nebo 5");
                        str = Console.ReadLine();
                    }

                }
                else //jiny datovy typ
                {
                    Console.WriteLine("zadejte 1. 3 nebo 5");
                    str = Console.ReadLine();
                }
            }
        }

        public static int NumbersInput(string str, Random rnd, char[,] array, char compsAtt, char usersAtt, int roundsNumber)//kontrola zadavani souradnic radku a sloupcu 0-2 a hodnot v menu
        {
            if (str == "menu")
            {
                Menu(rnd, array, compsAtt, usersAtt, roundsNumber);
            }
            while (true)
            {
                if (int.TryParse(str, out int a))
                {
                    if (a >=0 && a < 3)
                    {
                        return a;
                    }
                    else //spatne cislo
                    {
                        Console.WriteLine("zadejte prosím číslo ve správném rozsahu, to jest 0-2");
                        str = Console.ReadLine();
                    }

                }
                else//spatny datovy typ
                {
                    Console.WriteLine("zadejte prosím číslo ve správném rozsahu, to jest 0-2");
                    str = Console.ReadLine();
                }
            }
        }

        public static int WhoStarts(Random rnd)//losovani - kdo zacne
        {
            int usersRoll;
            int compsRoll;
            int whoStarts = 0;
            do//generovani cisla 1-6, kdo "hodi" vic tak zacina
            {
                compsRoll = rnd.Next(1, 7);
                usersRoll = rnd.Next(1, 7);
                Console.WriteLine("nyní házíte kostkou vy");
                Console.ReadKey();
                Console.WriteLine("hodili jste: " + usersRoll);
                Console.WriteLine("nyní hází počítač");
                Console.ReadKey();
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

        public static char AttributeChooser()//hrac si vybira zda chce hrat za O nebo X
        {
            Console.WriteLine("vyberte si znak, za který chcete hrát O/X");
            string str = Console.ReadLine();
            while (true)
            {
                if (char.TryParse(str, out char attribut))
                {
                    if (attribut == 'X' || attribut == 'x') //hrac muze zadat i male pismeno a nebude to chyba
                    {
                        Console.WriteLine("hrajete za znak X");
                        attribut = 'X';
                        return attribut;
                    }
                    else if(attribut == 'O' || attribut == 'o'|| attribut == '0')//hrac muze zadat velke o, male o i nulu
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

        public static bool ValidMoveComp(int row, int column, char compsAtt, char[,] array)//fce kontrolujici jestli souradnice ktere byly pro pocitac vygenerovany uz nejsou obsazene
        {
            
            if (array[row, column] != '_')
            {
                return false;
            }
            
            array[row, column] = compsAtt;
            return true;
        }

        public static bool ValidMoveUser1(int row, int column, char usersAtt, char[,] array)//fce kontroluje jestli uzivatel zadal cisla ve spravnem rozsahu a jestli pole neni obsazene - kontroluje u prvniho vstupu (měla jsem problem ze se text vypisoval vicekrat, tak jsem to rozdelila do dvou trid)
        {

            if (array[row, column] != '_' || row < 0 || row >= 3 || column < 0 || column >=3)
            {
                Console.WriteLine("Tento tah nemůžete provést, pole je buď obsazené nebo jste překročili hranici. Zadejte prosím správný vstup");
                return false;
            }
            
            array[row, column] = usersAtt;
            
            return true;
        }

        public static bool ValidMoveUser2(int row, int column, char usersAtt, char[,] array)//fce je volana kdyz uzivatel zada spatny vstup
        {

            if (array[row, column] != '_' || row < 0 || row >= 3 || column < 0 || column >= 3)
            {
                return false;
            }

            array[row, column] = usersAtt;

            return true;
        }

        public static bool WinCheck(char[,] array) //hledani shody
        {
            for (int i = 0; i < 3; i++) //kontrola shody v řádcích
            {
                if (array[i, 0] != '_' && array[i, 0] == array[i, 1] && array[i, 1] == array[i, 2]) 
                {
                    return true;
                }
            }
            for (int i = 0; i < 3; i++) //kontrola shody ve sloupcích
            {
                if (array[0, i] != '_' && array[0, i] == array[1, i] && array[1, i] == array[2, i]) 
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

        public static bool FullPlayground(char[,] array)//zjistuje jesli je pole plne
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

        public static bool GameOver(char[,] array) // zjistuje zda hra skoncila
        {
            return WinCheck(array) || FullPlayground(array);
        }


        public static int TheGameUserStarts(char[,] array, Random rnd, char compsAtt, char usersAtt, int roundsNumber)//hra kde zacina hrac
        {
            int whoWon;
            while (!GameOver(array))
            {
                int userRow;
                int userCol;
                Console.WriteLine("Jste na tahu - zadejte číslo řádku"); //zadavani hodnot
                userRow = NumbersInput(Console.ReadLine(), rnd, array, compsAtt, usersAtt, roundsNumber);
                Console.WriteLine();
                Console.WriteLine("Zadejte číslo sloupce");
                userCol = NumbersInput(Console.ReadLine(), rnd, array, compsAtt, usersAtt, roundsNumber);
                Console.WriteLine();
                if (ValidMoveUser1(userRow, userCol, usersAtt, array)) //kontrola vstupu
                {
                    if (GameOver(array)) //kontrola konce hry
                    { 
                        if (WinCheck(array))
                        {
                            HighlightUser(array, usersAtt);
                            Console.WriteLine("Vyhráli jste");
                            whoWon = 0;
                            ArrayReset(array);
                            return whoWon;
                        }
                        
                        if (FullPlayground(array))
                        {
                            Draw(array);
                            Console.WriteLine("je to remíza");
                            whoWon = 2;
                            return whoWon;
                        }
                        
                    }
                    Console.WriteLine();
                }
                else
                {
                    
                    while (!ValidMoveUser2(userRow, userCol, usersAtt, array)) //zadavani spravnych hodnot pokud hrac zada spatne
                        {
                            Console.WriteLine("zadejte znovu číslo řádku");
                            userRow = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("zadejte znovu číslo sloupce");
                            userCol = Convert.ToInt32(Console.ReadLine());
                        }
                    if (GameOver(array))
                    {

                        if (WinCheck(array))
                        {
                            HighlightUser(array, usersAtt);
                            Console.WriteLine("Vyhráli jste");
                            whoWon = 0;
                            ArrayReset(array);
                            return whoWon;
                        }

                        if (FullPlayground(array))
                        {
                            Draw(array);
                            Console.WriteLine("je to remíza");
                            whoWon = 2;
                            ArrayReset(array);
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
                    compRow = rnd.Next(0, 3); //generovani tahu pocitace
                    compCol = rnd.Next(0, 3);
                } while (!ValidMoveComp(compRow, compCol, compsAtt, array));

                if (GameOver(array))
                {
                    if (WinCheck(array))
                    {
                        HighlightComp(array, compsAtt);
                        Console.WriteLine("Vyhrál počítač");
                        whoWon = 1;
                        ArrayReset(array);
                        return whoWon;
                    }
                    if (FullPlayground(array))
                    {
                        Draw(array);
                        Console.WriteLine("je to remíza");
                        whoWon = 2;
                        ArrayReset(array);
                        return whoWon;
                    }
                }
                Draw(array);
            }

            Draw(array);
            Console.WriteLine();
            Console.WriteLine("Je to nerozhodně");
            whoWon = 2;
            return whoWon;
        }

        public static int TheGameCompStarts(char[,] array, Random rnd, char compsAtt, char usersAtt, int roundsNumber) //hra kde zacina pocitac
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
                    compRow = rnd.Next(0, 3); //generovani tahu
                    compCol = rnd.Next(0, 3);
                } while (!ValidMoveComp(compRow, compCol, compsAtt, array));

                if(GameOver(array))
                {
                    if (WinCheck(array))
                    {
                        HighlightComp(array, compsAtt);
                        Console.WriteLine("Vyhrál počítač");
                        whoWon = 1;
                        ArrayReset(array);
                        return whoWon;
                    }
                    if (FullPlayground(array))
                    {
                        Draw(array);
                        Console.WriteLine("je to remíza");
                        whoWon = 2;
                        ArrayReset(array);
                        return whoWon;
                    }
                }

                Draw(array);

                int userRow;
                int userCol;
                Console.WriteLine();
                Console.WriteLine("Jste na tahu - zadejte číslo řádku"); //zadavani hodnot
                userRow = NumbersInput(Console.ReadLine(), rnd, array, compsAtt, usersAtt, roundsNumber);
                Console.WriteLine();
                Console.WriteLine("Zadejte číslo sloupce");
                userCol = NumbersInput(Console.ReadLine(), rnd, array, compsAtt, usersAtt, roundsNumber);

                if(ValidMoveUser1(userRow, userCol, usersAtt, array))
                {
                    if (GameOver(array))
                    {
                        if (WinCheck(array))
                        {
                            HighlightUser(array, usersAtt);
                            Console.WriteLine("Vyhráli jste");
                            whoWon = 0;
                            ArrayReset(array);
                            
                            return whoWon;
                        }
                        if (FullPlayground(array))
                        {
                            Draw(array);
                            Console.WriteLine("je to remíza");
                            whoWon = 2;
                            ArrayReset(array);
                            return whoWon;
                        }
                    }
                    Console.WriteLine();
                }
                else
                {

                    while (!ValidMoveUser2(userRow, userCol, usersAtt, array)) //znovuzadavani hodnot kdyz byly spatne zadany
                    {
                        Console.WriteLine("zadejte znovu číslo řádku");
                        userRow = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("zadejte znovu číslo sloupce");
                        userCol = Convert.ToInt32(Console.ReadLine());
                    }
                    if (GameOver(array))
                    {
                        if (WinCheck(array))
                        {
                            HighlightUser(array, usersAtt);
                            Console.WriteLine("Vyhráli jste");
                            whoWon = 0;
                            ArrayReset(array);
                            return whoWon;
                        }
                        if (FullPlayground(array))
                        {
                            Draw(array);
                            Console.WriteLine("je to remíza");
                            whoWon = 2;
                            ArrayReset(array);
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

        public static void Draw(char[,] array) //vykresluje pole, protoze to neslo pres tridu
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
        
        public static char[,] ArrayReset(char[,] array) //nastavuje pole na prazdne pole 
        {
             array = new char[3, 3]
                        {
                            { '_','_','_'},
                            { '_','_','_'},
                            { '_','_','_'}
                        };
            return array;
        }

        public static void Result(int userScore, int compScore, Random rnd, char[,] array, char compsAtt, char usersAtt, int roundsNumber) //vypisuje vysledky hry na zaklade skore
        {
            Console.WriteLine("konečné skóre je počítač: " + compScore + " vy: " + userScore);
            if (compScore > userScore)
            {
                Console.WriteLine("POČÍTAČ TĚ ULTIMÁTNĚ PORAZIL!!!");
                Menu(rnd, array, compsAtt, usersAtt, roundsNumber);
            }
            else if (compScore < userScore)
            {
                Console.WriteLine("ULTIMÁTNĚ JSTE VYHRÁLI, GRATULUJI!!!");
                Menu(rnd, array, compsAtt, usersAtt, roundsNumber);
            }
            else
            {
                Console.WriteLine("Je to remíza");
                Menu(rnd, array, compsAtt, usersAtt, roundsNumber);
            }
        }

        public static void HighlightComp(char[,] array, char compsAtt) //zvyrazneni znaku pocitace pokud vyhraje
        {
            ConsoleColor originalColor = Console.ForegroundColor; //na barvy jsem vyuzila pomoc chatuGPT
            Console.WriteLine("  0 1 2");
            if (compsAtt == 'X') //rozdeleni podle znaku pocitace
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(i + " ");
                    for (int j = 0; j < 3; j++)
                    {
                        if (array[i, j] == 'X')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else
                        {
                            Console.ForegroundColor = originalColor;
                        }
                        Console.Write(array[i, j] + " ");
                        Console.ForegroundColor = originalColor;
                    }
                    Console.WriteLine();
                }
                
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(i + " ");
                    for (int j = 0; j < 3; j++)
                    {
                        if (array[i, j] == 'O')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else
                        {
                            Console.ForegroundColor = originalColor;
                        }
                        Console.Write(array[i, j] + " ");
                        Console.ForegroundColor = originalColor;
                    }
                    Console.WriteLine();
                }
                
            }
            
        }

        public static void HighlightUser(char[,] array, char usersAtt) //zvyrazneni znaku hrace kdyz vyhraje
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.WriteLine("  0 1 2");
            if (usersAtt == 'X')
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(i + " ");
                    for (int j = 0; j < 3; j++)
                    {
                        if (array[i, j] == 'X')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.ForegroundColor = originalColor;
                        }
                        Console.Write(array[i, j] + " ");
                        Console.ForegroundColor = originalColor;
                    }
                    Console.WriteLine();
                }
                
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(i + " ");
                    for (int j = 0; j < 3; j++)
                    {
                        if (array[i, j] == 'O')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.ForegroundColor = originalColor;
                        }
                        Console.Write(array[i, j] + " ");
                        Console.ForegroundColor = originalColor;
                    }
                    Console.WriteLine();
                    
                }
                
            }

        }

        public static void Menu(Random rnd, char[,] array, char compsAtt, char usersAtt, int roundsNumber)//fce je volana na uplnem konci kazde hry a kdykoliv kdy hrac napise slovo menu 
        {
            
            Console.WriteLine();
            Console.WriteLine("Co chcete dělat dál? Zadejte prosím číslo přiřazené příkazu (0-2)");
            Console.WriteLine("0 - hrát znovu");
            Console.WriteLine("1 - vyberte si jinou hru");
            Console.WriteLine("2 - ukončit hru");
            int operation = NumbersInput(Console.ReadLine(), rnd, array, compsAtt, usersAtt, roundsNumber); //recyklace fce NumbersInput (proto jsou cisla 0-2)
            switch (operation)
            {
                case 0:
                    if (roundsNumber == 1)
                    {
                        OneRoundGame(rnd, ArrayReset(array), compsAtt, usersAtt, roundsNumber);
                    }
                    else if (roundsNumber == 3)
                    {
                        ThreeRoundGame(rnd, ArrayReset(array), compsAtt, usersAtt, roundsNumber);
                    }
                    else
                    {
                        FiveRoundGame(rnd, ArrayReset(array), compsAtt, usersAtt, roundsNumber);
                    }
                    break;
                case 1:
                    Console.WriteLine("Zadejte číslo 1, 3 nebo 5 a vyberte si tak variantu hry, kterou chcete hrát:");
                    roundsNumber = RoundsInputControl(Console.ReadLine());
                    Rounds(rnd, ArrayReset(array), compsAtt, usersAtt, roundsNumber);
                    break; 
                case 2:
                    Environment.Exit(0); //taky pomoc chatuGPT
                    break;
                
            }
        }
    }
}
