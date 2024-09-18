namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private char playerTurn = 'X';
        private bool gameActive = true;
        private Button[] winningButtons;

        public Form1()
        {
            InitializeComponent();
            btn1.Click += new EventHandler(btn_Click);
            btn2.Click += new EventHandler(btn_Click);
            btn3.Click += new EventHandler(btn_Click);
            btn4.Click += new EventHandler(btn_Click);
            btn5.Click += new EventHandler(btn_Click);
            btn6.Click += new EventHandler(btn_Click);
            btn7.Click += new EventHandler(btn_Click);
            btn8.Click += new EventHandler(btn_Click);
            btn9.Click += new EventHandler(btn_Click);
            btnReset.Click += new EventHandler(btnReset_Click);

            // Make buttons same color as background
            foreach (Control c in Controls)
            {
                if (c is Button btn && btn.Name.StartsWith("btn") && btn != btnReset)
                {
                    btn.BackColor = this.BackColor; // Set to form background color
                }
            }
            btn1.Paint += new PaintEventHandler(Button_Paint);
            btn2.Paint += new PaintEventHandler(Button_Paint);
            btn3.Paint += new PaintEventHandler(Button_Paint);
            btn4.Paint += new PaintEventHandler(Button_Paint);
            btn5.Paint += new PaintEventHandler(Button_Paint);
            btn6.Paint += new PaintEventHandler(Button_Paint);
            btn7.Paint += new PaintEventHandler(Button_Paint);
            btn8.Paint += new PaintEventHandler(Button_Paint);
            btn9.Paint += new PaintEventHandler(Button_Paint);
        }

        private void Button_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2), 0, 0, btn.Width - 1, btn.Height - 1);
        }



        private void groupBox_Enter(object sender, EventArgs e)
        {

        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (gameActive && btn.Text == "")
            {
                btn.Text = playerTurn.ToString();
                btn.Font = new Font(btn.Font.FontFamily, 24);
                btn.Enabled = false;
                CheckWin();
                TogglePlayer();
            }
        }

        // Toggle between players X and O
        private void TogglePlayer()
        {
            // Only update the status if the game is still active
            if (gameActive)
            {
                playerTurn = (playerTurn == 'X') ? 'O' : 'X';
                lblStatus.Text = $"Player {playerTurn}'s turn";
            }
        }

        // Check if there's a winner or if the game is a draw
        // Handle draw scenario
        private void CheckWin()
        {
            // Winning combinations (rows, columns, diagonals)
            string[,] board = {
        { btn1.Text, btn2.Text, btn3.Text },
        { btn4.Text, btn5.Text, btn6.Text },
        { btn7.Text, btn8.Text, btn9.Text }
    };

            for (int i = 0; i < 3; i++)
            {
                // Check rows
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != "")
                {
                    EndGame(board[i, 0]);
                    return;
                }

                // Check columns
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != "")
                {
                    EndGame(board[0, i]);
                    return;
                }
            }

            // Check diagonals
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != "")
            {
                EndGame(board[0, 0]);
                return;
            }

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != "")
            {
                EndGame(board[0, 2]);
                return;
            }

            // Check for draw
            if (IsDraw())
            {
                String text = "It's a draw!";
                MessageBox.Show(text, "", MessageBoxButtons.OK);
                lblStatus.Text = text; // Clear the status after a draw
                gameActive = false;
            }
        }

        // End the game and declare the winner
        private void EndGame(string winner)
        {
            String text = $"Player {winner} wins!";
            MessageBox.Show(text, "", MessageBoxButtons.OK);
            lblStatus.Text = text; // Clear the status after the game ends
            gameActive = false;

            // Disable all buttons since the game has ended
            foreach (Control c in Controls)
            {
                if (c is Button && c.Name.StartsWith("btn") && c != btnReset)
                {
                    Button btn = (Button)c;
                    btn.Enabled = false;
                }
            }
        }





        // Check if the game is a draw (all buttons filled, no winner)
        private bool IsDraw()
        {
            return btn1.Text != "" && btn2.Text != "" && btn3.Text != "" &&
                   btn4.Text != "" && btn5.Text != "" && btn6.Text != "" &&
                   btn7.Text != "" && btn8.Text != "" && btn9.Text != "";
        }

        // Reset the game
        // Reset the game
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset all buttons' texts and re-enable them
            ResetButtons(this.Controls);

            // Reset game state
            playerTurn = 'X';
            lblStatus.Text = $"Player {playerTurn}'s turn";
            gameActive = true;
        }

        // Recursive function to reset all buttons, even in nested containers
        private void ResetButtons(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c is Button btn && btn.Name.StartsWith("btn") && btn != btnReset)
                {
                    btn.Text = "";
                    btn.Font = new Font(btn.Font.FontFamily, 12); // Reset the font size back to default (e.g. 12)
                    btn.Enabled = true; // Re-enable the buttons
                }
                else if (c.HasChildren)
                {
                    ResetButtons(c.Controls); // Recursively check child controls
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
        // Draw grid lines and winning line
        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                base.OnPaint(e);

                // Draw grid lines
                Pen pen = new Pen(Color.Black, 2);
                e.Graphics.DrawLine(pen, btn1.Right, btn1.Top, btn1.Right, btn7.Bottom); // Vertical line 1
                e.Graphics.DrawLine(pen, btn2.Right, btn2.Top, btn2.Right, btn8.Bottom); // Vertical line 2
                e.Graphics.DrawLine(pen, btn1.Left, btn1.Bottom, btn3.Right, btn1.Bottom); // Horizontal line 1
                e.Graphics.DrawLine(pen, btn4.Left, btn4.Bottom, btn6.Right, btn4.Bottom); // Horizontal line 2

                // Draw the winning line if there is one
                if (winningButtons != null)
                {
                    pen = new Pen(Color.Red, 4); // Red color for winning line
                    Point start = new Point(winningButtons[0].Left + winningButtons[0].Width / 2, winningButtons[0].Top + winningButtons[0].Height / 2);
                    Point end = new Point(winningButtons[2].Left + winningButtons[2].Width / 2, winningButtons[2].Top + winningButtons[2].Height / 2);
                    e.Graphics.DrawLine(pen, start, end);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
