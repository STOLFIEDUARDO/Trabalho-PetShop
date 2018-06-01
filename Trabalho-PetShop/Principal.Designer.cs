namespace entra21_trabalho_02
{
    partial class btnListar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnListar));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastroAnimais = new System.Windows.Forms.Button();
            this.btnCadastroTosa = new System.Windows.Forms.Button();
            this.btnCadastroPet = new System.Windows.Forms.Button();
            this.btnCadastroClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastros";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCadastroAnimais
            // 
            this.btnCadastroAnimais.BackColor = System.Drawing.Color.White;
            this.btnCadastroAnimais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroAnimais.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroAnimais.Image")));
            this.btnCadastroAnimais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroAnimais.Location = new System.Drawing.Point(45, 137);
            this.btnCadastroAnimais.Name = "btnCadastroAnimais";
            this.btnCadastroAnimais.Size = new System.Drawing.Size(233, 52);
            this.btnCadastroAnimais.TabIndex = 5;
            this.btnCadastroAnimais.Text = "CadastroAnimais";
            this.btnCadastroAnimais.UseVisualStyleBackColor = false;
            this.btnCadastroAnimais.Click += new System.EventHandler(this.btnCadastroCarrros_Click);
            // 
            // btnCadastroTosa
            // 
            this.btnCadastroTosa.BackColor = System.Drawing.Color.White;
            this.btnCadastroTosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroTosa.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroTosa.Image")));
            this.btnCadastroTosa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroTosa.Location = new System.Drawing.Point(359, 137);
            this.btnCadastroTosa.Name = "btnCadastroTosa";
            this.btnCadastroTosa.Size = new System.Drawing.Size(233, 52);
            this.btnCadastroTosa.TabIndex = 6;
            this.btnCadastroTosa.Text = "Cadastro Tosa e Banho";
            this.btnCadastroTosa.UseVisualStyleBackColor = false;
            this.btnCadastroTosa.Click += new System.EventHandler(this.btnCadastroMoveis_Click);
            // 
            // btnCadastroPet
            // 
            this.btnCadastroPet.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCadastroPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroPet.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroPet.Image")));
            this.btnCadastroPet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroPet.Location = new System.Drawing.Point(45, 285);
            this.btnCadastroPet.Name = "btnCadastroPet";
            this.btnCadastroPet.Size = new System.Drawing.Size(233, 52);
            this.btnCadastroPet.TabIndex = 7;
            this.btnCadastroPet.Text = "Cadastro de Pets";
            this.btnCadastroPet.UseVisualStyleBackColor = false;
            this.btnCadastroPet.Click += new System.EventHandler(this.btnCadastroComputadores_Click);
            // 
            // btnCadastroClientes
            // 
            this.btnCadastroClientes.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCadastroClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroClientes.Image")));
            this.btnCadastroClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroClientes.Location = new System.Drawing.Point(359, 285);
            this.btnCadastroClientes.Name = "btnCadastroClientes";
            this.btnCadastroClientes.Size = new System.Drawing.Size(233, 52);
            this.btnCadastroClientes.TabIndex = 8;
            this.btnCadastroClientes.Text = "Cadastro De Clientes";
            this.btnCadastroClientes.UseVisualStyleBackColor = false;
            this.btnCadastroClientes.Click += new System.EventHandler(this.btnCadstroRoupas_Click);
            // 
            // btnListar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(633, 506);
            this.Controls.Add(this.btnCadastroClientes);
            this.Controls.Add(this.btnCadastroPet);
            this.Controls.Add(this.btnCadastroTosa);
            this.Controls.Add(this.btnCadastroAnimais);
            this.Controls.Add(this.label1);
            this.Name = "btnListar";
            this.Text = "Cadastros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastroAnimais;
        private System.Windows.Forms.Button btnCadastroTosa;
        private System.Windows.Forms.Button btnCadastroPet;
        private System.Windows.Forms.Button btnCadastroClientes;
    }
}

