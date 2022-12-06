namespace SistemaEscola.Views
{
    partial class MenuAlunos
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
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbNomeEdi = new System.Windows.Forms.TextBox();
            this.lblNomeEdi = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbRemover = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblNomeRemover = new System.Windows.Forms.Label();
            this.txbFiltrar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbRemover.SuspendLayout();
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
            this.dgvAlunos.Location = new System.Drawing.Point(12, 48);
            this.dgvAlunos.MultiSelect = false;
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.Size = new System.Drawing.Size(326, 287);
            this.dgvAlunos.TabIndex = 0;
            this.dgvAlunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellClick);
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.txbNomeCad);
            this.grbCadastrar.Controls.Add(this.lblNomeCad);
            this.grbCadastrar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastrar.Location = new System.Drawing.Point(355, 48);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(325, 135);
            this.grbCadastrar.TabIndex = 1;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(14, 77);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(296, 36);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeCad.Location = new System.Drawing.Point(65, 34);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(245, 26);
            this.txbNomeCad.TabIndex = 1;
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCad.Location = new System.Drawing.Point(10, 36);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(49, 20);
            this.lblNomeCad.TabIndex = 0;
            this.lblNomeCad.Text = "Nome:";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbNomeEdi);
            this.grbEditar.Controls.Add(this.lblNomeEdi);
            this.grbEditar.Enabled = false;
            this.grbEditar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.Location = new System.Drawing.Point(355, 200);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(325, 135);
            this.grbEditar.TabIndex = 2;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(14, 77);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(296, 36);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbNomeEdi
            // 
            this.txbNomeEdi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeEdi.Location = new System.Drawing.Point(65, 34);
            this.txbNomeEdi.Name = "txbNomeEdi";
            this.txbNomeEdi.Size = new System.Drawing.Size(245, 26);
            this.txbNomeEdi.TabIndex = 1;
            // 
            // lblNomeEdi
            // 
            this.lblNomeEdi.AutoSize = true;
            this.lblNomeEdi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEdi.Location = new System.Drawing.Point(10, 36);
            this.lblNomeEdi.Name = "lblNomeEdi";
            this.lblNomeEdi.Size = new System.Drawing.Size(49, 20);
            this.lblNomeEdi.TabIndex = 0;
            this.lblNomeEdi.Text = "Nome:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(72, 25);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Alunos";
            // 
            // grbRemover
            // 
            this.grbRemover.Controls.Add(this.btnRemover);
            this.grbRemover.Controls.Add(this.lblNomeRemover);
            this.grbRemover.Enabled = false;
            this.grbRemover.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRemover.Location = new System.Drawing.Point(154, 372);
            this.grbRemover.Name = "grbRemover";
            this.grbRemover.Size = new System.Drawing.Size(423, 81);
            this.grbRemover.TabIndex = 4;
            this.grbRemover.TabStop = false;
            this.grbRemover.Text = "Remover";
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemover.Location = new System.Drawing.Point(267, 26);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(150, 36);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "REMOVER";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblNomeRemover
            // 
            this.lblNomeRemover.AutoSize = true;
            this.lblNomeRemover.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNomeRemover.Location = new System.Drawing.Point(6, 34);
            this.lblNomeRemover.Name = "lblNomeRemover";
            this.lblNomeRemover.Size = new System.Drawing.Size(70, 20);
            this.lblNomeRemover.TabIndex = 0;
            this.lblNomeRemover.Text = "ID - Nome";
            // 
            // txbFiltrar
            // 
            this.txbFiltrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFiltrar.Location = new System.Drawing.Point(93, 12);
            this.txbFiltrar.Name = "txbFiltrar";
            this.txbFiltrar.Size = new System.Drawing.Size(245, 26);
            this.txbFiltrar.TabIndex = 5;
            this.txbFiltrar.TextChanged += new System.EventHandler(this.txbFiltrar_TextChanged);
            // 
            // MenuAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 483);
            this.Controls.Add(this.txbFiltrar);
            this.Controls.Add(this.grbRemover);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvAlunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAlunos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbRemover.ResumeLayout(false);
            this.grbRemover.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbNomeEdi;
        private System.Windows.Forms.Label lblNomeEdi;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbRemover;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblNomeRemover;
        private System.Windows.Forms.TextBox txbFiltrar;
    }
}