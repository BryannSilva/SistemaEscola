using BibliotecaSistemaEscola;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Banco
{
    public class NotaDAO
    {
        public static DataTable ListarAlunos()
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

        public static DataTable InfoView()
        {
            string comando = "SELECT * FROM view_alunos";

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


        public static bool Editar(Nota nota)
        {
            string comando = "UPDATE notas SET nota = @nota, id_aluno = @id_aluno, " +
                "id_disciplina = @id_disciplina " +
                "WHERE id_aluno = @id_aluno AND id_disciplina = @id_disciplina";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            
            cmd.Parameters.AddWithValue("@nota", nota.Notas);
            cmd.Parameters.AddWithValue("@id_aluno", nota.IdAluno);
            cmd.Parameters.AddWithValue("@id_disciplina", nota.IdDisciplina);

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

        public static bool Cadastrar(Nota n)
        {
            string comando = "INSERT INTO notas (id_aluno, id_disciplina, nota) " +
                "VALUES (@id_aluno, @id_disciplina, @nota)";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id_aluno", n.IdAluno);
            cmd.Parameters.AddWithValue("@id_disciplina", n.IdDisciplina);
            cmd.Parameters.AddWithValue("@nota", n.Notas);          


            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }

        }
    }
}
