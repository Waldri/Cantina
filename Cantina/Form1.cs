using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina
{
    public partial class Form1 : Form
    {
        string[] produtos = new string[5];
        string[] codigo = new string[5];
        double[] valor = new double[5];
        double soma;
        decimal[] numero = new decimal[50];

        private void loadArray()
        {
            codigo[1] = "001";
            codigo[2] = "002";
            codigo[3] = "003";
            codigo[4] = "004";

            produtos[1] = "Pastel";
            produtos[2] = "Suco";
            produtos[3] = "Hot-dog";
            produtos[4] = "Coxinha";

            valor[1] = 5.50;
            valor[2] = 3.60;
            valor[3] = 6.75;
            valor[4] = 4.25;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            if (txtCod.Text.Length == 3)
            {
                /*lstBox.Items.Add(txtCod.Text);
                txtCod.Text = "";
                txtCod.Focus();*/
                int index = 0;
                for (int prod = 1; prod < codigo.Length; prod++)
                {
                    if (txtCod.Text == codigo[prod]) {
                        index = prod;
                    }
                }
                if(index == 0)
                {
                    MessageBox.Show("Produto não encontrado", "Alert");
                }
                else
                {
                    lstBox.Items.Add(txtCod.Text + " -- " + produtos[index] + " R$ " + valor[index]);
                    soma = soma + valor[index];
                    labTotal.Text = ("Valor Total R$ " + soma);
                    picBox.ImageLocation = @"../../images/"+ codigo[index] +".jpg";
                    txtCod.Text = "";
                    txtCod.Focus();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadArray();
            soma = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
            soma = 0;
            labTotal.Text = "";
            txtCod.Focus();
        }
    }
}
