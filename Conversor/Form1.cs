using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor
{
    public partial class Form1 : Form
    {

        valores Valores = new valores();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (cbmBase.SelectedIndex == 0)
            {
                Valores.Base2 = txtvalor.Text;
                Valores.Base8 = Convert.ToString(Convert.ToInt32(Valores.Base2, 2), 8);
                Valores.Base10 = Convert.ToString(Convert.ToInt32(Valores.Base2, 2), 10);
                Valores.Base16 = Convert.ToString(Convert.ToInt32(Valores.Base2, 2), 16);
            }

            else if (cbmBase.SelectedIndex == 1)
            {
                Valores.Base8 = txtvalor.Text;
                Valores.Base2 = Convert.ToString(Convert.ToInt32(Valores.Base8, 8), 2);
                Valores.Base10 = Convert.ToString(Convert.ToInt32(Valores.Base2, 2), 10);
                Valores.Base16 = Convert.ToString(Convert.ToInt32(Valores.Base2, 2), 16);
            }

            else if (cbmBase.SelectedIndex == 2)
            {
                Valores.Base10 = txtvalor.Text;
                Valores.Base2 = Convert.ToString(Convert.ToInt32(Valores.Base10, 10), 2);
                Valores.Base8 = Convert.ToString(Convert.ToInt32(Valores.Base2, 2), 8);
                Valores.Base16 = Convert.ToString(Convert.ToInt32(Valores.Base2, 2), 16);
            }

            else if (cbmBase.SelectedIndex == 3)
            {
                Valores.Base16 = txtvalor.Text;
                Valores.Base2 = Convert.ToString(Convert.ToInt32(Valores.Base16, 16), 2);
                Valores.Base8 = Convert.ToString(Convert.ToInt32(Valores.Base2, 2), 8);
                Valores.Base10 = Convert.ToString(Convert.ToInt32(Valores.Base2, 2), 10);
            }

            else
            {
                MessageBox.Show("Selecione uma base");
            }

            MessageBox.Show("Base 2: " + Valores.Base2 + Environment.NewLine +
                            "Base 8: " + Valores.Base8 + Environment.NewLine +
                            "Base 10: " + Valores.Base10 + Environment.NewLine +
                            "Base 16 " + Valores.Base16 + Environment.NewLine  
                            );
        }
    }
}
