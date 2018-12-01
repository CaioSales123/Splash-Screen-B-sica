using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Bloco Try Catch:
            try
            {
                //Incrementa a largura da LoadBar em 1 enquanto for menor que 633:
                LoadBar.Width += 1;
                if (LoadBar.Width >= 633)
                {
                    //Ao atingir a largura necessária, o Timer tera um Stop:
                    timer.Stop();

                    //Após o Timer parar, o formulário será fechado e o próximo deverá ser aberto:
                    this.Close();

                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
