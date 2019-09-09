using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Cantina
{
    public partial class Form1 : Form
    {
        string[] produtos = new string[10];
        string[] codigo = new string[10];
        double[] valor = new double[10];
        double soma;
        /*
        Declaração de 3 arrays para armazenar 10 produtos,
        e seus respectivos códigos e valores.
        */
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 3)
            {
                int indice = 0;
                for (int prod = 0; prod < codigo.Length; prod++)
                {
                    if (txtCodigo.Text == codigo[prod])
                    {
                        indice = prod;
                    }
                }
                if (indice == 0)
                {
                    MessageBox.Show("Produto não encontrado.");
                }
                else
                {
                    lstCaixa.Items.Add(txtCodigo.Text+" -- "+produtos[indice]+" -- R$ "+valor[indice]);
                    soma += valor[indice];
                    label3.Text = "Valor Total = R$ " + soma;
                    picImagem.ImageLocation = "c:/imagens/" + codigo[indice] + ".jpg";
                    txtCodigo.Text = "";
                    txtCodigo.Focus();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregarArray();
            soma = 0;
        }
        /*Ao entrar no Form Load será chamado o método*/
        private void carregarArray()
        /*Criação do Método para ser chamado quando necessário, isso evita repetir
        várias vezes o mesmo código*/
        {
            codigo[1] = "001";
            codigo[2] = "002";
            codigo[3] = "003";
            codigo[4] = "004";
            codigo[5] = "005";
            produtos[1] = "Pastel";
            produtos[2] = "Coxinha";
            produtos[3] = "Hot_Dog";
            produtos[4] = "Chocolate";
            produtos[5] = "Suco";
            valor[1] = 6.00;
            valor[2] = 5.00;
            valor[3] = 12.00;
            valor[4] = 3.50;
            valor[5] = 8.00;
            /*Códigos, Produtos e Valores ref. os arrays que foram declarados*/
        }
    }
}
