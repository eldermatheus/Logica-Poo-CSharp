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
    public class testeConexao : Principal
    {
        /*static string? serverName = servidor;       // localhost
        static string? databaseName = baseDados;      // nome do banco de dados
        static string? port = porta;*/                  // porta default
        static string userName = "matheus";           // nome do administrador
        static string password = "1234";              // senha do administrador        
        public bool conectado = false;
        public string processId = "";

        public DataTable Conectar()
        {
            string stringConexao = String.Format(
            "Server={0};Port={1};Database={2};User Id={3};Password={4};",
            ipServidor,
            porta,
            baseDados,
            userName,
            password);



            DataTable dt = new DataTable();

            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(stringConexao))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "select * from unidademedidas";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
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

            return dt;
        }




        /*try
        {
            using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(stringConexao))
            {
                pgsqlConnection.Open();
                processId = pgsqlConnection.ProcessID.ToString();
                conectado = true;
                MessageBox.Show("Pid:" + processId);
            }
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

        return processId;
    }

   /* public DataTable GetUnidades()
    {
        DataTable unidades = new DataTable();

        try
        {
            string command = "Select * from unidademedidas ";

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(command, processId))
            {
                Adpt.Fill(unidades);
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
        return unidades;
    }*/




    }
}

