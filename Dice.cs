using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petals
{
    class Dice
    {
        private int faceValue;
        private int pointValue;

        //setting up Dice with points and faces, no arg
        public Dice() {
            pointValue = 0;
            faceValue = 0;
        }

        // two arg constructor
        public Dice(int rollPoints, int rollFaceValue) {
            pointValue = rollPoints;
            faceValue = rollFaceValue;
        }

        //Dice points var
        public int PointValue
        {
            get
            { return pointValue; }
            set
            {pointValue = value;}
        }
        //dice face value var
        public int FaceValue {
            get {  return faceValue; }
            set { faceValue = value; }
           }

       
        
    }
}
