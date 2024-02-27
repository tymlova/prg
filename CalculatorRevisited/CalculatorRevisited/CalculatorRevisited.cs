using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Dnes bude vasim ukolem vytvorit formularovou reprezentaci kalkulacky. Priblizny vzhled si nakreslime na tabuli
 * (Pokud jsem to nenakreslil, pripomente mi to prosim!)
 * Inspirujte se kalkulackou ve Windows.
 * Pozadovane prvky/funkcionality:
 * - Tlacitka pro kazde z cisel 0-9
 * - Tlacitka pro operace +, -, *, a /
 * - Tlacitko pro = (vypsani vysledku)
 * - Textbox, do ktereho se propisou cisla/operace pri stisku jejich tlacitek
 * - Textbox s vysledkem operace (mozne sloucit s predeslym, nechavam na vas)
 * - Tlacitko pro vymazani textu v textboxu s cisly a operaci
 * 
 * Volitelne prvky/funkcionality:
 * - Tlacitko pro mazani cisel a operaci v textboxu zprava vzdy po jednom znaku
 * - Pokud mam vypsany vysledek a hned po tom stisknu tlacitko nejake operace, vysledek se vezme jako prvni cislo a
 *   rovnou mohu po zadani operace zadat druhe cislo
 * - Moznost ulozeni vysledku do nekolika preddefinovanych labelu/neinteraktivnich textboxu (treba kombinaci comboboxu a tlacitka, kde
 *   v comboboxu vyberu do ktereho labelu/textboxu se mi to ulozi a tlacitkem provedu ulozeni)
 *   + pridat tlacitko pro kazdy label/neint. textbox, kterym ulozeny vysledek pouziju jako cislo do vypoctu
 * - Pridani mocnin/odmocnin atd. (napr. pomoci dalsich tlacitek, ktere rovnou misto daneho cisla daji jeho (popr. zaokrouhlenou) odmocninu apod.)
 * - Cokoliv dalsiho vas napadne! :)
 * 
 * Snazte se o to, aby byla kalkulacka v ramci moznosti hezka, a aby bylo jeji ovladani intuitivni a aby mel kazdy prvek v okne dobre vyuziti
 */

namespace CalculatorRevisited
{
    public partial class CalculatorRevisited : Form
    {
        double number = 0;
        char operation;
        double result;
        public CalculatorRevisited()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxWrite.Text == "0" && textBoxWrite.Text != null)
            {
                textBoxWrite.Text = "1";
            }
            else
            {
                textBoxWrite.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxWrite.Text == "0" && textBoxWrite.Text != null)
            {
                textBoxWrite.Text = "2";
            }
            else
            {
                textBoxWrite.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxWrite.Text == "0" && textBoxWrite.Text != null)
            {
                textBoxWrite.Text = "3";
            }
            else
            {
                textBoxWrite.Text += "3";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxWrite.Text == "0" && textBoxWrite.Text != null)
            {
                textBoxWrite.Text = "4";
            }
            else
            {
                textBoxWrite.Text += "4";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxWrite.Text == "0" && textBoxWrite.Text != null)
            {
                textBoxWrite.Text = "5";
            }
            else
            {
                textBoxWrite.Text += "5";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxWrite.Text == "0" && textBoxWrite.Text != null)
            {
                textBoxWrite.Text = "6";
            }
            else
            {
                textBoxWrite.Text += "6";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxWrite.Text == "0" && textBoxWrite.Text != null)
            {
                textBoxWrite.Text = "7";
            }
            else
            {
                textBoxWrite.Text += "7";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxWrite.Text == "0" && textBoxWrite.Text != null)
            {
                textBoxWrite.Text = "8";
            }
            else
            {
                textBoxWrite.Text += "8";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxWrite.Text == "0" && textBoxWrite.Text != null)
            {
                textBoxWrite.Text = "9";
            }
            else
            {
                textBoxWrite.Text += "9";
            }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxWrite.ResetText();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxWrite.Text += 0;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            
            textBoxWrite.Text += '+';
            operation = '+';
            
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {

            string text = textBoxWrite.Text;
            string[] numbers = text.Split('+');
            double number1 = Convert.ToDouble(numbers[0]);
            int number2 = Convert.ToInt32(numbers[1]);
            switch (operation)
            {
                default:
                    break;
            }
            result = number1 + number2;
            textBoxWrite.ResetText();
            textBoxWrite.Text = result.ToString();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBoxWrite.Text += '-';
            operation = '-';
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            textBoxWrite.Text += '*';
            operation = '*';
        }

        private void buttonDividing_Click(object sender, EventArgs e)
        {
            textBoxWrite.Text += '/';
            operation = '/';
        }
    }
}
