using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace AndrewParkinsonAssgt
{
    public partial class frmGame : Form
    {
        // Constant score integers for use to calculate score.
        // if these scores need to be tweaked, you can do it here.

        // Points received on a Lurgit bonus roll
        public const int iLurgitScore = 10;
        public Boolean isLurgit = false;

        // Points received on a Sequence bonus roll
        public const int iSeqScore = 10;
        public Boolean isSequenceTriggered = false;

        // variable to keep track of current round
        public int iRound = 0;
        // variable to set the amount of rounds
        public const int iRoundMax = 6;

        // variable to keep track of current player's roll
        public int iRoll = 0;
        // variable to set the amount of rolls allowed per player round
        public const int iRollMax = 3;

        // variable to keep track of whether player1 or player2
        public static int iPlayer = 1;

        // Public player objects
        public static Player P1 = new Player();
        public static Player P2 = new Player();

        // variables to keep track of game wins
        public int iP1wins = 0;
        public int iP2wins = 0;

        // Game Mode variable
        //Game Modes:
        //0 = Solo
        //1 = Player VS CPU
        //2 = Player VS Player
        public static int iGameMode;

        // This function creates the access the Dice array
        Dice[] arrDice = new Dice[3];

        //Helper functions
        Dice Die1() { return arrDice[0]; }
        Dice Die2() { return arrDice[1]; }
        Dice Die3() { return arrDice[2]; }


        // This is the first function hit, this handles drawing the form and running the overall game board.
        public frmGame(int intGameMode, String sP1Name, String sP2Name)
        {
            // auto-generated stuff
            InitializeComponent();

            // This first if statement is to 
            // test to make sure a valid game mode has been selected
            // if game mode is not 0, 1 or 2
            // display an error and dispose
            // this code should never be run
            if (intGameMode < 0 || intGameMode > 2)
            {
                MessageBox.Show("Invalid Game Mode Selected");
                this.Dispose();
            }


            // This function moves intGameMode into the Public var iGameMode for further use
            iGameMode = intGameMode;

            // This function takes intGameMode and sets up the game form ready for the selected game mode
            SessionStart(sP1Name, sP2Name);

            // This function start's the round
            RoundStart();
        }

        void SessionStart(String sP1Name, String sP2Name)
        {

            //This function accepts the intGameMode var which is used
            //to determine the game mode to initialize and play

            // Init first player
            Player player1 = new Player();

            // Set Player name
            player1.SetName(sP1Name);

            // Copy initialized object to public space
            P1 = player1;

            // Set UI Name label
            lblP1Name.Text = P1.GetName;
            lblCurrentPlayer.Text = P1.GetName;

            //The following IF statement changes how the game form is loaded
            //based on the selected game mode from menu form
            //If game mode is not SOLO
            if (iGameMode != 0)
            {
                // Init second player
                Player player2 = new Player();
                player2.SetName(sP2Name);
                P2 = player2;

                // Set UI Name label
                lblP2Name.Text = P2.GetName;

            }
            else
            {

                //Remove Player 2 UI score elements
                lblP2Name.Visible = false;
                lblP2Score.Visible = false;
                lblP2ScoreLabel.Visible = false;
            }

            //Make sure iPlayer starts at 1
            iPlayer = 1;

            // Set the Maximum Roll and Round total numbers from config
            lblRollTotal.Text = "/ " + iRollMax.ToString();
            lblRoundTotal.Text = "/ " + iRoundMax.ToString();

            // Update current Round and Roll numbers on bottom right tracker
            lblRollNo.Text = iRoll.ToString();
            lblRoundNo.Text = iRound.ToString();
        }

        void RoundStart()
        {
            // if it is player 1's turn again, or there is only 1 player
            //increment the round
            if (iPlayer == 1 || iGameMode == 0)
            {
                //increment round number
                iRound++;

                //Fix to stop "Round 0" output
                if (iRound != 0)
                {
                    //log new round
                    Log("================");
                    Log("Round " + iRound);

                }
                //Let player1 know that it's their turn
                Log("================");
                Log(P1.GetName + " - Your Turn");
                Log("================");

                //Change background color to P1's color
                gbPlayer.BackColor = Color.Azure;

                //Change the Top Left player name label
                lblCurrentPlayer.Text = P1.GetName;
            }
            else
            {
                //Let player2 know that it's their turn
                Log("================");
                Log(P2.GetName + " - Your Turn");
                Log("================");

                //Change background color to P1's color
                gbPlayer.BackColor = Color.FloralWhite;

                //Change the Top Left player name label
                lblCurrentPlayer.Text = P2.GetName;
            }

            // Disable hold buttons before first roll
            UIHoldDisable();


            //Clear the dice on the board for next round
            DiceReset();

            //Reset sequence bonus availability
            isSequenceTriggered = false;

            //Update UI
            UIUpdate();

            //Run AI to auto roll, else wait for player to press ROLL button
            AIMain();

        }

        void RollStart()
        {
            //Increment Roll number
            iRoll++;

            //Log Roll
            Log(GetPlayer().GetName + " - Roll " + iRoll);

            //Update the UI
            UIUpdate();

            // Disable user input
            UIDisable();

            for (int i = 0; i < arrDice.Length; i++)
            {
                //Check if dice is held, don't roll if true
                if (!arrDice[i].IsHold)
                {
                    //Randomize dice output and play animation while rolling

                    RollRandom(arrDice[i].CurrentPicbox);
                    Sleep(100);
                    RollRandom(arrDice[i].CurrentPicbox);
                    Sleep(500);
                    RollRandom(arrDice[i].CurrentPicbox);
                    Sleep(1000);

                    //Set the final random roll to be the value of the currently selected Dice
                    arrDice[i].GetValue = RollRandom(arrDice[i].CurrentPicbox);
                    Sleep(1200);

                }
            }

            //Check to see if Lugit was rolled
            CheckLurgit();

            //Check to see if Seq bonus was rolled
            //takes true, adds bonus points automatically if successful
            CheckSequence(true);

            //ENable the UI for players to hold and roll
            UIEnable();

            //Enable the Hold Buttons if disabled
            UIHoldEnable();

            //Reset the .IsHold property on all dice
            HoldReset();

            //Update UI changes
            UIUpdate();

            //Check to see if that was the last roll
            if (iRoll == iRollMax)
            {
                //If it was
                //End the round
                RoundEnd();

            }
        }

        void RoundEnd()
        {
            //Calculates final round score from dice (not including bonuses)
            //Assigns to temp int
            int iScore = GetScore();

            //Add score from round to player's total score
            GetPlayer().AddScore(iScore);

            //Let the players know of the new points
            Log(GetPlayer().GetName + " - Gained " + iScore + " Round Points");

            //Update UI changes
            UIUpdate();

            //check to see if the game is ready to finish
            //if last round and second player
            if (iRound == iRoundMax && iPlayer == 2)
            {
                GameEnd();
            }
            //else if last round and game mode Solo
            else if (iRound == iRoundMax && iGameMode == 0)
            {
                GameEnd();
            }
            //Else continue as usual and..
            else
            {

                // Increment Player
                NextPlayer();

                //Disable the Hold ability on first roll
                UIHoldDisable();

                //Start next round
                RoundStart();
            }
        }

        void GameEnd()
        {
            // This switch statement handles the end of the game, 
            // displaying different messages depending on different game mode and outcomes.
            switch (iGameMode)
            {
                case 0:
                    //Output score
                    MessageBox.Show("Congratulations, your score is: " + P1.GetCurrentScore);
                    break;
                case 1:
                    if (P1.GetCurrentScore > P2.GetCurrentScore)
                    {
                        MessageBox.Show("Congratulations " + P1.GetName + ", your score is: " + P1.GetCurrentScore);
                    }
                    else
                    {
                        MessageBox.Show("Too bad " + P1.GetName + ", You lose.\nYour score is: " + P1.GetCurrentScore + "\nCPU score is: " + P2.GetCurrentScore);
                    }
                    break;
                case 2:
                    if (P1.GetCurrentScore > P2.GetCurrentScore)
                    {
                        MessageBox.Show("Congratulations " + P1.GetName + ", your score is: " + P1.GetCurrentScore);
                    }
                    else
                    {
                        MessageBox.Show("Congratulations " + P1.GetName + ", your score is: " + P1.GetCurrentScore);
                    }
                    break;
            }

            //Ask Players if it's 
            GameReset();
        }

        void HoldReset()
        {
            //Reset's dice hold values to not held
            for (int i = 0; i < arrDice.Length; i++)
            {
                arrDice[i].IsHold = false;
            }
        }

        void UIReset()
        {

            //Reset Dice
            ClearPic(pbxDice1);
            ClearPic(pbxDice2);
            ClearPic(pbxDice3);

            UIUpdate();
        }

        // Function to update the UI, to be used every roll
        void UIUpdate()
        {
            //Update UI with score
            lblP1Score.Text = P1.GetCurrentScore.ToString();
            lblP2Score.Text = P2.GetCurrentScore.ToString();

            // Bottom right text
            lblRollNo.Text = iRoll.ToString();
            lblRoundNo.Text = iRound.ToString();

            //Update all the things
            lblP1Score.Update();
            lblP2Score.Update();
            lblRollNo.Update();
            lblRoundNo.Update();
            lbLog.Update();
        }

        // Function to disable UI during animated sections
        void UIDisable()
        {
            UIHoldDisable();
            btnRoll.Enabled = false;
            btnEndTurn.Enabled = false;
        }

        void UIEnable()
        {
            UIHoldEnable();
            btnRoll.Enabled = true;
            btnEndTurn.Enabled = true;

        }

        void UIHoldDisable()
        {
            btnHoldP1D1.Enabled = false;
            btnHoldP1D2.Enabled = false;
            btnHoldP1D3.Enabled = false;

        }

        void UIHoldEnable()
        {
            btnHoldP1D1.Enabled = true;
            btnHoldP1D2.Enabled = true;
            btnHoldP1D3.Enabled = true;

        }


        // Simple function to determine the currently active player on shared functions
        Player GetPlayer()
        {
            if (iGameMode == 0)
            {
                return P1;
            }

            if (iPlayer == 2)
            {
                return P2;
            }
            else
            {
                return P1;
            }
        }

        // Simple function to check if a lurgit has been rolled
        void CheckLurgit()
        {
            if (Die1().IsHold || Die2().IsHold || Die3().IsHold)
            {
                //Couldn't figure out how to reverse this statement
                //Code get's here if any dice is held and does not let a lurgit bonus run
            }
            else
            {

                // Check if current round is same as d1
                if (iRound == Die1().GetValue)
                {
                    // if d2 and d3 are eq to d1, Lurgit
                    if (Die1().GetValue == Die2().GetValue && Die2().GetValue == Die3().GetValue)
                    {
                        //Log lurgit
                        Log(GetPlayer().GetName + " - Lurgit!! +" + iLurgitScore + " Bonus Points");

                        //Add lurgit bonus to score
                        GetPlayer().AddLurgitBonus();

                        // Show message box and end round
                        MessageBox.Show("Lurgit!!");

                        RoundEnd();
                    }
                }
            }
        }


        // Function to check if a sequence bonus has been rolled
        // return as a bool to track later
        int CheckSequence(bool Bonus)
        {
            //Takes Bonus bool, if bool is true, adds the sequence bonus score
            //otherwise just returns a true or false for the AI

            //This int is to be returned when called by AI, to figure out how many dice are in sequence
            // 0 = bad
            // 2 = OK
            // 3 = pretty good
            int noInSequence = 0;

            //Check that the player isn't cheating by holding 3 dice
            if (Die1().IsHold && Die2().IsHold && Die3().IsHold)
            {
                //Honestly couldn't figure out how to reverse this statement
                //Code get's here if all 3 dice are held and does not let the sequence bonus check run
                return 0;
            }
            else
            {

                //=============================================
                // Reference 3: externally sourced assistance
                // Purpose: array sorting
                // Date: 2 May 2018
                // Source: dotnetperls
                // URL: https://www.dotnetperls.com/sort
                //=============================================

                // Create new array for the dice values to be sorted

                int[] iDice = new int[3];
                for (int i = 0; i < arrDice.Length; i++)
                {
                    iDice[i] = arrDice[i].GetValue;
                }

                // sort array in numerical order
                Array.Sort(iDice);

                //=============================================
                // End reference 3
                //=============================================


                // create array to compare arDice against
                // This contains numbers 1 - 6 as a sequence
                // so that the sorted sequence of dice can be 
                // checked against easily
                int[] iSequenceCompare = new int[6]
                {
                    1,2,3,4,5,6
                };

                //Test the dice's values against the iSequenceCompare sequence

                for (int i = 0; i < iSequenceCompare.Length; i++)
                {
                    //Loop through the arCompare array 
                    //if the first number in the dice sequence is eq to a number in the arCompare,
                    // this will continue to check if the following values are in sequence

                    // Added <=4 test to make sure array doesn't overflow
                    if (iDice[0] == iSequenceCompare[i] && iSequenceCompare[i] <= 4)
                    {
                        if (iDice[1] == iSequenceCompare[i + 1])
                        {
                            if (iDice[2] == iSequenceCompare[i + 2])
                            {
                                if (Bonus)
                                {
                                    //Log bonus
                                    Log(GetPlayer().GetName + " - Sequence Bonus! +" + iSeqScore + " Bonus Points");

                                    //Add sequence bonus to player score
                                    GetPlayer().AddSequenceBonus();
                                }

                                //Tells AI that 3 numbers are in sequence
                                noInSequence = 3;

                            }

                            //Tells AI that 2 numbers are in sequence
                            noInSequence = 2;
                        }
                    }
                }

                return noInSequence;
            }
        }


        //Calculates the score based on dice values and returns as int
        int GetScore()
        {
            //Temp int for storing the round score
            int iScore = 0;

            //Calculates round ending score
            for (int i = 0; i < arrDice.Length; i++)
            {
                //If the Dice eq round number
                if (arrDice[i].GetValue == iRound)
                {
                    //Add score to total
                    iScore += iRound;
                }
            }

            return iScore;
        }

        void Log(String input)
        {
            //Adds test to the list box
            lbLog.Items.Insert(0, input);
        }

        // Increment iPlayer
        public void NextPlayer()
        {
            if (iGameMode != 0)
            {
                if (iPlayer == 2)
                {
                    iPlayer = 1;
                }
                else
                {
                    iPlayer = 2;
                }
            }

            //reset iRoll back to 0 for next player
            iRoll = 0;
        }

        //Simple function to make Sleep look neater in the game code
        private void Sleep(int length)
        {
            System.Threading.Thread.Sleep(length);
        }

        //Function to perform CPU's turn
        private void AIMain()
        {
            //if Game mode is Player vs CPU
            if (iGameMode == 1 && iPlayer == 2)
            {
                //Start the CPU first roll
                RollStart();

                //Checks the currently rolled dice
                AICheckDice();

            }
        }

        // Main AI function to have it's turn
        private void AICheckDice()
        {

            //if all 3 values are the same (but it's the second or third roll and one of the dice was held from previous round)
            if (iRound == Die1().GetValue && iRound == Die2().GetValue && iRound == Die3().GetValue)
            {
                //End the round because that's a pretty good score, even though there may be a chance of a lurgit or sequence bonus next round
                RoundEnd();
            }
            //If 2 of the dice match the round number
            else if (iRound == Die1().GetValue && iRound == Die2().GetValue || iRound == Die1().GetValue && iRound == Die3().GetValue || iRound == Die3().GetValue && iRound == Die2().GetValue)
            {
                //if it's round 3 - 6 (3 to 6 because higher score potential)
                //or if it's not the first roll
                if (iRound > 2 || iRoll > 2)
                {
                    //Hold the dice that are eq to round
                    if (iRound == Die1().GetValue)
                    {
                        Die1().HoldToggle();
                    }
                    if (iRound == Die2().GetValue)
                    {
                        Die2().HoldToggle();
                    }
                    if (iRound == Die3().GetValue)
                    {
                        Die3().HoldToggle();
                    }
                }
            }
            else if (iRound == Die1().GetValue)
            {
                //if it's round 3 - 6 (3 to 6 because higher score potential)
                //or if it's not the first roll
                if (iRound > 2 || iRoll > 2)
                {
                    Die1().HoldToggle();
                }
            }
            else if (iRound == Die2().GetValue)
            {
                //if it's round 3 - 6 (3 to 6 because higher score potential)
                //or if it's not the first roll
                if (iRound > 2 || iRoll > 2)
                {
                    Die1().HoldToggle();
                }
            }
            else if (iRound == Die3().GetValue)
            {
                //if it's round 3 - 6 (3 to 6 because higher score potential)
                //or if it's not the first roll
                if (iRound > 2 || iRoll > 2)
                {
                    Die1().HoldToggle();
                }
            }

        }

        //============================================= 
        // Reference : externally sourced code 
        // Purpose: Draw dice 
        // Date: 5 May 2018 
        // Source: Week 4 Tutorials 
        // Author: Simon and/or Kellie
        // Adaptation required: changed variable names and removed unneeded code 
        //=============================================
        //Dice draw functions

        private void DrawD1(PictureBox pbxDice)
        {
            ClearPic(pbxDice);
            Graphics graPaper = pbxDice.CreateGraphics();
            graPaper.FillRectangle(Brushes.White, 0, 0, 100, 100);

            graPaper.FillEllipse(Brushes.Black, 50, 50, 10, 10);

        }
        private void DrawD2(PictureBox pbxDice)
        {
            ClearPic(pbxDice);
            Graphics graPaper = pbxDice.CreateGraphics();
            graPaper.FillRectangle(Brushes.White, 0, 0, 100, 100);

            graPaper.FillEllipse(Brushes.Black, 25, 25, 10, 10);
            graPaper.FillEllipse(Brushes.Black, 75, 75, 10, 10);
            ;
        }
        private void DrawD3(PictureBox pbxDice)
        {
            ClearPic(pbxDice);
            Graphics graPaper = pbxDice.CreateGraphics();
            graPaper.FillRectangle(Brushes.White, 0, 0, 100, 100);

            graPaper.FillEllipse(Brushes.Black, 25, 25, 10, 10);
            graPaper.FillEllipse(Brushes.Black, 50, 50, 10, 10);
            graPaper.FillEllipse(Brushes.Black, 75, 75, 10, 10);

        }
        private void DrawD4(PictureBox pbxDice)
        {
            ClearPic(pbxDice);
            Graphics graPaper = pbxDice.CreateGraphics();
            graPaper.FillRectangle(Brushes.White, 0, 0, 100, 100);

            graPaper.FillEllipse(Brushes.Black, 25, 25, 10, 10);
            graPaper.FillEllipse(Brushes.Black, 25, 75, 10, 10);
            graPaper.FillEllipse(Brushes.Black, 75, 75, 10, 10);
            graPaper.FillEllipse(Brushes.Black, 75, 25, 10, 10);

        }
        private void DrawD5(PictureBox pbxDice)
        {
            ClearPic(pbxDice);
            Graphics graPaper = pbxDice.CreateGraphics();
            graPaper.FillRectangle(Brushes.White, 0, 0, 100, 100);

            graPaper.FillEllipse(Brushes.Black, 25, 25, 10, 10);
            graPaper.FillEllipse(Brushes.Black, 25, 75, 10, 10);
            graPaper.FillEllipse(Brushes.Black, 75, 75, 10, 10);
            graPaper.FillEllipse(Brushes.Black, 75, 25, 10, 10);
            graPaper.FillEllipse(Brushes.Black, 50, 50, 10, 10);

        }
        private void DrawD6(PictureBox pbxDice)
        {
            ClearPic(pbxDice);
            Graphics graPaper = pbxDice.CreateGraphics();
            graPaper.FillRectangle(Brushes.White, 0, 0, 100, 100);

            graPaper.FillEllipse(Brushes.Black, 25, 25, 10, 10);
            graPaper.FillEllipse(Brushes.Black, 50, 25, 10, 10);
            graPaper.FillEllipse(Brushes.Black, 75, 25, 10, 10);
            graPaper.FillEllipse(Brushes.Black, 25, 75, 10, 10);
            graPaper.FillEllipse(Brushes.Black, 50, 75, 10, 10);
            graPaper.FillEllipse(Brushes.Black, 75, 75, 10, 10);

        }

        private void ClearPic(PictureBox pbxDice)
        {
            Graphics graPaper = pbxDice.CreateGraphics();
            graPaper.Clear(Color.White);
        }

        public int RollRandom(PictureBox pbxDice)
        {
            Random rnd = new Random();
            switch (rnd.Next(1, 7))
            {
                case 1:
                    DrawD1(pbxDice);
                    return 1;
                case 2:
                    DrawD2(pbxDice);
                    return 2;
                case 3:
                    DrawD3(pbxDice);
                    return 3;
                case 4:
                    DrawD4(pbxDice);
                    return 4;
                case 5:
                    DrawD5(pbxDice);
                    return 5;
                case 6:
                    DrawD6(pbxDice);
                    return 6;
            }
            return 0;

        }

        // Function reset's the dice, intended to be used each round to clear the dice for the next
        public void DiceReset()
        {
            for (int i = 0; i < arrDice.Length; i++)
            {
                //Create new Dice
                arrDice[i] = new Dice();

                //a Dice object has a PixtureBox property 
                //this is to bind the dice object to a picture box on the UI
                //this sets that
                if (i == 0)
                {
                    arrDice[i].CurrentPicbox = pbxDice1;
                }
                else if (i == 1)
                {
                    arrDice[i].CurrentPicbox = pbxDice2;
                }
                else
                {
                    arrDice[i].CurrentPicbox = pbxDice3;
                }
            }
        }

        //Function is used to restart the game and keep the current players.
        //This is done to impliment the win counter feature, I was lucky in designing a game that can easly support this.
        void GameReset()
        {

            if(MessageBox.Show("Game Over", "Would you like to play this mode again?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // The following resets the global variables to start a new game on the same form
                isLurgit = false;
                isSequenceTriggered = false;
                iRound = 0;
                iRoll = 0;
                iPlayer = 1;
            }
            else
            {
                MessageBox.Show("Thank you for playing!");
                this.Dispose();
            }
        }

        //=================================
        //End
        //=================================



        //=================================
        //Event handlers
        //=================================
        private void BtnHoldD1_Click(object sender, EventArgs e)
        {
            //Hold button for Player 1 Die 1
            Die1().HoldToggle();
            btnHoldP1D1.Enabled = false;
        }

        private void BtnHoldD2_Click(object sender, EventArgs e)
        {
            //Hold button for Player 1 Die 2
            Die2().HoldToggle();
            btnHoldP1D2.Enabled = false;
        }

        private void BtnHoldD3_Click(object sender, EventArgs e)
        {
            //Hold button for Player 1 Die 3
            Die3().HoldToggle();
            btnHoldP1D3.Enabled = false;

        }

        private void BtnRoll_Click(object sender, EventArgs e)
        {
            //Roll Die 
            RollStart();

        }

        private void BtnForfeit_Click(object sender, EventArgs e)
        {
            //Forfeit button for current player
            //Displays a message then closes the game form back to main menu
            MessageBox.Show(GetPlayer().GetName + " Forfeits.");
            GameReset();
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            RoundEnd();
        }

        //=================================


    }
}