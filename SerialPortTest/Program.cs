using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spellman
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var task = new Task(Thread);
            task.Start();
            task.Wait();
        }

        private static void Thread()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SpellmanControlUI());
        }
       
      

    }
}
