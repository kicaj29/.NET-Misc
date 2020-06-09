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
using dynamicVSvarVSobject;

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

        private void btnCovarianceAndContravariance_Click(object sender, EventArgs e)
        {
            CovarianceAndContravariance.RunMe.Run();
        }

        private void btnDoubleQuestionMark_Click(object sender, EventArgs e)
        {
            string x = null;
            string y = string.Empty;
            string z = default(string);

            string x1 = x ?? "abc";
            string y1 = y ?? "abc";
            string z1 = z ?? "abc";
        }

        private void btnTryCatchFinally_Click(object sender, EventArgs e)
        {
            var x = new TryCatchFinally();
            x.Test();
        }

        private void btnDynamicVarObject_Click(object sender, EventArgs e)
        {
            // DynamicVarObject.Go();
            DynamicVarObject.ObjectVsDynamic();
        }
    }
}
