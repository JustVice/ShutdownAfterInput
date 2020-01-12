using System;
using System.Windows.Forms;
using ShutdownAfterInput.Logic;

namespace ShutdownAfterInput.UI
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            //puts form at the center of the screen.
            this.CenterToScreen();
        }

        private void button_back_to_main_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Main = new Main();
            Main.Closed += (s, args) => this.Close();
            Main.Show();
        }

        #region Label buttons   

        private void label_program_instrucctions_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/JustVice/ShutdownAfterInput/wiki/Program-Guidelines";
            Memory.OPEN_BROWSER_WITH_URL(url);
        }

        private void label_twitter_Click(object sender, EventArgs e)
        {
            string url = "http://justvice.github.io/s/twitter";
            Memory.OPEN_BROWSER_WITH_URL(url);
        }

        private void label_web_page_Click(object sender, EventArgs e)
        {
            string url = "http://justvice.github.io/";
            Memory.OPEN_BROWSER_WITH_URL(url);
        }

        private void label_github_Click(object sender, EventArgs e)
        {
            string url = "http://justvice.github.io/s/github-repos";
            Memory.OPEN_BROWSER_WITH_URL(url);
        }

        private void label_program_web_page_Click(object sender, EventArgs e)
        {
            string url = "https://www.google.com/";
            Memory.OPEN_BROWSER_WITH_URL(url);
        }

        #endregion
    }
}
