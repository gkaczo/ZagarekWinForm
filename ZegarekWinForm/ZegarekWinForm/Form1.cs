using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZegarekWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mskTextGodzina.Text = DateTime.Now.ToString("T");
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            if(DateTime.TryParse(mskTextGodzina.Text, out dt)==true)
            {
                GodzinaMinuta gm = new GodzinaMinuta(dt.Hour, dt.Minute);
                lblKatRadiany.Text = gm.KatRadiany.ToString();
                lblKatStopnie.Text = gm.KatStopnie.ToString();
            }
            else
            {
                MessageBox.Show("Błędny format daty. Dopuszczalny format gg:mm");
            }
        }

        private void mskTextGodzina_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Błędny format daty. Dopuszczalny format gg:mm");
            }
            else
            {
                DateTime userDate = (DateTime)e.ReturnValue;
                if (userDate.Hour >24 | userDate.Minute>60 )
                {
                     e.Cancel = true;
                }
            }
        }
    }
}
