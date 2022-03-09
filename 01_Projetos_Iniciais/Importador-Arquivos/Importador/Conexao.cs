using System;
using System.Windows.Forms;
using Npgsql;

namespace Importador
{
    public class Conexao : ZImportador
    {
        //public bool logado = false;
        public bool loginSuccess = false;

        public void VerificaLogin()
        {
            string serverName = servidor;  //localhost
            string databaseName = baseDados; //nome do banco de dados
            string port = porta;             //porta default
            string userName = "zeus";     //nome do administrador            
            string password = "zeusii11";     //senha do administrador            
            
            string connString = null;

            connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", serverName, port, userName, password, databaseName);

            {                
                    try
                    {
                        using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                        pgsqlConnection.Open();
                        
                        if (true)
                        {
                            loginSuccess = true;
                        }
                    }

                    catch (Exception )
                    {                        
                        MessageBox.Show("Usuário ou senha incorreto!");
                    }
            }
            
        }

        public void Conectar()
        {
            VerificaLogin();

            if (loginSuccess)
            {
               //logado = true;
                MessageBox.Show("Conexão efetuada com sucesso!");
                MessageBox.Show(baseDados);
                /*MessageBox.Show(btnBase.Text);
                MessageBox.Show(btnServidor.Text);
                MessageBox.Show(btnPorta.Text);
                MessageBox.Show(textBox1.Text);*/
            }
            
        }

        public void Desconectar()
        {
            Close();

        }

    }
}
