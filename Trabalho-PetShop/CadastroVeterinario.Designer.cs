namespace entra21_trabalho_02
{
    partial class CadastroVeterinario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeDaPessoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeAnimal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdadeAnimal = new System.Windows.Forms.TextBox();
            this.txtDiasAssim = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Completo";
            // 
            // txtNomeDaPessoa
            // 
            this.txtNomeDaPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDaPessoa.Location = new System.Drawing.Point(103, 26);
            this.txtNomeDaPessoa.Name = "txtNomeDaPessoa";
            this.txtNomeDaPessoa.Size = new System.Drawing.Size(232, 18);
            this.txtNomeDaPessoa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA ",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA ",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "P",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbEstado.Location = new System.Drawing.Point(103, 78);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prescisa buscar";
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSim.Location = new System.Drawing.Point(103, 130);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(42, 16);
            this.rbSim.TabIndex = 8;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNao.Location = new System.Drawing.Point(181, 130);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(43, 16);
            this.rbNao.TabIndex = 9;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Raça";
            // 
            // txtRaca
            // 
            this.txtRaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaca.Location = new System.Drawing.Point(103, 179);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(232, 18);
            this.txtRaca.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nome Animal";
            // 
            // txtNomeAnimal
            // 
            this.txtNomeAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAnimal.Location = new System.Drawing.Point(103, 228);
            this.txtNomeAnimal.Name = "txtNomeAnimal";
            this.txtNomeAnimal.Size = new System.Drawing.Size(232, 18);
            this.txtNomeAnimal.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(410, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sintomas";
            // 
            // txtSintomas
            // 
            this.txtSintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSintomas.Location = new System.Drawing.Point(468, 26);
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(232, 18);
            this.txtSintomas.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(391, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "Idade Animal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(358, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "Quantos dias assim";
            // 
            // txtIdadeAnimal
            // 
            this.txtIdadeAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdadeAnimal.Location = new System.Drawing.Point(468, 79);
            this.txtIdadeAnimal.Name = "txtIdadeAnimal";
            this.txtIdadeAnimal.Size = new System.Drawing.Size(232, 18);
            this.txtIdadeAnimal.TabIndex = 19;
            // 
            // txtDiasAssim
            // 
            this.txtDiasAssim.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiasAssim.Location = new System.Drawing.Point(468, 129);
            this.txtDiasAssim.Name = "txtDiasAssim";
            this.txtDiasAssim.Size = new System.Drawing.Size(232, 18);
            this.txtDiasAssim.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(435, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "CEP";
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(468, 179);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(232, 18);
            this.txtCep.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(410, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(468, 228);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(232, 18);
            this.txtEndereco.TabIndex = 24;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(231, 291);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 43);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(426, 291);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 43);
            this.btnSalvar.TabIndex = 33;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // CadastroVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(704, 349);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDiasAssim);
            this.Controls.Add(this.txtIdadeAnimal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSintomas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNomeAnimal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRaca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbNao);
            this.Controls.Add(this.rbSim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeDaPessoa);
            this.Controls.Add(this.label1);
            this.Name = "CadastroVeterinario";
            this.Text = "CadastroVeterinario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeDaPessoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeAnimal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSintomas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdadeAnimal;
        private System.Windows.Forms.TextBox txtDiasAssim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}