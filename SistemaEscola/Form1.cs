using SistemaEscola.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            MenuAlunos menuAlunos = new MenuAlunos();
            menuAlunos.ShowDialog();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            MenuNotas menuNotas = new MenuNotas();
            menuNotas.ShowDialog();
        }
    }
}
