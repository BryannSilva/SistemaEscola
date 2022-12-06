namespace SistemaEscola.Views
{
    partial class MenuNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuNotas));
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.lblDisciplina1 = new System.Windows.Forms.Label();
            this.lblIdNome = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.txbNota = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cmbDisciplina = new System.Windows.Forms.ComboBox();
            this.txbFiltrar = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.lblNotaCad = new System.Windows.Forms.Label();
            this.txbNotaCad = new System.Windows.Forms.TextBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.cmbDisciplinaCad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.grbInfo.SuspendLayout();
            this.grbEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            this.dgvAlunos.AllowUserToOrderColumns = true;
            this.dgvAlunos.AllowUserToResizeColumns = false;
            this.dgvAlunos.AllowUserToResizeRows = false;
            this.dgvAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(12, 47);
            this.dgvAlunos.MultiSelect = false;
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.Size = new System.Drawing.Size(615, 235);
            this.dgvAlunos.TabIndex = 0;
            this.dgvAlunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellClick);
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.lblDisciplina1);
            this.grbInfo.Controls.Add(this.lblIdNome);
            this.grbInfo.Enabled = false;
            this.grbInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfo.Location = new System.Drawing.Point(13, 288);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(283, 317);
            this.grbInfo.TabIndex = 1;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Informações";
            // 
            // lblDisciplina1
            // 
            this.lblDisciplina1.AutoSize = true;
            this.lblDisciplina1.Location = new System.Drawing.Point(7, 73);
            this.lblDisciplina1.Name = "lblDisciplina1";
            this.lblDisciplina1.Size = new System.Drawing.Size(0, 20);
            this.lblDisciplina1.TabIndex = 1;
            // 
            // lblIdNome
            // 
            this.lblIdNome.AutoSize = true;
            this.lblIdNome.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdNome.Location = new System.Drawing.Point(7, 36);
            this.lblIdNome.Name = "lblIdNome";
            this.lblIdNome.Size = new System.Drawing.Size(93, 25);
            this.lblIdNome.TabIndex = 0;
            this.lblIdNome.Text = "ID - Nome";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.lblNota);
            this.grbEditar.Controls.Add(this.txbNota);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.cmbDisciplina);
            this.grbEditar.Enabled = false;
            this.grbEditar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.Location = new System.Drawing.Point(418, 288);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(209, 159);
            this.grbEditar.TabIndex = 2;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar notas";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(16, 72);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(75, 20);
            this.lblNota.TabIndex = 3;
            this.lblNota.Text = "Nova nota:";
            // 
            // txbNota
            // 
            this.txbNota.Location = new System.Drawing.Point(97, 70);
            this.txbNota.Name = "txbNota";
            this.txbNota.Size = new System.Drawing.Size(94, 26);
            this.txbNota.TabIndex = 2;
            this.txbNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(16, 105);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(175, 32);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cmbDisciplina
            // 
            this.cmbDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDisciplina.FormattingEnabled = true;
            this.cmbDisciplina.Location = new System.Drawing.Point(16, 25);
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.Size = new System.Drawing.Size(175, 28);
            this.cmbDisciplina.TabIndex = 0;
            this.cmbDisciplina.SelectedIndexChanged += new System.EventHandler(this.cmbDisciplina_SelectedIndexChanged);
            // 
            // txbFiltrar
            // 
            this.txbFiltrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFiltrar.Location = new System.Drawing.Point(266, 15);
            this.txbFiltrar.Name = "txbFiltrar";
            this.txbFiltrar.Size = new System.Drawing.Size(361, 26);
            this.txbFiltrar.TabIndex = 3;
            this.txbFiltrar.TextChanged += new System.EventHandler(this.txbFiltrar_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(61, 25);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Notas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(602, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.lblNotaCad);
            this.grbCadastrar.Controls.Add(this.txbNotaCad);
            this.grbCadastrar.Controls.Add(this.btnCad);
            this.grbCadastrar.Controls.Add(this.cmbDisciplinaCad);
            this.grbCadastrar.Enabled = false;
            this.grbCadastrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastrar.Location = new System.Drawing.Point(418, 453);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(209, 159);
            this.grbCadastrar.TabIndex = 4;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar Notas";
            // 
            // lblNotaCad
            // 
            this.lblNotaCad.AutoSize = true;
            this.lblNotaCad.Location = new System.Drawing.Point(16, 72);
            this.lblNotaCad.Name = "lblNotaCad";
            this.lblNotaCad.Size = new System.Drawing.Size(75, 20);
            this.lblNotaCad.TabIndex = 3;
            this.lblNotaCad.Text = "Nova nota:";
            // 
            // txbNotaCad
            // 
            this.txbNotaCad.Location = new System.Drawing.Point(97, 70);
            this.txbNotaCad.Name = "txbNotaCad";
            this.txbNotaCad.Size = new System.Drawing.Size(94, 26);
            this.txbNotaCad.TabIndex = 2;
            this.txbNotaCad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCad
            // 
            this.btnCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCad.Location = new System.Drawing.Point(16, 105);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(175, 32);
            this.btnCad.TabIndex = 1;
            this.btnCad.Text = "CADASTRAR";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // cmbDisciplinaCad
            // 
            this.cmbDisciplinaCad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisciplinaCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDisciplinaCad.FormattingEnabled = true;
            this.cmbDisciplinaCad.Location = new System.Drawing.Point(16, 25);
            this.cmbDisciplinaCad.Name = "cmbDisciplinaCad";
            this.cmbDisciplinaCad.Size = new System.Drawing.Size(175, 28);
            this.cmbDisciplinaCad.TabIndex = 0;
            // 
            // MenuNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 617);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txbFiltrar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbInfo);
            this.Controls.Add(this.dgvAlunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuNotas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.Label lblDisciplina1;
        private System.Windows.Forms.Label lblIdNome;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txbNota;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cmbDisciplina;
        private System.Windows.Forms.TextBox txbFiltrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.Label lblNotaCad;
        private System.Windows.Forms.TextBox txbNotaCad;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.ComboBox cmbDisciplinaCad;
    }
}