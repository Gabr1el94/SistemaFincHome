using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFCashHomeDesktopView.localhost2;

namespace WCFCashHomeDesktopView
{
    public partial class Apresentacao : Form
    {
        public Apresentacao()
        {
            InitializeComponent();
            timer1.Enabled = true;
            
        }

        private void pgrCarregando_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            if (pgrCarregando.Value < 100)
            {
                if (pgrCarregando.Value == 0)
                {
                    pgrCarregando.Value += 4;
                    label1.Text = "Inicializando...";
                }
                else if(pgrCarregando.Value == 4)
                {
                    pgrCarregando.Value += 6;
                    label1.Text = "Verificando funcionalidades...";
                }
                else if (pgrCarregando.Value==10)
                {
                    pgrCarregando.Value += 10;
                    label1.Text = "Existência conexão...";
                }else if (pgrCarregando.Value == 20)
                {
                    pgrCarregando.Value += 25;
                    label1.Text = "Conectando ao banco...";
                }else if(pgrCarregando.Value == 45)
                {
                    pgrCarregando.Value += 20;
                    label1.Text = "Preparando ambiente...";
                }
                else
                {
                    pgrCarregando.Value += 1;
                    label1.Text = "Carregando...";
                }
            }
            else
            {
                timer1.Enabled = false;
                Login l = new Login();
                l.Show();
                this.Visible = false;
            }
        }
    }
}
