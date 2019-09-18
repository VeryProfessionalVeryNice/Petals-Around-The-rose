using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Petals
{
    class DieD6 : PictureBox
    {
        /// <summary>
        /// Practice class from lecture, not really utilized in the functionality
        /// </summary>
        private int pips;
        private int pipValue;

        public int Pips { get => pips; set => pips = value; }
        public int PipValue { get => pipValue; set => pipValue = value; }

        
        public int[] rollDice() {

                    int minRand = 1;
                    int maxRand = 6;

                    int[] diceRolls = new int[6];
                    Random randNum = new Random();
                    foreach (int item in diceRolls)
                    {
              
                        randNum.Next(minRand, maxRand);
                    }
                    return diceRolls;
        }

        
    }
}
