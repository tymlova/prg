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
            int compHozeno;
            int userHozeno;
            while (compsGold > 0 || usersGold > 0) 
            { 
                Console.WriteLine("navrhněte číslo (může nybývat hodnoty maximálně vašeho goldu)");
                int sazka = Convert.ToInt32(Console.ReadLine());
                

            
           
                 userHozeno = rnd.Next(1, sazka + 1);
                 Console.WriteLine("hodil jsi: " + userHozeno);
                if (userHozeno ==1)
                {
                    Console.WriteLine("prohrál jsi");
                    compsGold = compsGold + sazka;
                    usersGold = usersGold - sazka;
                    break;
                
                }
                 compHozeno = rnd.Next(1, userHozeno + 1);
                 Console.WriteLine("počítač hodil: "+ compHozeno);
                if (compHozeno == 1)
                {
                    Console.WriteLine("vyhrál jsi");
                    compsGold = compsGold - sazka;
                    usersGold = usersGold + sazka;
                    break;
                }

                while (userHozeno != 1 || compHozeno != 1)
                {
                    userHozeno = rnd.Next(1, compHozeno + 1);
                    Console.WriteLine("hodil jsi: " + userHozeno);
                    if (userHozeno == 1)
                    {
                        Console.WriteLine("prohrál jsi");
                        compsGold = compsGold + sazka;
                        usersGold = usersGold - sazka;
                        break;
                    }
                    compHozeno = rnd.Next(1, userHozeno + 1);
                    Console.WriteLine("počítač hodil: " + compHozeno);
                    if (compHozeno == 1)
                    {
                        Console.WriteLine("Vyhrál jsi");
                        compsGold = compsGold - sazka;
                        usersGold = usersGold + sazka;
                        break;
                    }
                }

                Console.WriteLine("Stav goldu je - uživatel: " + usersGold + " počítač: " + compsGold);
                if (usersGold <= 0)
                {
                    Console.WriteLine("absolutní konec hry, jsi bez goldu a looser");
                    break;
                }
                if (compsGold <= 0)
                {
                    Console.WriteLine("absolutní konec hry, JSI VÍTĚZ");
                    break;
                }
                Console.ReadKey();
                sazka = rnd.Next(1, compsGold+1);
                Console.WriteLine("sázka počítače je:" + sazka);

                compHozeno = rnd.Next(1, sazka+1);
                Console.WriteLine("počítač hodil: " + compHozeno);
                if (compHozeno == 1)
                {
                    Console.WriteLine("vyhrál jsi ");
                    compsGold = compsGold - sazka;
                    usersGold = usersGold + sazka;
                    break;
                }

                userHozeno = rnd.Next(1, compHozeno + 1);
                Console.WriteLine("hodil jsi: " + userHozeno);
                if (userHozeno == 1)
                {
                    Console.WriteLine("prohrál jsi");
                    compsGold = compsGold + sazka;
                    usersGold = usersGold - sazka;
                    break;

                }

                while (userHozeno != 1 || compHozeno != 1)
                {
                    
                    compHozeno = rnd.Next(1, userHozeno + 1);
                    Console.WriteLine("počítač hodil: " + compHozeno);
                    if (compHozeno == 1)
                    {
                        Console.WriteLine("Vyhrál jsi");
                        compsGold = compsGold - sazka;
                        usersGold = usersGold + sazka;
                        break;
                    }
                    userHozeno = rnd.Next(1, compHozeno + 1);
                    Console.WriteLine("hodil jsi: " + userHozeno);
                    if (userHozeno == 1)
                    {
                        Console.WriteLine("prohrál jsi");
                        compsGold = compsGold + sazka;
                        usersGold = usersGold - sazka;
                        break;
                    }
                }
                Console.WriteLine("Stav goldu je - uživatel: " + usersGold + " počítač: " + compsGold);
                if (usersGold <= 0)
                {
                    Console.WriteLine("absolutní konec hry, jsi bez goldu a looser");
                    break;
                }
                if (compsGold <= 0)
                {
                    Console.WriteLine("absolutní konec hry, JSI VÍTĚZ");
                    break;
                }

            }
            
            Console.ReadKey();


        }
    }
}
