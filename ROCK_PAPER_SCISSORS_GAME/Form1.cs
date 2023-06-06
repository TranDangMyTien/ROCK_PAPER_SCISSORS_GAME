namespace ROCK_PAPER_SCISSORS_GAME
{
    public partial class Form1 : Form
    {
        string playerChoice;
        string computerChoice;
        string[] options = { "R", "P", "S" };//, "P", "S", "R" };
        Random rd = new Random();
        int computerScore;
        int playerScore;
        string draw;

        public Form1()
        {
            InitializeComponent();
        }

      

        private void button_click(object sender, EventArgs e)
        {
            Button tempButton = sender as Button;
            playerChoice = (string)tempButton.Tag;
            int i = rd.Next(0, options.Length);
            computerChoice = options[i];
            lbPLAYERchoice.Text = "Player is: " + UpdateTextandImage(playerChoice, PLAYER_pic);
            lbCPUchoice.Text = "Computer is: " + UpdateTextandImage(computerChoice, CPU_pic);
            CheckGame();


        }
        private string UpdateTextandImage(string text, PictureBox pic)
        {
            string word = null;
            switch(text)
            {
                case "R":
                    word = "ROCK";
                    pic.Image = Properties.Resources.ROCK;
                    break;
                case "P":
                    word = "PAPER";
                    pic.Image = Properties.Resources.PAPER;
                    break;
                case "S":
                    word = "SCISSORS";
                    pic.Image = Properties.Resources.SCISSORS;
                    break;
                
            }
            return word;
        }
        private void CheckGame()
        {
            if(computerChoice == playerChoice)
            {
                draw = "Draw !";
            }
            else if (playerChoice == "R" && computerChoice == "P" || playerChoice == "S" && computerChoice == "R"
                || playerChoice == "P" && computerChoice == "S") 
            {
                computerScore++;
                draw = null;
            }
            else
            {
                playerScore++;
                draw = null;
            }
            lbCPUresult.Text = "Computer Score: " + computerScore + Environment.NewLine + draw;
            lbPLAYERresult.Text = "Player Score: " + playerScore + Environment.NewLine + draw;
        }
    }
}