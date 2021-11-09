using ChuckNorrisAPI;

namespace ChuckNorrisWinForm
{
    public partial class ChuckNorrisForm : Form
    {
        public ChuckNorrisForm()
        {
            InitializeComponent();
        }

        private void ChuckNorrisForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnGetRandomJoke_Click(object sender, EventArgs e)
        {
            Joke randomJoke = await ChuckNorrisClient.GetRandomJoke();
            string jokeText = randomJoke.JokeText;
            MessageBox.Show(jokeText);
        }
    }
}