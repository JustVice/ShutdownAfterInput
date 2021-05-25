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
            UI_SETTINGS();
        }

        private void UI_SETTINGS()
        {
            //puts form at the center of the screen.
            this.CenterToScreen();
            //No resize window
            this.MaximizeBox = false;
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
            string url = "https://github.com/SplitVice/ShutdownAfterInput/wiki/Program-Guidelines";
            Memory.OPEN_BROWSER_WITH_URL(url);
        }

        private void label_twitter_Click(object sender, EventArgs e)
        {
            string url = "http://split-vice.com/s/twitter";
            Memory.OPEN_BROWSER_WITH_URL(url);
        }

        private void label_web_page_Click(object sender, EventArgs e)
        {
            string url = "http://split-vice.com/";
            Memory.OPEN_BROWSER_WITH_URL(url);
        }

        private void label_github_Click(object sender, EventArgs e)
        {
            string url = "http://split-vice.com/s/github-repos";
            Memory.OPEN_BROWSER_WITH_URL(url);
        }

        private void label_program_web_page_Click(object sender, EventArgs e)
        {
            string url = "http://split-vice.com/technology/CSharp/shutdown-after-input/";
            Memory.OPEN_BROWSER_WITH_URL(url);
        }

        #endregion
    }
}
