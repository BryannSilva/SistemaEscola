using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaSistemaEscola;

namespace SistemaEscola.Views
{
    public partial class MenuAlunos : Form
    {
        int idSelecionado = 0;

        public MenuAlunos()
        {
            InitializeComponent();
            AtualizarDgv();
        }

        public void AtualizarDgv()
        {
            dgvAlunos.DataSource = Banco.AlunoDAO.ListarTudo();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Verificar se os campos estão vazios:
            if (txbNomeCad.Text.Length >= 2)
            {
                //Instanciar o aluno:
                Aluno aluno = new Aluno();
                
                try
                {
                    aluno.Nome = txbNomeCad.Text;                   
                    
                    //Enviar para o banco e verificar se deu certo:
                    if (Banco.AlunoDAO.Cadastrar(aluno))
                    {
                        MessageBox.Show("Aluno cadastrado com sucesso!");
                        //Limpar os campos
                        txbNomeCad.Clear();                        

                        //Atualizar o dgv:
                        AtualizarDgv();
                    }
                    else
                    {
                        MessageBox.Show("Verifique as informações digitadas!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao cadastrar aluno!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbNomeEdi.Text.Length >= 2)
            {
                Aluno aluno = new Aluno();

                try
                {
                    aluno.Id = idSelecionado;
                    aluno.Nome = txbNomeEdi.Text;                   

                    if (Banco.AlunoDAO.Editar(aluno))
                    {
                        MessageBox.Show("Aluno editado com sucesso!");
                        //Limpar os campos
                        txbNomeEdi.Clear();                        

                        //Atualizar o dgv:
                        AtualizarDgv();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao editar aluno!", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Verifique as informações digitadas!", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ativar os groupboxes:            
            grbEditar.Enabled = true;
            grbRemover.Enabled = true;

            // Obter o número da linha selecionada:
            int linhaSelecionada = dgvAlunos.CurrentCell.RowIndex;
            // Obter toda a linha selecionada:
            var dadosLinha = dgvAlunos.Rows[linhaSelecionada];

            // Popular os campos do editar:
            txbNomeEdi.Text = dadosLinha.Cells[1].Value.ToString();           

            // Popular o remover:
            lblNomeRemover.Text = dadosLinha.Cells[0].Value.ToString() + " - "
                 + dadosLinha.Cells[1].Value.ToString();

            // Salvar o id na variável global:
            this.idSelecionado = (int)dadosLinha.Cells[0].Value;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Tem certeza que deseja remover o seguinte aluno?\n"
                + lblNomeRemover.Text, "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                //Apagar:
                if (Banco.AlunoDAO.Remover(this.idSelecionado) != -1)
                {
                    MessageBox.Show("Aluno removido com sucesso!", "",
                        MessageBoxButtons.OK);

                    AtualizarDgv();
                    //Desativar os groupboxes:
                    grbEditar.Enabled = false;
                    grbRemover.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Erro ao remover o aluno!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            dgvAlunos.DataSource = Banco.AlunoDAO.Filtrar(txbFiltrar.Text);           
        }
    }
}
