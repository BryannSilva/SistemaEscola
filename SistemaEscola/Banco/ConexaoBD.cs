using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Banco
{
    public class ConexaoBD
    {
        /*
        * QUE LEGAL TER VOCÊ AQUI, ALUNINHO(A)!
        * Esse arquivo é responsável por realizar a conexão com o Banco de dados!
        * Lembre-se de importar o MySqlConnector pelo NuGet

        */


        // Nas linhas abaixo você poderá mudar as informações da conexão com o bd:
        private const string SERVER = "localhost",
                             PORT = "3306",
                             DATABASE = "sistemaescola",
                             UID = "root",
                             PWD = "";

        // Método para conectar ao bd. Deve ser instanciado por um objeto MySqlConnection
        public MySqlConnection ObterConexao()
        {
            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection("SERVER=" + SERVER + ";PORT=" + PORT + ";DATABASE=" + DATABASE + ";UID=" + UID + ";PWD=" + PWD + ";");
                con.Open();
            }
            catch (MySqlException e)
            {

                Console.WriteLine(e.ToString());

                Console.WriteLine("Não foi possível realizar a conexão.");

            }
            return con;
        }

        // Método para verificar se a conexão está aberta:
        public bool ConexaoAberta(MySqlConnection con)
        {
            return (con.State == ConnectionState.Open);
        }

        // Método para desconectar:
        public void Desconectar(MySqlConnection con)
        {
            try
            {
                con.Close();
            }
            catch (MySqlException e)
            {

                Console.WriteLine(e.ToString());

                Console.WriteLine("Não foi possível encerrar a conexão.");
            }
        }
    }
}
