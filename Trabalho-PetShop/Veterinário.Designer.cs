namespace Trabalho_PetShop
{
    partial class Veterinario
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
            System.Windows.Forms.TextBox txtEnderecoAgendamento;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNomeAgendamento = new System.Windows.Forms.TextBox();
            this.txtNomeAnimalAgendamento = new System.Windows.Forms.TextBox();
            this.txtsintomasAgendamento = new System.Windows.Forms.TextBox();
            this.txtRaçaAgendamento = new System.Windows.Forms.TextBox();
            this.cbPrecisaBuscar = new System.Windows.Forms.ComboBox();
            this.cbEstadoAgendamento = new System.Windows.Forms.ComboBox();
            this.mtbCPFAgendamento = new System.Windows.Forms.MaskedTextBox();
            this.nudGatoMorreuAgendamento = new System.Windows.Forms.NumericUpDown();
            this.nudIdadAnimalAgendamento = new System.Windows.Forms.NumericUpDown();
            this.txtDiasSintomasAgendamento = new System.Windows.Forms.TextBox();
            this.btnAgendarVeterinario = new System.Windows.Forms.Button();
            txtEnderecoAgendamento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudGatoMorreuAgendamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdadAnimalAgendamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agendamento para Veterinário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(613, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precisa ser buscado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(613, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Raça";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(165, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nome do animal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(613, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Idade do animal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Quais sintomas ele apresenta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(613, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Quantos dias ele esta assim";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Se for um gato, uantas vezes ele ja morreu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(613, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Endereço";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(420, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "CPF";
            // 
            // txtNomeAgendamento
            // 
            this.txtNomeAgendamento.Location = new System.Drawing.Point(277, 45);
            this.txtNomeAgendamento.Name = "txtNomeAgendamento";
            this.txtNomeAgendamento.Size = new System.Drawing.Size(143, 20);
            this.txtNomeAgendamento.TabIndex = 12;
            // 
            // txtNomeAnimalAgendamento
            // 
            this.txtNomeAnimalAgendamento.Location = new System.Drawing.Point(277, 95);
            this.txtNomeAnimalAgendamento.Name = "txtNomeAnimalAgendamento";
            this.txtNomeAnimalAgendamento.Size = new System.Drawing.Size(143, 20);
            this.txtNomeAnimalAgendamento.TabIndex = 13;
            // 
            // txtsintomasAgendamento
            // 
            this.txtsintomasAgendamento.Location = new System.Drawing.Point(277, 121);
            this.txtsintomasAgendamento.Name = "txtsintomasAgendamento";
            this.txtsintomasAgendamento.Size = new System.Drawing.Size(143, 20);
            this.txtsintomasAgendamento.TabIndex = 14;
            // 
            // txtRaçaAgendamento
            // 
            this.txtRaçaAgendamento.Location = new System.Drawing.Point(798, 68);
            this.txtRaçaAgendamento.Name = "txtRaçaAgendamento";
            this.txtRaçaAgendamento.Size = new System.Drawing.Size(143, 20);
            this.txtRaçaAgendamento.TabIndex = 15;
            // 
            // txtEnderecoAgendamento
            // 
            txtEnderecoAgendamento.Location = new System.Drawing.Point(798, 146);
            txtEnderecoAgendamento.Name = "txtEnderecoAgendamento";
            txtEnderecoAgendamento.Size = new System.Drawing.Size(143, 20);
            txtEnderecoAgendamento.TabIndex = 16;
            txtEnderecoAgendamento.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // cbPrecisaBuscar
            // 
            this.cbPrecisaBuscar.FormattingEnabled = true;
            this.cbPrecisaBuscar.Location = new System.Drawing.Point(277, 68);
            this.cbPrecisaBuscar.Name = "cbPrecisaBuscar";
            this.cbPrecisaBuscar.Size = new System.Drawing.Size(143, 21);
            this.cbPrecisaBuscar.TabIndex = 17;
            // 
            // cbEstadoAgendamento
            // 
            this.cbEstadoAgendamento.FormattingEnabled = true;
            this.cbEstadoAgendamento.Location = new System.Drawing.Point(798, 39);
            this.cbEstadoAgendamento.Name = "cbEstadoAgendamento";
            this.cbEstadoAgendamento.Size = new System.Drawing.Size(143, 21);
            this.cbEstadoAgendamento.TabIndex = 18;
            // 
            // mtbCPFAgendamento
            // 
            this.mtbCPFAgendamento.Location = new System.Drawing.Point(391, 203);
            this.mtbCPFAgendamento.Name = "mtbCPFAgendamento";
            this.mtbCPFAgendamento.Size = new System.Drawing.Size(100, 20);
            this.mtbCPFAgendamento.TabIndex = 19;
            // 
            // nudGatoMorreuAgendamento
            // 
            this.nudGatoMorreuAgendamento.Location = new System.Drawing.Point(277, 147);
            this.nudGatoMorreuAgendamento.Name = "nudGatoMorreuAgendamento";
            this.nudGatoMorreuAgendamento.Size = new System.Drawing.Size(120, 20);
            this.nudGatoMorreuAgendamento.TabIndex = 20;
            // 
            // nudIdadAnimalAgendamento
            // 
            this.nudIdadAnimalAgendamento.Location = new System.Drawing.Point(798, 94);
            this.nudIdadAnimalAgendamento.Name = "nudIdadAnimalAgendamento";
            this.nudIdadAnimalAgendamento.Size = new System.Drawing.Size(120, 20);
            this.nudIdadAnimalAgendamento.TabIndex = 22;
            // 
            // txtDiasSintomasAgendamento
            // 
            this.txtDiasSintomasAgendamento.Location = new System.Drawing.Point(798, 118);
            this.txtDiasSintomasAgendamento.Name = "txtDiasSintomasAgendamento";
            this.txtDiasSintomasAgendamento.Size = new System.Drawing.Size(143, 20);
            this.txtDiasSintomasAgendamento.TabIndex = 23;
            // 
            // btnAgendarVeterinario
            // 
            this.btnAgendarVeterinario.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarVeterinario.Location = new System.Drawing.Point(404, 252);
            this.btnAgendarVeterinario.Name = "btnAgendarVeterinario";
            this.btnAgendarVeterinario.Size = new System.Drawing.Size(75, 23);
            this.btnAgendarVeterinario.TabIndex = 24;
            this.btnAgendarVeterinario.Text = "Agendar";
            this.btnAgendarVeterinario.UseVisualStyleBackColor = true;
            // 
            // Veterinário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 448);
            this.Controls.Add(this.btnAgendarVeterinario);
            this.Controls.Add(this.txtDiasSintomasAgendamento);
            this.Controls.Add(this.nudIdadAnimalAgendamento);
            this.Controls.Add(this.nudGatoMorreuAgendamento);
            this.Controls.Add(this.mtbCPFAgendamento);
            this.Controls.Add(this.cbEstadoAgendamento);
            this.Controls.Add(this.cbPrecisaBuscar);
            this.Controls.Add(txtEnderecoAgendamento);
            this.Controls.Add(this.txtRaçaAgendamento);
            this.Controls.Add(this.txtsintomasAgendamento);
            this.Controls.Add(this.txtNomeAnimalAgendamento);
            this.Controls.Add(this.txtNomeAgendamento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Veterinário";
            this.Text = "Veterinário";
            ((System.ComponentModel.ISupportInitialize)(this.nudGatoMorreuAgendamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdadAnimalAgendamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNomeAgendamento;
        private System.Windows.Forms.TextBox txtNomeAnimalAgendamento;
        private System.Windows.Forms.TextBox txtsintomasAgendamento;
        private System.Windows.Forms.TextBox txtRaçaAgendamento;
        private System.Windows.Forms.ComboBox cbPrecisaBuscar;
        private System.Windows.Forms.ComboBox cbEstadoAgendamento;
        private System.Windows.Forms.MaskedTextBox mtbCPFAgendamento;
        private System.Windows.Forms.NumericUpDown nudGatoMorreuAgendamento;
        private System.Windows.Forms.NumericUpDown nudIdadAnimalAgendamento;
        private System.Windows.Forms.TextBox txtDiasSintomasAgendamento;
        private System.Windows.Forms.Button btnAgendarVeterinario;
    }
}