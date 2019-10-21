﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banco_Dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.CST;
            try
            {
                con.Open();
                con.Close();
                MessageBox.Show("A conexão foi realizada com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Falha na Conexão:{0}", ex.Message));
                /*Abriu e fechou a conexao
                * Exibir mensagem se a conexão foi realizada com sucesso,
                * caso dê algum erro ele irá direto para o Catch e exibirá
                * a msg de falha */
            }
        }
    }
}
