namespace entra21_trabalho_02
{
    partial class ListaTosa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaTosa));
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.txtnsei = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvListaTosa = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTosa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(99, 121);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(356, 20);
            this.txtBusca.TabIndex = 20;
            // 
            // txtnsei
            // 
            this.txtnsei.AutoSize = true;
            this.txtnsei.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnsei.Location = new System.Drawing.Point(40, 121);
            this.txtnsei.Name = "txtnsei";
            this.txtnsei.Size = new System.Drawing.Size(56, 16);
            this.txtnsei.TabIndex = 19;
            this.txtnsei.Text = "Buscar";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(275, 71);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(95, 44);
            this.btnAtualizar.TabIndex = 18;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeletar.Location = new System.Drawing.Point(71, 71);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(89, 44);
            this.btnDeletar.TabIndex = 17;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(376, 71);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(85, 44);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvListaTosa
            // 
            this.dgvListaTosa.AllowUserToAddRows = false;
            this.dgvListaTosa.AllowUserToDeleteRows = false;
            this.dgvListaTosa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvListaTosa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTosa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Endereco,
            this.Altura,
            this.Peso});
            this.dgvListaTosa.Location = new System.Drawing.Point(27, 147);
            this.dgvListaTosa.Name = "dgvListaTosa";
            this.dgvListaTosa.ReadOnly = true;
            this.dgvListaTosa.Size = new System.Drawing.Size(446, 313);
            this.dgvListaTosa.TabIndex = 14;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Endereco
            // 
            this.Endereco.HeaderText = "Endereco";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            // 
            // Altura
            // 
            this.Altura.HeaderText = "Altura";
            this.Altura.Name = "Altura";
            this.Altura.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(166, 71);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(103, 44);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // ListaTosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(500, 506);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.txtnsei);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvListaTosa);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "ListaTosa";
            this.Text = "ListaTosa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTosa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label txtnsei;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvListaTosa;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
    }
}