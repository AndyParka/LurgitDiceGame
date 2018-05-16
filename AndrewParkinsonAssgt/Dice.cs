using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndrewParkinsonAssgt
{
    class Dice
    {

        //============================================= 
        // Reference 1: Externally sourced assistance
        // Purpose: Get and Set variables for each class
        // Date: 21-Apr-18
        // Source: Microsoft C# Documentation
        // Author: Microsoft
        // URL: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-properties
        //============================================= 
        // property to determine the Hold state of each Dice object
        // this will be called 
        private Boolean bHold;

        // Function to check hold status of die
        public Boolean IsHold
        {
            get { return bHold; }
            set { bHold = false; }
        }

        // Function to toggle the hold status of die
        // To be used with hold buttons on UI
        public Boolean HoldToggle()
        {
            bHold = !bHold;
            return bHold;
        }

        //Allows code to explicitly set a picture box control on the UI to a dice object
        public PictureBox CurrentPicbox { set; get; }

        // This property is the value shown on the die face
        private int iDieValue;

        // Get's the current number on the Die
        public int GetValue
        {
            get { return iDieValue; }
            set
            {
                // Check that value is between 0-6
                if (value > 0 && value < 7)
                { iDieValue = value; }
                else { iDieValue = 1; }
            }
        }

        //This function was cut and moved to RollRandom()

        //public int Roll()
        //{
        //    //============================================= 
        //    // Reference:8
        //    // Purpose: Random int
        //    // Date: 6/5/18
        //    // Source: stack overflow
        //    // Author: Guffa
        //    // URL: https://stackoverflow.com/questions/2706500/how-do-i-generate-a-random-int-number-in-c
        //    //============================================= 

        //    Random rDie = new Random();
        //    iDieValue = rDie.Next(1, 8);

        //    return iDieValue;
        //}
    }
}
