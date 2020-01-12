using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;


namespace ShutdownAfterInput.Logic
{
    public class ENGINE_LOGIC
    {
        int x = 0;
        int y = 0;

        public void START_ENGINE_METHOD()
        {
            Thread.Sleep(Memory.ENGINE_TIMER);
            System.Drawing.Point point = Control.MousePosition;
            this.x = point.X;
            this.y = point.Y;
            while (true)
            {
                System.Drawing.Point point_temp = Control.MousePosition;
                int temp_x = point_temp.X;
                int temp_y = point_temp.Y;
                if (temp_x != this.x || temp_y != this.y)
                {
                    CMD();
                    System.Environment.Exit(1);
                }
                Thread.Sleep(500);
                print_status(temp_x, temp_y);
            }
        }

        private void CMD()
        {
            if (Logic.Memory.TEST_MODE)
            {
                MessageBox.Show("Shutdown simulation");
            }
            else
            {
                Process.Start("shutdown", "/s /t 0");
            }
        }

        private void print_status(int tempx, int tempy)
        {
            string message = "Current x and y stored: " + this.x + " " + this.y + "\n" +
                "Current x and y actual: " + tempx + " " + tempy;
            Console.WriteLine(message);
        }
    }
}

