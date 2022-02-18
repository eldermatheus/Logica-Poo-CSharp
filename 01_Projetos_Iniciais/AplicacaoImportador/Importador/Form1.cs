using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Importador
{
    public partial class ZImportador : Form
    {        
        public static string baseDados;
        public static string servidor;
        public static string porta;

        public ZImportador()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();

            baseDados = btnBase.Text;
            servidor = btnServidor.Text;
            porta = btnPorta.Text;

            conexao.Conectar();

            if (conexao.loginSuccess) 
            {
                      btnConectar.Text = "Desconectar";
                      btnBase.Enabled = false;
                      btnServidor.Enabled = false;
                      btnPorta.Enabled = false;
            
            }           
        }

        private void btnServidor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImportaTxt_Click(object sender, EventArgs e)
        {

        }

        private void splitButton1_Click(object sender, EventArgs e)
        {

        }    

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
