using System;
using System.Drawing;
using System.Windows.Forms;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        //Programmed by Alexander Summers


        private int moveCounter;

        enum PossiblePlayers
        {
            PlayerOne = 1,
            PlayerTwo
        }
        
        PictureBox[,] squareValues; //Represents the 3x3 TicTacToe board

        private PossiblePlayers currentPlayer = PossiblePlayers.PlayerOne;

        public TicTacToe()
        {
            InitializeComponent();
        }

        void initializeButtons()
        {
            //Assigns values of the PictureBoxes to the TicTacToe grid
            squareValues = new PictureBox[,]
            {
                {
                    pcbTopLeft, pcbTopMiddle, pcbTopRight
                },
                {
                    pcbMiddleLeft, pcbTheMiddle, pcbMiddleRight
                },
                {
                    pcbBottomLeft, pcbBottomMiddle, pcbBottomRight
                }
            };

        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            initializeButtons();
        }
        private void anyPcb_Click(object sender, EventArgs e)
        {
            PictureBox selectedBox = (PictureBox) sender;
            
            //Assigns 'X' or 'O' to box
            buttonCalculations(selectedBox);

            //Disables future click events
            preventReclick(selectedBox);

            playerWinCheck();

            
        }
        void buttonCalculations(PictureBox selectedBox)
        {
            if (currentPlayer == PossiblePlayers.PlayerOne)
            {
                selectedBox.Image = Resources.X; 
                selectedBox.Image.Tag = "X";


            }
            else if (currentPlayer == PossiblePlayers.PlayerTwo)
            {
                selectedBox.Image = Resources.O;
                selectedBox.Image.Tag = "O";

            }
            
        }
        void preventReclick(PictureBox clickedPictureBox) 
        {
            clickedPictureBox.Enabled = false;
        }
        void changePlayer()
        {
            if (currentPlayer == PossiblePlayers.PlayerOne)
            {
                currentPlayer++;
                lblCurrentPlayer.Text = "O";
            }
            else
            {
                currentPlayer--;
                lblCurrentPlayer.Text = "X";
            }
        }
        void playerWinCheck()
        {
            if (isThereARowWin() || isThereAColumnWin() || isThereADiagonalWin())
            {
                lblCurrentPlayer.Text = "Done";
                DialogResult result = MessageBox.Show($"Congratulations, Player {Convert.ToInt32(currentPlayer)} won! \n\n Would you like to play again?", "Congratulations", MessageBoxButtons.YesNo);

                processEndGame(result);
                
            }
            else
            {
                changePlayer();
                incrementMoveCounter();
            }
        }

       
        bool isThereARowWin()
        {
            bool lineIsValid;
            for (int i = 0; i < squareValues.GetLength(0); i++) {
                lineIsValid = isSpaceNotBlank(i, 0) && isSpaceNotBlank(i, 1) && isSpaceNotBlank(i, 2);

                if (lineIsValid) {

                    //Checks 'X' and 'O' values in each row
                    if ((squareValues[i, 0].Image.Tag == squareValues[i, 1].Image.Tag) &&
                        (squareValues[i, 1].Image.Tag == squareValues[i, 2].Image.Tag)) {
                        return true;


                    }
                }

            }

            return false;
        }

        bool isThereAColumnWin()
        {
            bool lineIsValid;
            for (int i = 0; i < squareValues.GetLength(0); i++) {
                lineIsValid = isSpaceNotBlank(0, i) && isSpaceNotBlank(1, i) && isSpaceNotBlank(2, i);

                if (lineIsValid)
                {
                    //Checks 'X' and 'O' values in each column
                    if ((squareValues[0, i].Image.Tag == squareValues[1, i].Image.Tag) &&
                        (squareValues[1, i].Image.Tag == squareValues[2, i].Image.Tag)) {
                        return true;


                    }

                }

            }

            return false;
        }

        bool isThereADiagonalWin()
        {
            bool lineIsValid = isSpaceNotBlank(0, 0) && isSpaceNotBlank(1, 1) && isSpaceNotBlank(2, 2);

            if (lineIsValid)
            {
                //Manually checks each diagonal square to see if there's an 'X
                if ((squareValues[0, 0].Image.Tag == squareValues[1, 1].Image.Tag) &&
                    (squareValues[1, 1].Image.Tag == squareValues[2, 2].Image.Tag))
                {
                    return true;
                }

                return false;
            }

            lineIsValid = isSpaceNotBlank(2, 0) && isSpaceNotBlank(1, 1) && isSpaceNotBlank(0, 2);

            if (lineIsValid)
            {
                if ((squareValues[2, 0].Image.Tag == squareValues[1, 1].Image.Tag) &&
                    (squareValues[1, 1].Image.Tag == squareValues[0, 2].Image.Tag))
                {
                    return true;
                }

                return false;
            }
            else
            {
                return false;
            }

        }

        bool isSpaceNotBlank(int row, int column)
        {
            if ((Convert.ToString(squareValues[row, column].Image.Tag) == "X") || (Convert.ToString(squareValues[row, column].Image.Tag) == "O"))
            {
                return true;
            }
            else
            {
                {
                    return false;
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            gameResetter();

        }
        void gameResetter() 
        {
            setFirstPlayer();

            moveCounter = 0;

            foreach (Control control in Controls) 
            {
                if (control is PictureBox)
                {
                    PictureBox currentBox = (PictureBox)control;

                    currentBox.Image = Resources.blankSpace;
                    currentBox.Enabled = true;
                }
            }


        }

        void incrementMoveCounter()
        {
            moveCounter++;
            if (moveCounter == 9)
            {
                lblCurrentPlayer.Text = "Done";
                DialogResult result = MessageBox.Show("There was a tie! No one won.\n Would you like to play again?", "Tie", MessageBoxButtons.YesNo);
                processEndGame(result);

            }
        }

        void processEndGame(DialogResult result)
        {
            if (result == DialogResult.Yes) {
                gameResetter();
            }
            else 
            {
                Close();
            }
        }

        void setFirstPlayer()
        {
            currentPlayer = PossiblePlayers.PlayerOne;
            lblCurrentPlayer.Text = "X";
        }
    }
}


    
