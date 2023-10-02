using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Vytvor program ktery bude fungovat jako kalkulacka.Kroky programu budou nasledujici:
             *1) Nacte vstup pro prvni cislo od uzivatele(vyuzijte metodu Console.ReadLine() - https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=netframework-4.8.
             *2) Zkonvertuje vstup od uzivatele ze stringu do integeru - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number.
             *3) Nacte vstup pro druhe cislo od uzivatele a zkonvertuje ho do integeru. (zopakovani kroku 1 a 2 pro druhe cislo)
             * 4) Nacte vstup pro ciselnou operaci.Rozmysli si, jak operace nazves. Muze to byt "soucet", "rozdil" atd.nebo napr "+", "-", nebo jakkoliv jinak.
             * 5) Nadefinuj integerovou promennou result a prirad ji prozatimne hodnotu 0.
             * 6) Vytvor podminky(if statement), podle kterych urcis, co se bude s cisly dit podle zadane operace
             * a proved danou operaci - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements.
             *7) Vypis promennou result do konzole
             *
             * Mozna rozsireni programu pro rychliky / na doma(na poradi nezalezi):
             *1) Vypis do konzole pred nactenim kazdeho uzivatelova vstupu co po nem chces
             * 2) a) Kontroluj, ze uzivatel do vstupu zadal, co mel(cisla, popr.ciselnou operaci).Pokud zadal neco jineho, napis mu, co ma priste zadat a program ukoncete.
             *2) b) To same, co a) ale misto ukonceni programu opakovane cti vstup, dokud uzivatel nezada to, co ma
             * -https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement
             *3) Umozni uzivateli zadavat i desetinna cisla, tedy prekopej kalkulacku tak, aby umela pracovat s floaty
            Console.WriteLine("zadejte první číslo:");
            */
            Console.WriteLine("zadejte číslo dle operace:\r\n 1 - sčítání\r\n 2 - odčítání\r\n 3 - násobení\r\n 4 - dělení\r\n 5 - umocnění\r\n" +
                " 6 - druhá odmocnina\r\n 7 - dekadický logaritmus \n 8 - převod z desítkové do dvojkové soustavy \n 9 - převod z dvojkové do desítkové soustavy");
            double x = 0;
            double y = 0;
            double z = 0;
            int a = 0;
            
            int operace = Convert.ToInt32(Console.ReadLine());
            if (operace == 1 || operace == 2 || operace ==3 || operace == 4) 
            {
                Console.WriteLine("zadejte první číslo:");
                x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("zadejte druhé číslo:");
                y = Convert.ToDouble(Console.ReadLine());
            }
            if else(operace == 8) 
            {
                Console.WriteLine("zadete celé číslo")
                a = Convert.ToInt32(Console.ReadLine());
            }
            if else(operace == 9)
            {
                Console.WriteLine("zadejte číslo v binární soustavě");
                
            }
            else
            {
                Console.WriteLine("zadejte číslo:");
                z = Convert.ToDouble(Console.ReadLine());
            }
            
            double result =0;
            string decToBinary = "";
            int docasna;
            
            
            
            switch(operace)
            {
                    case 1: result = x + y; break;
                    case 2: result = x - y; break;
                    case 3: result = x * y; break;
                    case 4: if(y != 0)
                            {
                                result = x / y;
                            }
                            else
                            {
                                do
                                {
                                    Console.WriteLine("řešení neexistuje - nulou nelze dělit. Zadejte znovu dělitele.");
                                    y = Convert.ToInt32(Console.Readline());
                                }
                                while(y == 0)
                                
                            }
                            break;    
                    case 5: 
                            if(z == 0)
                            {
                                do
                                {
                                Console.WriteLine("zadávejte mocninu než nula");
                                int mocnina = Convert.ToInt32(Console.ReadLine());
                                }
                                while(mocnina>0)
                                result = Math.Pow(z, mocnina);
                            }
                            else
                            { 
                            Console.WriteLine("zadejte kolikátou mocninu zadaného čísla budete chtít");
                            int mocnina = Convert.ToInt32(Console.ReadLine());
                            result = Math.Pow(z, mocnina);
                            }
                            
                    break;
                    case 6: result = Math.Sqrt(z);break;
                case 7: result = Math.Log10(z); break;
                case 8:
                    
                    while(z != 0)
                    {
                        docasna = z % 2;
                        decToBinary = docasna + decToBinary;
                        z = z  / 2;
                    }
                    break;
                case 9:
                    
                    
            }

            if(operace == 8)
            {
                Console.WriteLine(decToBinary);
            }
            else
            {
                Console.WriteLine("výsledek je: "+result);
            }
            

            Console.ReadKey();
        }
    }
}
