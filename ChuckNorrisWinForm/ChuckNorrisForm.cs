using ChuckNorrisAPI;

namespace ChuckNorrisWinForm
{
    public partial class ChuckNorrisForm : Form
    {
        public ChuckNorrisForm()
        {
            InitializeComponent();
        }

        private async void ChuckNorrisForm_Load(object sender, EventArgs e)
        {
            string[] categories = (string[])await ChuckNorrisClient.GetCategories();
            foreach (string category in categories)
            {
                cbxCategories.Items.Add(category);
            }
        }

        private async void btnGetRandomJoke_Click(object sender, EventArgs e)
        {
            Joke randomJoke = await ChuckNorrisClient.GetRandomJoke();
            int id = randomJoke.Id;
            string jokeText = randomJoke.JokeText;
            MessageBox.Show(id + ": " + jokeText);
        }
    }
}