using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThrowVsThrowEx;

namespace NETmisc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThrowVsThrowEx_Click(object sender, EventArgs e)
        {
            try
            {
                Class1 obj = new Class1();
                obj.Demo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }

        }
    }
}
