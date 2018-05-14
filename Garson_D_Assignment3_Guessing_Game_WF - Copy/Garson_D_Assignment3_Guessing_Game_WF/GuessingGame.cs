
/* Daniel Garson 
 * 10/22/17
 * Classroom point of view: To be able to demonstrate how use a random number generator and make
 * use of things like listboxes and labels while using loops and if statements.
 *Business point of view: To create a form game that allows the user to play a guessing game 
 * where they pick a number from one to one hundred and have five chances to pick the correct answer
 * if the user is incorrect five times they loose the game.
*/








using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garson_D_Assignment3_Guessing_Game_WF
{
    public partial class GuessingGame : Form
    {

        int number;
        int guessNum;
        int win = 6;
        int guess = 1;

        int remove;
        

        public GuessingGame()
        {
            InitializeComponent();
            this.AcceptButton = guessButton;        //Accept property
            this.CancelButton = exitButton;         // Cancel property

           
         MessageBox.Show("Guess a number between 1 and 100 you have five chances"); 

        }











        private void GuessingGame_Load(object sender, EventArgs e)
        {

            Random generator = new Random();
            number = generator.Next(0, 101);

        }

       
        

        private void guessButton_Click(object sender, EventArgs e)
        {

            
           
                guessNum = Convert.ToInt32(inputTextBox.Text);
            while (win >= 0)
            {

                // Correct Winner
                if (guessNum == number)
                {
                    if (guess == 1)
                    {
                        highorlowLabel.Text = "Correct";
                        MessageBox.Show("Correct: " + number);
                    }
                    else
                        highorlowLabel.Text = " Correct it took you  " +  guess  + "  guesses";
                    MessageBox.Show("Correct " + number + Environment.NewLine+ 
                        "  is correct it took you  " + guess + "  guesses");
                    break;
                }


                // To Low
                else if(guessNum < number)
                 {
                    wrongListBox.Items.Add(guessNum + " To low, try again!");
                    MessageBox.Show("To Low");
                    highorlowLabel.Text = "number of guesses left are: " + (5 - guess);
                    
                }


                //To High
                else if(guessNum > number)
                 {
                    wrongListBox.Items.Add(guessNum + " To high, try again!");
                    MessageBox.Show("To High");
                    highorlowLabel.Text = "number of guesses left are: " + (5 - guess);
                }
                guess++;



                remove++;

                win--;
                break;
            }

            // Lost 
            if (guess == 6)
            {
                MessageBox.Show("You loose, The correct number was  " + number);
            }
        }
    

     

    private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void clearButton_Click(object sender, EventArgs e)

        {
            
            highorlowLabel.Text = "";
            wrongListBox.Items.Clear();
            Random generator = new Random();
            number = generator.Next(0, 101);
            guessNum = 0;
            guess = 0;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            
            remove = guess++;

            wrongListBox.Items.RemoveAt(wrongListBox.SelectedIndex);

        }

       


    }
}

