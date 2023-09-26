using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace Deathroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Vytvor program, kde bude uzivatel hrat s pocitacem deathroll.
             * Pravidla deathrollu: Prvni hrac navrhne cislo (puvodne ve wowku pocet goldu, o ktere se hraci vsadi) a "rollne" navrhnute cislo, jinak receno je to stejne,
             * jako kdyby si hodil kostkou s tolika stenami, jako je navrhnute cislo. Prvnimu hraci "padne" nejake cislo a druhy hrac si "rollne" padnute cislo.
             * Prohrava ten hrac, kteremu padne 1 jako prvnimu.
             * Ukazka hry: Hraci se shodnou na cisle 1000. Prvni hrac rollne 0-1000, padne mu 920. Druhy hrac rolluje 0-920, padne mu 235 atd. atd. az jednomu z hracu padne 1
             * a ten prohrava.
             * 
             * Struktura:
             * 
             * - nadefinuj promenne, ktere budes potrebovat po celou dobu hry, tedy aktualne rollovane cislo a stav "goldu" uzivatele i pocitace (oba zacinaji treba s 1000 goldu)
             * 
             * - uzivatel zada prvotni sazku, ktera musi byt maximalne tolik, kolik ma goldu
             * 
             * Opakuj dokud nepadne jednomu z hracu 1:
             * {
             *      Pokud je sude kolo:
             *      {
             *          - uzivatel zada hodnotu, kterou rolluje
             *          - kontroluj, ze uzivatel zadal spravnou hodnotu
             *          - uloz rollnute cislo
             *          - vypis uzivateli, co rollnul
             *      }
             *      Pokud je liche kolo:
             *      {
             *          - pocitac rollne nahodne cislo mezi 0 a aktualne rollovanym cislem
             *          - vypis uzivateli, co rollnul pocitac
             *      }
             * }
             * 
             * 
             * - posledni hrajici hrac prohral, protoze mu padla 1 a sazku bere druhy hrac
             * - vypis uzivateli kdo vyhral a stav goldu uzivatele i pocitace
             * 
             * ROZSIRENI:
             * - umozni uzivateli opakovat deathroll dokud ma nejake goldy
             */
            Random rnd = new Random();
            int compsGold = 1000;
            int usersGold = 1000;
            
            Console.WriteLine("navrhněte číslo");
            int sazka = Convert.ToInt32(Console.ReadLine());
            if (sazka > usersGold)
            {
                Console.WriteLine("vaše sázka může být maximálně váš gold" + usersGold);
            }

            int userHozeno;
            int compHozeno;
            do
            {
                userHozeno = rnd.Next(1, usersGold + 1);
                if (userHozeno != 1)
                {
                    Console.WriteLine("hodil jsi " + userHozeno);
                }
                else
                {
                    Console.WriteLine("prohrál jsi");
                    Console.WriteLine("konec hry, stav tvého goldu je: " + (usersGold - sazka) + " stav goldu pc je: " + (compsGold + sazka));
                }
                compHozeno = rnd.Next(1, userHozeno);
                if (compHozeno != 1)
                {
                    Console.WriteLine("počítač hodil " + compHozeno);
                }
                else
                {
                    Console.WriteLine("vyhrál jsi");
                    Console.WriteLine("konec hry, stav tvého goldu je: " + (usersGold + sazka) + " stav goldu pc je: " + (compsGold - sazka));
                }

            }


            while (userHozeno != 1 || compHozeno != 1);
            




            Console.ReadKey();


        }
    }
}
