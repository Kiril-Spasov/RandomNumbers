using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumbers
{
    public partial class FormRandomNumbers : Form
    {
        public FormRandomNumbers()
        {
            InitializeComponent();
        }


        //Write a program which determines how many times a toss of 100 coins
        //contains 47 heads if the experiment is performed 50 times.
        private void BtnCoinToss_Click(object sender, EventArgs e)
        {
            TxtText.Clear();
            Random r = new Random();

            int heads = 1;
            int toss;
            int headsCount = 0;
            int occurance = 0;

            for (int i = 1; i <= 50; i++)
            {
                headsCount = 0;

                for (int j = 1; j <= 100; j++)
                {
                    toss = r.Next(1, 3);
                    if (toss == 1)
                        headsCount++;
                }

                if (headsCount == 47)
                    occurance++;
            }

            TxtText.Text = "There were " + occurance + " occurances of 47 heads out of 100";
        }

        //Write a program which will simulate the tossing of 4 fair coins, 50 times.
        //Display the result of each toss of four on a separate line.
        //If exactly 3 heads occur on a given toss, follow the line with an asterisk (*).
        //Example of output:
        //HTTH
        //HHTH*
        //THTT
        //Count the number of times exactly 3 heads occur in the 50 tosses.
        private void Btn4CoinsToss_Click(object sender, EventArgs e)
        {
            TxtText.Clear();
            Random r = new Random();
            int toss;
            int headsCount;
            int count3Heads = 0;

            for (int i = 1; i <= 50; i++)
            {
                headsCount = 0;
                for (int j = 1; j <= 4; j++)
                {
                    toss = r.Next(1, 3);
                    if (toss == 1)
                    {
                        TxtText.Text += "H";
                        headsCount++;
                    }
                    else
                    {
                        TxtText.Text += "T";
                    }
                }

                if (headsCount == 3)
                {
                    TxtText.Text += "*";
                    count3Heads++;
                }
                    

                TxtText.Text += Environment.NewLine;
            }

            TxtText.Text += "There were 3 heads " + count3Heads + " times in 50 games.";
        }


        //Write a program that simulates 15 rolls of a die and then prints out the number of times
        //each number is generated.
        private void BtnDiceCounter_Click(object sender, EventArgs e)
        {
            TxtText.Clear();
            Random r = new Random();

            int toss;
            int[] numbersCounter = new int[7];

            for (int i = 1; i <= 15; i++)
            {
                toss = r.Next(1, 7);
                numbersCounter[toss] += 1;
            }

            for (int i = 1; i <= 6; i++)
            {
                TxtText.Text += i + " got tossed " + numbersCounter[i] + " times" + Environment.NewLine;
            }
        }

        //Write a program that simulates the roll of two die. Instead of printing the numbers
        //print the word representations of them and also the word representations of their sum.
        private void BtnDiceWordsGame_Click(object sender, EventArgs e)
        {
            TxtText.Clear();
            TxtText.Text = "Dice 1 \t Dice 2 \t Sum " + Environment.NewLine;
            Random r = new Random();
            int dice1, dice2;
            int sum;
            string[] wordsOfNumbers = new string[13]
            { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve"};


            for (int i = 1; i <= 2; i++)
            {
                sum = 0;
                dice1 = r.Next(1, 7);
                dice2 = r.Next(1, 7);
                sum = dice1 + dice2;

                TxtText.Text += wordsOfNumbers[dice1] + "\t" + wordsOfNumbers[dice2] + "\t" + wordsOfNumbers[sum] + Environment.NewLine;
            }
        }
    }
}
