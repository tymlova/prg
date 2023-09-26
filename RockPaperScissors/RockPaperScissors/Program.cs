using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jednoduchy program na procviceni podminek a cyklu.
             * 
             * Vytvor program, kde bude uzivatel hrat s pocitacem kamen-nuzky-papir.
             * 
             * Struktura:
             * 
             * - nadefinuj promenne, ktere budes potrebovat po celou dobu hry, tedy skore obou
             *
             * Opakuj tolikrat, kolik kol chces hrat:
             * {
             *      Dokud uzivatel nezada vstup spravne:
             *      {
             *          - nacitej vstup od uzivatele
             *      }
             *      
             *      - vygeneruj s pomoci rng.Next() nahodny vstup pocitace
             *      
             *      Pokud vyhral uzivatel:
             *      {
             *          - informuj uzivatele, ze vyhral kolo
             *          - zvys skore uzivateli o 1
             *      }
             *      Pokud vyhral pocitac:
             *      {
             *          - informuj uzivatele, ze prohral kolo
             *          - zvys skore pocitaci o 1
             *      }
             *      Pokud byla remiza:
             *      {
             *          - informuj uzivatele, ze doslo k remize
             *      }
             * }
             * 
             * - informuj uzivatele, jake mel skore on/a a pocitac a kdo vyhral.
             */
            Random rnd = new Random(); //instance tridy Random pro generovani nahodnych cisel
            Console.WriteLine("zadejte kolik kol chcete hrát");
            int pocetKol = Convert.ToInt32(Console.ReadLine());
            int usersScore = 0;
            int compsScore = 0;
            for (int i = 0; i <= pocetKol; i++) 
                {
                
                
                Console.WriteLine("zadejte číslo podle toho jestli chcete hrát kámen - 1, nůžky - 2, papír - 3");
                    int usersGame = Convert.ToInt32(Console.ReadLine()); //tah hráče
                    int compsGame = rnd.Next(1, 4); //vygenerování tahu počítače
                    if (compsGame > usersGame)
                    {
                        compsScore++;
                        Console.WriteLine("prohrál jsi");
                    }
                    else if (compsGame < usersGame)
                    {
                        usersScore++;
                        Console.WriteLine("vyhrál jsi");
                    }
                    else
                    {
                        Console.WriteLine("remíza");
                    }
                }
            if (usersScore > compsScore)
            {
                Console.WriteLine("Vyhrál jsi " + usersScore + " : " + compsScore);   
            }
            else if (usersScore < compsScore)
            { 
                Console.WriteLine("Prohrál jsi " + usersScore + " : " + compsScore);
            }
            else
            {
                Console.WriteLine("remíza " + usersScore + " : " + compsScore);
            }
            Console.ReadKey(); //Aby se nam to hnedka neukoncilo
        }
    }
}
