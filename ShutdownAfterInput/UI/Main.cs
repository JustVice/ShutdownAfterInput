using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ShutdownAfterInput.Logic;


namespace ShutdownAfterInput.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            UI_SETTINGS();
        }

        private void UI_SETTINGS()
        {
            //Changes form title label.
            this.Text = Memory.program_label_name;
            //Changes version label
            this.label_version.Text = Memory.program_version;
            //puts form at the center of the screen.
            this.CenterToScreen();
            LABEL_YOU_MUST_CHECK_YOU_UNDERSTAND_TOOGLE_VISIBILITY(false);
            //No resize window
            this.MaximizeBox = false;
        }

        private void CHANGE_ENGINE_TIMER(int time)
        {
            //sets the timer before performing shutdown after any
            //mouse movement.
            Memory.ENGINE_TIMER = time;
        }


        private void START_ENGINE()
        {
            //starts thread and closes this form.
            ENGINE_LOGIC engine_logic = new ENGINE_LOGIC();
            Thread t = new Thread(engine_logic.START_ENGINE_METHOD);
            t.Start();
            this.Close();
        }

        #region buttons

        private void button_10_seconds_Click(object sender, EventArgs e)
        {
            if (USER_CHECKED_I_UNDERSTAND_WHAT_THIS_PROGRAM_DOES())
            {
                CHANGE_ENGINE_TIMER(10000);
                START_ENGINE();
            }
            else
            {
                LABEL_YOU_MUST_CHECK_YOU_UNDERSTAND_TOOGLE_VISIBILITY(true);
            }
        }

        private void button_1_minute_Click(object sender, EventArgs e)
        {
            if (USER_CHECKED_I_UNDERSTAND_WHAT_THIS_PROGRAM_DOES())
            {
                CHANGE_ENGINE_TIMER(60000);
                START_ENGINE();
            }
            else
            {
                LABEL_YOU_MUST_CHECK_YOU_UNDERSTAND_TOOGLE_VISIBILITY(true);
            }
        }

        private void button_5_minute_Click(object sender, EventArgs e)
        {
            if (USER_CHECKED_I_UNDERSTAND_WHAT_THIS_PROGRAM_DOES())
            {
                CHANGE_ENGINE_TIMER(300000);
                START_ENGINE();
            }
            else
            {
                LABEL_YOU_MUST_CHECK_YOU_UNDERSTAND_TOOGLE_VISIBILITY(true);
            }
        }

        private void button_10_minute_Click(object sender, EventArgs e)
        {
            if (USER_CHECKED_I_UNDERSTAND_WHAT_THIS_PROGRAM_DOES())
            {
                CHANGE_ENGINE_TIMER(600000);
                START_ENGINE();
            }
            else
            {
                LABEL_YOU_MUST_CHECK_YOU_UNDERSTAND_TOOGLE_VISIBILITY(true);
            }
        }

        private void button_about_Click_1(object sender, EventArgs e)
        {
            open_about_form();
        }

        private void open_about_form()
        {
            this.Hide();
            var About = new About();
            About.Closed += (s, args) => this.Close();
            About.Show();
        }

        #endregion

        private bool USER_CHECKED_I_UNDERSTAND_WHAT_THIS_PROGRAM_DOES()
        {
            return checkBox_i_understand.Checked;
        }

        private void LABEL_YOU_MUST_CHECK_YOU_UNDERSTAND_TOOGLE_VISIBILITY(bool status)
        {
            label_you_must_check_this_check_box.Visible = status;
        }

    }
}
