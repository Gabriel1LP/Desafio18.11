using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio18._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int N1 = 0, N2 = 1, next;
            for (int i = 0; i <= 30; i++)
            {
                next = N1 + N2 ;
                N1 = N2;
                N2 = next;

                lsbNumero.Items.Add(N1);
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
