using Npgsql;
using System.Data.SqlClient;
using TesteLoginSite;

namespace TesteLogin
{

    public partial class Form2 : Form
    {
        bool logado = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSenha_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool result = VerificaLogin();

            if (result)
            {
                logado = true;
                MessageBox.Show("Seja bem vindo!");
                btnEntrar.Enabled = false;
                new Form1().Show();
                this.Hide();

            }

            //================================ Reinserir o código quando resolver execption da conexão ================================ 
            else 
            {
               //MessageBox.Show("Usuário ou senha incorreto!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool VerificaLogin()
        {            
            string serverName = "127.0.0.1";  //localhost
            string port = "5432";             //porta default
            string userName = btnUsuario.Text;     //nome do administrador
            string password = btnSenha.Text;     //senha do administrador
            string databaseName = "base_v5"; //nome do banco de dados
            bool result = false;
            string connString = null;

            connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",serverName, port, userName, password, databaseName);
            
            {                
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                try
                {
                    pgsqlConnection.Open();
                    if (true) {
                        result = true;
                    }                                        
                }

                catch (Npgsql.NpgsqlException e)
                {
                        //================================ Ponto de melhora ================================ 
                        //throw new Exception(e.Message);
                        // Adequar para passar direto pela exception sem exibir mensagem
                        MessageBox.Show("Usuário ou senha incorreto!");
                        btnUsuario.Focus();
                    }

                
            }
            return result;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
           /* if (logado)
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Exit();
            }*/
        }
    }
}