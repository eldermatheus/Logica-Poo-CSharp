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
using System.IO;


namespace Importador
{
    public partial class Principal : Form
    {
        protected static string baseDados;
        protected static string ipServidor;
        protected static string porta;

        DataTable unidades = new DataTable();
        DataTable clientes = new DataTable();

        public Principal()
        {
            InitializeComponent();

            btnClientes.Cms.Items[0].Click += new EventHandler(InserirClientes);

            btnProdutos.Cms.Items[0].Click += new EventHandler(ChecarProdutos);
            btnProdutos.Cms.Items[1].Click += new EventHandler(ChecarUnidadesMedida);
            btnProdutos.Cms.Items[2].Click += new EventHandler(InserirProdutos);
            
            btnOperacoes.Cms.Items[0].Click += new EventHandler(ChecarNotas);
            btnOperacoes.Cms.Items[1].Click += new EventHandler(ChecarOperacoes);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (btnConectar.Text.Equals("Desconectar"))
            {//Configurar para limpar dados
                Close();
            }

            else
            {
                Conexao conexao = new Conexao();

                baseDados = btnBase.Text;
                ipServidor = btnServidor.Text;
                porta = btnPorta.Text;

                conexao.Conectar();                

                if (conexao.conectado)
                {
                    btnConectar.Text = "Desconectar";
                    btnBase.Enabled = false;
                    btnServidor.Enabled = false;
                    btnPorta.Enabled = false;

                    btnDataInicial.Enabled = true;
                    btnDataFinal.Enabled = true;
                    btnSerie.Enabled = true;
                    btnModelo.Enabled = true;
                    btnChecaCodigo.Enabled = true;
                    btnChecaCodean.Enabled = true;
                    btnChecaCodAnt.Enabled = true;
                    btnChecaDescricao.Enabled = true;
                    btnChecaAll.Enabled = true;
                    btnMovEntradas.Enabled = true;
                    btnMovSaidas.Enabled = true;
                    btnMovAll.Enabled = true;
                    btnClientes.Enabled = true;
                    btnProdutos.Enabled = true;
                    btnPagamentos.Enabled = true;
                    btnOperacoes.Enabled = true;
                    btnImportar.Enabled = true;
                }

                //gdvProdutos.DataSource = conexao.Conectar();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void InserirClientes(object sender, EventArgs e)
        {
            MessageBox.Show("Inserir clientes clicado");
        }
        private void ChecarProdutos(object sender, EventArgs e)
        {
            MessageBox.Show("Checar produtos clicado");
        }
        private void ChecarUnidadesMedida(object sender, EventArgs e)
        {            
            MessageBox.Show("Checar unidades clicado");
        }
        private void InserirProdutos(object sender, EventArgs e)
        {
            MessageBox.Show("Inserir produtos clicado");
        }
        private void ChecarNotas(object sender, EventArgs e)
        {
            MessageBox.Show("Checar notas clicado");
        }
        private void ChecarOperacoes(object sender, EventArgs e)
        {
            MessageBox.Show("Checar operacoes clicado");
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            /*unidades.Columns.Add("codigo", typeof(string));
            unidades.Columns.Add("nome", typeof(string));

            gdvProdutos.DataSource = unidades;
            
            */

            /*clientes.Columns.Add("codigo", typeof(string));
            clientes.Columns.Add("nome", typeof(string));
            clientes.Columns.Add("pais", typeof(string));

            clientes.Columns.Add("cnpj", typeof(string));
            clientes.Columns.Add("teste1", typeof(string));
            clientes.Columns.Add("ie", typeof(string));

            clientes.Columns.Add("municipio", typeof(string));
            clientes.Columns.Add("teste2", typeof(string));
            clientes.Columns.Add("endereco", typeof(string));
            clientes.Columns.Add("numero", typeof(string));

            clientes.Columns.Add("complemento", typeof(string));
            clientes.Columns.Add("bairro", typeof(string));

            gdvProdutos.DataSource = clientes;*/

            unidades.Columns.Add("codigo", typeof(string));
            unidades.Columns.Add("descricao", typeof(string));
            unidades.Columns.Add("cod_tabela", typeof(int));
            
            

        }

        private void btnImportaTxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirAquivo = new OpenFileDialog();

            if (abrirAquivo.ShowDialog() == DialogResult.OK)
            {

                string FileName = abrirAquivo.FileName;
                string SafeFileName = abrirAquivo.SafeFileName;


                using (StreamReader sr = new StreamReader(FileName))

                {
                    String line = sr.ReadLine();




                }
            }




            /*
            string[] linha = File.ReadAllLines(@"C:\Users\elder\Desktop\teste2.txt");
            string[] coluna;
            
            for (int i = 0; i < linha.Length; i++)
            {
                coluna = linha[i].ToString().Split('|');
                
                string[] celula = new string[coluna.Length - 3];

                for (int j = 0; j < celula.Length; j++)
                {
                    celula[j] = coluna[j + 2];

                }
                
                clientes.Rows.Add(celula);
            }
            */
        }
    }
}

