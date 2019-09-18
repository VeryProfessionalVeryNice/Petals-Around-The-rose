using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Written by Andrew Miller
/// Last updated 4 September 2019
/// Petals Around The Rose
/// CIS 151 102
/// Professor Riley
/// Provides a graphical interface for users to play petals around the rose to try to discover the secret of the rose. Users must play nice, no exceptions!
/// </summary>
/// 
namespace Petals
{
    public partial class Petals : Form
    { 
        //Set up class variables
        int currentRoll;
        int totalRolls = 0;
        int rollPoints = 0;
        int bestRun = 0;
        int currentRun;
        int intCorrect;
        int totalRuns;
        int wrongGuesses;
        int minRand = 1;
        int maxRand = 5;
        /// <summary>
        //Use Instance of random class to prepare random array
        /// </summary>
        int[] diceRolls = new int[5];
        Dice[] rollDice = new Dice[5];
        Random randNum = new Random();

        public Petals()
        {
            InitializeComponent();
            for (int i = 0; i < maxRand; i++)
            {
                rollDice[i] = new Dice();
            }
        }
        //Put in a 99 so they don't leave blank or guess default 0 and get it right accidentally
        private void Form1_Load(object sender, EventArgs e)
        {
            guessTxtBx.Text = "99";
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            //Rolling Dice Button Functionality
            totalRolls++;
            LossTextBox(wrongGuesses);
            //loop through each dice roll and score individually
            for (int i = 0; i < 5; i++)
            {
                currentRoll = randNum.Next(minRand, maxRand);
                rollDice[i].FaceValue = currentRoll;
                //count points for the roll
                if (rollDice[i].FaceValue == 3)
                {
                    rollDice[i].PointValue = 2;
                }

                if (rollDice[i].FaceValue == 5)
                {
                    rollDice[i].PointValue = 4;
                }
                if (rollDice[i].FaceValue == 1 || rollDice[i].FaceValue == 2 || rollDice[i].FaceValue == 4 || rollDice[i].FaceValue == 6)
                {
                    rollDice[i].PointValue = 0;
                }

                rollPoints += rollDice[i].PointValue;
                SetDieFace(i);
                WriteRollsToBoxes(rollDice[i].FaceValue, i);
                UpdateTextBoxes(totalRolls, currentRun, bestRun);
                lblGameStatus.Text = "";
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            CheckIfCorrect(rollPoints);
        }

        public void CheckIfCorrect(int rolPoint)
        {
            int intGuess = 99;
            intGuess = int.Parse(guessTxtBx.Text);
            if (rolPoint == intGuess)
            {
                currentRun++;
                UpdateTextBoxes(currentRun, bestRun);
                lblGameStatus.Text = "You got it!";

            }
            else
            {
                currentRun = 0;
                wrongGuesses++;
                UpdateTextBoxes(currentRun, bestRun);
                LossTextBox(wrongGuesses);
                lblGameStatus.Text = "Sorry.";
            }

        }
        public void UpdateTextBoxes(int totRoll, int numCor, int bestRun)
        {
            totalRollsTxtBx.Text = totRoll.ToString();
            numberCorrectTxtBx.Text = numCor.ToString();
            bestRunTxtBx.Text = bestRun.ToString();
        }
        public void UpdateTextBoxes(int numCor, int bestRunInt)
        {
            numberCorrectTxtBx.Text = numCor.ToString();
            if (numCor >= bestRunInt)
            {
                bestRunTxtBx.Text = numCor.ToString();
                bestRun = numCor;
            }
        }

        public void LossTextBox(int lossesInt)
        {
            numberIncorrectTxtBx.Text = lossesInt.ToString();
        }

        public void WriteRollsToBoxes(int f, int i)
        {
            if (i == 0)
            {
                dieOneTxtBox.Text = f.ToString();
            }
            if (i == 1)
            {
                dieTwoTxtBox.Text = f.ToString();
            }
            if (i == 2)
            {
                dieThreeTxtBox.Text = f.ToString();
            }
            if (i == 3)
            {
                dieFourTxtBox.Text = f.ToString();
            }
            if (i == 4)
            {
                dieFiveTxtBox.Text = f.ToString();
            }

        }

        // Die Image
        public void SetDieFace(int i)
        {
            switch (i)
            {
                case 0:
                    pictureBox1.Image = imageList1.Images[  (rollDice[i].FaceValue - 1)   ];
                    break;
                case 1:
                    pictureBox2.Image = imageList1.Images[(rollDice[i].FaceValue - 1)];
                    break;
                case 2:
                    pictureBox3.Image = imageList1.Images[(rollDice[i].FaceValue - 1)];
                    break;
                case 3:
                    pictureBox4.Image = imageList1.Images[(rollDice[i].FaceValue - 1)];
                    break;
                case 4:
                    pictureBox5.Image = imageList1.Images[(rollDice[i].FaceValue - 1)];
                    break;
                default:
                    pictureBox5.Image = imageList1.Images[(rollDice[i].FaceValue - 1)];
                    break;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
