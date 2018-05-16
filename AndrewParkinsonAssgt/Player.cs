using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewParkinsonAssgt
{
    public class Player
    {

        // This property is the player's score
        private int iScore = 0;

        // Function to set or get current score
        public int GetCurrentScore
        {
            get { return iScore; }
            set { iScore = value; }
        }

        // function to add the Lurgit score, defined by the public const var 
        public void AddLurgitBonus()
        {
            iScore += frmGame.iLurgitScore;
        }

        // function to add the Sequence score, defined by the public const var 
        public void AddSequenceBonus()
        {
            iScore += frmGame.iSeqScore;
        }

        public void AddScore(int score)
        {
            iScore += score;
        }


        // This property is the player's name and will be displayed
        // at the top of the Game form
        private String sName;

        public String GetName
        {
            get { return sName; }

        }

        //=============================================
        // Reference 7: externally sourced assistance
        // Purpose: Setter not running
        // Date: 6 May 2018
        // Source: stack overflow
        // URL: https://stackoverflow.com/questions/14947309/c-sharp-object-setter-not-called-when-member-is-modified
        //=============================================
        public void SetName(String name)
        {
            // If the entered name is blank
            if (String.IsNullOrEmpty(name))
            {
                // Default player name + player number
                sName = "Player " + frmGame.iPlayer;

                // Increment iPlayer for Player 2
                // Note: even though iPlayer is public static, this class treats iPlayer as a separate int
                frmGame.iPlayer++;
            }
            else
            {
                // Else Name is eq whatever was entered on the menu form
                sName = name;
            }
        }



    }
}
