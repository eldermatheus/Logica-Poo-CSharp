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
        public static bool conectado = false;
        public static string stringConexao = "";

        private static readonly Conexao instance = new Conexao();

        public static Conexao Instance 
        { 
            get { return instance; }
        }

        private Conexao() { 
        }

        public bool Conectar()
        {
            stringConexao = String.Format(
            "Server={0};Port={1};Database={2};User Id={3};Password={4};",
            Principal.ipServidor,
            Principal.porta,
            Principal.baseDados,
            userName,
            password);

            try
            {
                MessageBox.Show("Classe conexao: " + stringConexao);

                if (Principal.porta.Equals(""))
                {
                    MessageBox.Show("Informe a porta do servidor!");
                }
                else
                {
                    using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(stringConexao))
                    {
                        pgsqlConnection.Open();
                    }
                    MessageBox.Show("Conexão efetuada com sucesso");

                    conectado = true;
                }
            }

            catch (NpgsqlException)
            {
                if (Principal.baseDados.Equals(""))
                {
                    MessageBox.Show("Informe o nome da base!");
                }                
                else
                    MessageBox.Show("Não pode se conectar!");
            }

            catch (ArgumentException)
            {
                if (Principal.ipServidor.Equals(""))
                {
                    MessageBox.Show("Informe o IP do servidor!");
                }
            }
            return conectado;
        }

        public DataTable Unidades() {

            DataTable dtUnidades = new DataTable();

            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(stringConexao))
                {                    
                    pgsqlConnection.Open();
                    string cmdSeleciona = "select * from clientes";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dtUnidades);
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
            
            return dtUnidades;
        }

      /*  public DataTable Unidades()
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
        }*/

    }
}
