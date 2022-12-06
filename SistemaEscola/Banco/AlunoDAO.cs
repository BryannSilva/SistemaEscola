using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaSistemaEscola;

namespace SistemaEscola.Banco
{
    public class AlunoDAO
    {
        public static DataTable ListarTudo()
        {
            string comando = "SELECT * FROM alunos";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();

            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());

            conexaoBD.Desconectar(con);

            return tabela;
        }

        public static bool Cadastrar(Aluno a)
        {
            string comando = "INSERT INTO alunos (nome) " +
                "VALUES (@nome)";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);


            cmd.Parameters.AddWithValue("@nome", a.Nome);            

            cmd.Prepare();

            try
            {
                if (cmd.ExecuteNonQuery() != 0)
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }

        }

        public static bool Editar(Aluno a)
        {
            string comando = "UPDATE alunos SET nome = @nome WHERE id = @id";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome", a.Nome);
            cmd.Parameters.AddWithValue("@id", a.Id);
            


            cmd.Prepare();

            try
            {
                if (cmd.ExecuteNonQuery() != 0)
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }

        }

        public static int Remover(int id)
        {
            string comando = "DELETE FROM alunos WHERE id = @id";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.Prepare();

            try
            {
                int linhasRemovidas = cmd.ExecuteNonQuery();
                conexaoBD.Desconectar(con);
                return linhasRemovidas;
            }
            catch
            {
                conexaoBD.Desconectar(con);
                // Em caso de erro, devolver -1:
                return -1;
            }
        }


        public static DataTable Filtrar(string nome)
        {
            string comando = "SELECT * FROM alunos WHERE nome LIKE @nome";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome", '%'+nome+'%');

            cmd.Prepare();

            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());

            conexaoBD.Desconectar(con);

            return tabela;
        }
    }
}
