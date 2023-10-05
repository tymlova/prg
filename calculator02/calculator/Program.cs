using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

            int operace = Convert.ToInt32(Console.ReadLine()); //čtena z výběru operací

            double x = 0; //proměnné pro operace 1-7
            double y = 0;
            double z = 0;
            double result = 0;

            int a = 0; //proměnné pro převod z desítkové do dvojkové
            int puvodniA = 0;
            string decToBinary = "";
            int docasna;

            string binaryToDecIn; //proměnné na převod z dvojkové do desítkové
            int binaryToDecOut = 0;

           
            if (operace == 1 || operace == 2 || operace ==3 || operace == 4) //načítání vstupu pro operace, kde jsou potřeba 2 čísla
            {
                Console.WriteLine("zadejte první číslo:");
                x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("zadejte druhé číslo:");
                y = Convert.ToDouble(Console.ReadLine());
            }
            else if (operace == 8) //načítání vstupu pro převod na dvojkovou
            {
                Console.WriteLine("zadete celé číslo");
                a = Convert.ToInt32(Console.ReadLine());
            }
            else if (operace == 9) //načítání vstupu pro převod z dvojkové
            {
                Console.WriteLine("zadejte číslo v binární soustavě");
            }
            else //načítání vstupu pro operace s potřebou jen jednoho čísla
            {
                Console.WriteLine("zadejte číslo:");
                z = Convert.ToDouble(Console.ReadLine());
            }
            
            switch (operace)
            {
                case 1: result = x + y; break; //sčítání
                case 2: result = x - y; break; //odčítání
                case 3: result = x * y; break; //násobení
                case 4: 
                    if(y != 0) 
                    {
                        result = x / y;
                    }
                    else //zjišťování dělení nulou a přepisování dělitele
                    {
                        do
                        {
                             Console.WriteLine("řešení neexistuje - nulou nelze dělit. Zadejte znovu dělitele.");
                             y = Convert.ToInt32(Console.ReadLine());
                        }
                        while (y == 0);
                        result = x / y; 
                    }
                    break;    
                case 5: 
                    if(z == 0) //zjišťování jestli není základ 0, protože kdyby pak byla mocnina záporná došlo by k dělení nulou
                    {
                        int mocnina;
                        do
                        {
                            Console.WriteLine("zadávejte mocninu větší než nula");
                            mocnina = Convert.ToInt32(Console.ReadLine());
                        }
                        while (mocnina <= 0);
                        result = Math.Pow(z, mocnina);
                    }
                    else
                    { 
                        Console.WriteLine("zadejte kolikátou mocninu zadaného čísla budete chtít");
                        int mocnina = Convert.ToInt32(Console.ReadLine());
                        result = Math.Pow(z, mocnina);
                    }   
                    break;
                case 6:
                    if (z >= 0)
                    {
                        result = Math.Sqrt(z);
                    }
                    else
                    {
                        do //podmínky pro druhou odmocninu
                        {
                            Console.WriteLine("dané číslo nelze odmocnit, zadejte validní vstup");
                            z = Convert.ToInt32(Console.ReadLine());   
                        } 
                        while (z < 0);
                        result = Math.Sqrt(z);
                    }
                    break;
                case 7:
                    if (z>0)
                    {
                        result = Math.Log10(z);
                    }
                    else
                    {
                        do //podmínky u logaritmů
                        {
                            Console.WriteLine("zadejte validní vstup, to jest číslo > 0");
                            z = Convert.ToInt32(Console.ReadLine());
                        } 
                        while (z <= 0);
                        result = Math.Log10(z);
                    }
                    result = Math.Log10(z); 
                    break;
                case 8:
                    puvodniA = a; //slouží pouze k vypisování původního čísla u výstupu
                    while (a != 0)
                   {
                        docasna = a % 2; //ukládání zbyku po dělení -> postupné připisování do výsledku -> zmenšení původního čísla
                        decToBinary = docasna + decToBinary;
                        a = a / 2;
                    }
                    break;
                case 9:
                    int nulyJednicky; //uchovává hodnotu dané části binární soustavy
                    binaryToDecIn = Convert.ToString(Console.ReadLine());
                    char[] binaryArr = binaryToDecIn.ToCharArray(); //rozdělení stringu na char
                    Array.Reverse(binaryArr); //obrácení zadaného pole, aby se postupně zvyšující hodnota mocniny četla ve správném pořadí (vypomohla jsem si na internetu - nevěděla jsem jak reverse použít)
                   for (int i = 0; i < binaryArr.Length; i++)
                    {
                        if (binaryArr[i] == '0') //čtení pole dle indexu i, podle toho se mění proměnná nulyJednicky a připočítává se k binaryToDecOut
                        {
                            nulyJednicky = 0;
                        }
                        else
                        {
                            nulyJednicky = 1;
                        }
                        binaryToDecOut = binaryToDecOut + ((int)(nulyJednicky * Math.Pow(2, i)));
                    }
                    break;

            }
            //vypisování výsledků
            if (operace == 8)
            {
                Console.WriteLine(puvodniA +" odpovídá v binární soustavě " + decToBinary);
            }
            else if (operace == 9)
            {
                Console.WriteLine(binaryToDecOut);
            }
            else
            {
                Console.WriteLine("výsledek je: " + result);
            }
            
            Console.ReadKey();
        }
    }
}
