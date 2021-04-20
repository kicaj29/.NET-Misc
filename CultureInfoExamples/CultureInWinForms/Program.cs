using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CultureInWinForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string invariant = "iii".ToUpper(CultureInfo.InvariantCulture);
            string cultured = "iii".ToUpper(new CultureInfo("tr-TR"));

            //Application.Run(new Form1());

            Application.Run(new Form1
            {
                Font = new Font("Times New Roman", 40),
                Controls = {
                new Label { Text = invariant, Location = new Point(20, 20), AutoSize = true },
                new Label { Text = cultured, Location = new Point(20, 100), AutoSize = true },
            }
            });
        }
    }
}
