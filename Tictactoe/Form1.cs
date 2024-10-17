namespace Tictactoe
{
    public partial class Form1 : Form
    {
        private bool XplayerTurn = true;  // Player X starts first
        private bool isMultiplayer = false;  // by default multiplayer is off
        private int countTurns = 0;  // To track number of turns
        private Random random = new Random();  // For computer move selection


        public Form1()
        {
            InitializeComponent();
            UpdateStatus();
            
        }

        private async void Button_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;

            if (button.Text == "")  // Only allow to move on empty space
            {
                button.Text = XplayerTurn ? "X" : "O";
                countTurns++;
                XplayerTurn = !XplayerTurn;  // Switch turns

                if (CheckForWinner())
                {
                    string winner = XplayerTurn ? "O" : "X";  // X just moved, so O wins
                    MessageBox.Show($"{winner} wins!");
                    DisableButtons();  // Disable once someone wins
                }
                else if (countTurns == 9)
                {
                    MessageBox.Show("It's a draw!");
                    DisableButtons();  // Disable for a draw 
                }
                else if (!XplayerTurn && !isMultiplayer)  // Computer's turn in single player 
                {
                    UpdateStatus();  // Update status to show Computer's turn
                    await Task.Delay(1000);  // delay before the computer moves
                    ComputerMove();  // Call computer move function
                }

                UpdateStatus();  // Update the status after each turn
            }
        }
        private void ComputerMove()
        {
            //Randomly select available spot for "O"
            Button move = null;
            do
            {
                int index = random.Next(1, 10);  // Generate a random button from 1 to 9
                move = (Button)this.Controls["button" + index];  
            }
            while (move.Text != "");  // Repeat unless an empty button is found

            move.PerformClick();  
        }

        private void DisableButtons()
        {
            foreach (Control c in Controls)
            {
                if (c is Button && c.Name.StartsWith("button"))
                {
                    c.Enabled = false;  
                }
            }
        }

        private void UpdateStatus()
        {
            lblStatus.Text = XplayerTurn ? "Player X's turn" : "Player O's turn";
            if (isMultiplayer)
            {
                lblStatus.Text += " (Multiplayer)";
            }
            else if (!XplayerTurn)
            {
                lblStatus.Text = "Computer's turn";
            }
        }

        private bool CheckForWinner()
        {
            
         bool isWinner =
        (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "") ||
        (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "") ||
        (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "") ||
        (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "") ||
        (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "") ||
        (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "") ||
        (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "") ||
        (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "");


            return isWinner;
        }

        private void ResetBoard()
        {
            foreach (Control c in Controls)
            {
                if (c is Button && c.Name.StartsWith("button"))
                {
                    c.Text = "";       // Reset the text of the buttons
                    c.Enabled = true;  // Re-enable the buttons
                }
            }
            countTurns = 0;
            XplayerTurn = true;
            UpdateStatus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetBoard();
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            isMultiplayer = !isMultiplayer;  // Toggle
            btnMultiplayer.Text = isMultiplayer ? "Multiplayer Mode: On" : "Multiplayer Mode: Off";
            ResetBoard();  
        }
    }
}
