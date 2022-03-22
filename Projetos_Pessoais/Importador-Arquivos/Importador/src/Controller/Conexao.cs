using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Importador
{
    public class Conexao : Principal
    {
        /*static string? serverName = servidor;       // localhost
        static string? databaseName = baseDados;      // nome do banco de dados
        static string? port = porta;*/                  // porta default
        static string userName = "matheus";           // nome do administrador
        static string password = "1234";              // senha do administrador        
        public bool conectado = false;
        public string stringConexao = "";

        public bool Conectar()
        {
            stringConexao = String.Format(
            "Server={0};Port={1};Database={2};User Id={3};Password={4};",
            ipServidor,
            porta,
            baseDados,
            userName,
            password);

            try
            {
                MessageBox.Show("Classe conexao: " + stringConexao);

                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(stringConexao))
                {
                    pgsqlConnection.Open();
                    pgsqlConnection.
                }
                MessageBox.Show("Conexão efetuada com sucesso");

                conectado = true;


                
            }

            catch (NpgsqlException)
            {
                if (baseDados.Equals(""))
                {
                    MessageBox.Show("Informe o nome da base!");
                }
                else if (porta.Equals(""))
                {
                    MessageBox.Show("Informe a porta do servidor!");
                }
                else
                    MessageBox.Show("Não pode se conectar!");
            }

            catch (ArgumentException)
            {
                if (ipServidor.Equals(""))
                {
                    MessageBox.Show("Informe o IP do servidor!");
                }
            }
            return conectado;
        }

        public DataTable Clientes() {

            DataTable dtClientes = new DataTable();

            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(stringConexao))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "select * from clientes";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dtClientes);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            return dtClientes;
        }

        public DataTable Unidades()
        {
            return dtUnidades;
        }
        public DataTable Pagamentos()
        {
            return dtPagamentos;
        }
        public DataTable Operacoes()
        {
            return dtOperacoes;
        }
        public DataTable Entradas()
        {
            return dtEntradas;
        }
        public DataTable Saidas()
        {
            return dtSaidas;
        }

    }
}
