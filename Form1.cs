namespace MyDailyMoodTracker
{
    public partial class Form1 : Form
    {
        private string selectedMood = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHappy_Click(object sender, EventArgs e)
        {
            selectedMood = "Happy";
            lblMoodResult.Text = "You're feeling Happy! 😊";
            lblMessage.Text = "Keep smiling! Today is your day! 💛";
        }

        private void btnSad_Click(object sender, EventArgs e)
        {
            selectedMood = "Sad";
            lblMoodResult.Text = "You're feeling Sad! 😢";
            lblMessage.Text = "It's okay to have sad days. Tomorrow is a fresh start! 💙";
        }

        private void btnAngry_Click(object sender, EventArgs e)
        {
            selectedMood = "Angry";
            lblMoodResult.Text = "You're feeling Angry! 😡";
            lblMessage.Text = "Take a deep breath. You've got this! ❤️";
        }

        private void btnTired_Click(object sender, EventArgs e)
        {
            selectedMood = "Tired";
            lblMoodResult.Text = "You're feeling Tired! 😴";
            lblMessage.Text = "Rest is important. You deserve a little break! 💜";
        }

        private void btnLoved_Click(object sender, EventArgs e)
        {
            selectedMood = "Loved";
            lblMoodResult.Text = "You're feeling Loved! 🥰";
            lblMessage.Text = "You are loved, appreciated, and amazing! 💖";
        }

        private void btnSaveMood_Click(object sender, EventArgs e)
        {
            if (selectedMood == "")
            {
                MessageBox.Show("Please select a mood first! 💗");
                return;
            }

            lstMoodHistory.Items.Add(DateTime.Now.ToString("g") + " - " + selectedMood);

            MessageBox.Show("Your mood has been saved! 💕");
        }
    }
}
