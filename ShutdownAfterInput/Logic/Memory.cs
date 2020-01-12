using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutdownAfterInput.Logic
{
    public class Memory
    {
        //If true, the program will not shutdown the PC.
        public static bool TEST_MODE = true;
        //The time before the engine save the mouse coordinates and starts
        //checking if the mouse was moved to then shutdown the PC.
        public static int ENGINE_TIMER = 10000;
        public static string program_label_name = "Shutdown After Input",
            program_version = "1.0";

        public static void OPEN_BROWSER_WITH_URL(string url)
        {
            try { 
            System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine("OPEN BROWSER WITH URL ERROR.");
            }
        }
    }
}
