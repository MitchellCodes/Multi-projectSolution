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
            cbxCategories.Items.Add("random");
            string[] categories = (string[])await ChuckNorrisClient.GetCategories();
            foreach (string category in categories)
            {
                cbxCategories.Items.Add(category);
            }

            // set the combobox to show random as the default selection
            cbxCategories.SelectedIndex = 0;
        }

        private async void btnGetRandomJoke_Click(object sender, EventArgs e)
        {
            Joke randomJoke;

            // Check if there is a category selected
            if (cbxCategories.SelectedItem.Equals("random"))
            {
                randomJoke = await ChuckNorrisClient.GetRandomJoke();
            }
            else
            {
                randomJoke = await ChuckNorrisClient.GetRandomJoke(cbxCategories.SelectedItem.ToString());
            }
            

            // Display the joke
            int id = randomJoke.Id;
            string jokeText = randomJoke.JokeText;
            MessageBox.Show(id + ": " + jokeText);
        }
    }
}