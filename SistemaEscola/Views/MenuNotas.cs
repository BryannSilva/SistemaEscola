using System;
using System.Collections;
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
    public partial class MenuNotas : Form
    {
        int idSelecionado = 0;

        public MenuNotas()
        {
            InitializeComponent();

            // Salvar o resultado da listagem de categorias em um objeto:
            var r = Banco.DisciplinaDAO.ListarDisciplinas();
            ArrayList rows = new ArrayList();
            // Converter esse objeto para array:
            foreach (DataRow dataRow in r.Rows)
            {
                rows.Add(string.Join(" - ", dataRow.ItemArray.Select(item => item.ToString())));
            }
            // Atribuir os valores nos cmbs:
            cmbDisciplina.DataSource = rows;
            cmbDisciplinaCad.DataSource = rows;
            

            AtualizarDgv();
        }

        public void AtualizarDgv()
        {
            dgvAlunos.DataSource = Banco.NotaDAO.ListarAlunos();           
        }

        private int obterIDdaString(string texto)
        {                       
            return int.Parse(texto.Split(' ')[0]);
        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {           

            // Obter o número da linha selecionada:
            int linhaSelecionada = dgvAlunos.CurrentCell.RowIndex;
            
            // Obter toda a linha selecionada:
            var dadosLinha = dgvAlunos.Rows[linhaSelecionada];            

            // Popular os campos do grbInfo:            
            lblIdNome.Text = dadosLinha.Cells[0].Value.ToString() + " - "
                  + dadosLinha.Cells[1].Value.ToString();
                      
            // Salvar o id na variável global:
            this.idSelecionado = (int)dadosLinha.Cells[0].Value;

            // Variável aux recebe dados da view_alunos:
            var view = Banco.NotaDAO.InfoView();

            lblDisciplina1.Text = "";

            int cont = 0;

                // Ativar o groupbox:           

                grbInfo.Enabled = true;
                grbEditar.Enabled = true;
            grbCadastrar.Enabled = false;

            for (int i = 0; i < view.Rows.Count; i++)
                {
                    if (view.Rows[i][1].ToString() == idSelecionado.ToString())
                    {
                        lblDisciplina1.Text += view.Rows[i][3].ToString() + " - ";
                        lblDisciplina1.Text += view.Rows[i][4].ToString() + "\n";
                        cont ++;                                   
                    }
                }
            
          
                if (cont == 0)
            {
                grbCadastrar.Enabled = true;
                grbInfo.Enabled = false;
                grbEditar.Enabled = false;
            }
                else if (cont == 2)
            {
                grbInfo.Enabled = true;
                grbEditar.Enabled = true;
            }
            else if (cont == 1)
            {
                grbInfo.Enabled = true;
                grbEditar.Enabled = true;
                grbCadastrar.Enabled = true;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbNota.Text.Length >= 1)
            {
                Nota nota = new Nota();
                                                
                try
                {                                    
                    nota.Notas = double.Parse(txbNota.Text.Replace(".", ","));
                    nota.IdDisciplina = obterIDdaString(cmbDisciplina.Text);
                    nota.IdAluno = this.idSelecionado;

                    if (Banco.NotaDAO.Editar(nota))
                    {
                        MessageBox.Show("Nota editada com sucesso!");
                        //Limpar os campos
                        txbNota.Clear();
                        lblDisciplina1.Text = "";

                        //Atualizar o dgv:
                        AtualizarDgv();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao editar nota!", "Erro",
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

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            dgvAlunos.DataSource = Banco.AlunoDAO.Filtrar(txbFiltrar.Text);
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            // Verificar se os campos estão vazios:
            if (txbNotaCad.Text.Length >= 2)
            {
                // Instanciar a nota:
                Nota nota = new Nota();

                // Obter as informações dos campos:
                nota.IdAluno = idSelecionado;
                nota.IdDisciplina = obterIDdaString(cmbDisciplinaCad.Text);
                nota.Notas = double.Parse(txbNotaCad.Text.Replace(".", ","));


                // Enviar para o banco e verificar se deu certo:
                if (Banco.NotaDAO.Cadastrar(nota))
                {
                    MessageBox.Show("produto cadastrado com sucesso!");

                    // Limpar os campos:
                    txbNotaCad.Clear();                    

                    // Atualizar o dgv:
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar nota!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
