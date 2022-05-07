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
        public static string baseDados;
        public static string ipServidor;
        public static string porta;

        DataTable unidades = new DataTable();

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

        public void Button1_Click(object sender, EventArgs e)
        {
            if (btnConectar.Text.Equals("Desconectar"))
            {//Configurar para limpar dados
                Close();
            }

            else
            {
                Conexao conexao = Conexao.Instance;

                baseDados = btnBase.Text;
                ipServidor = btnServidor.Text;
                porta = btnPorta.Text;

                conexao.Conectar();

                if (Conexao.conectado)
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

        private void BtnFechar_Click(object sender, EventArgs e)
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
            unidades.Columns.Add("codigo", typeof(string));
            unidades.Columns.Add("descricao", typeof(string));

        }

        private void BtnImportaTxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirAquivo = new OpenFileDialog();

            if (abrirAquivo.ShowDialog() == DialogResult.OK)
            {

                string FileName = abrirAquivo.FileName;
                string SafeFileName = abrirAquivo.SafeFileName;

                string[] linha = File.ReadAllLines(FileName);
                string[] coluna;

                for (int i = 0; i < linha.Length; i++)
                {
                    coluna = linha[i].ToString().Split('|');

                    string[] celula = new string[coluna.Length - 3];
                    for (int j = 0; j < celula.Length; j++)
                    {
                        celula[j] = coluna[j + 2];
                    }

                    unidades.Rows.Add(celula);
                }


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Conexao conexao = Conexao.Instance;
            gdvProdutos.DataSource = conexao.Unidades();
        }










        /*private void Button1_Click_1(object sender, EventArgs e)
        {
            Conexao conexao = Conexao.Instance;
            gdvProdutos.DataSource = conexao.Unidades();

        }*/
    }
}

