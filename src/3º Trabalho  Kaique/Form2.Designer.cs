namespace _3º_Trabalho__Kaique
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTtitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBXprioridade = new System.Windows.Forms.ComboBox();
            this.CBXsetor = new System.Windows.Forms.ComboBox();
            this.CBXusuario = new System.Windows.Forms.ComboBox();
            this.BTNenviar = new System.Windows.Forms.Button();
            this.TXTdescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RBpronto = new System.Windows.Forms.RadioButton();
            this.RBfazendo = new System.Windows.Forms.RadioButton();
            this.RBafazer = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.RBpronto);
            this.groupBox1.Controls.Add(this.RBfazendo);
            this.groupBox1.Controls.Add(this.RBafazer);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXTtitulo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CBXprioridade);
            this.groupBox1.Controls.Add(this.CBXsetor);
            this.groupBox1.Controls.Add(this.CBXusuario);
            this.groupBox1.Controls.Add(this.BTNenviar);
            this.groupBox1.Controls.Add(this.TXTdescricao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(181, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 277);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crie uma tarefa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Título";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Setor";
            // 
            // TXTtitulo
            // 
            this.TXTtitulo.Location = new System.Drawing.Point(21, 45);
            this.TXTtitulo.Multiline = true;
            this.TXTtitulo.Name = "TXTtitulo";
            this.TXTtitulo.Size = new System.Drawing.Size(205, 24);
            this.TXTtitulo.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prioridade";
            // 
            // CBXprioridade
            // 
            this.CBXprioridade.FormattingEnabled = true;
            this.CBXprioridade.Items.AddRange(new object[] {
            "urgente"});
            this.CBXprioridade.Location = new System.Drawing.Point(249, 166);
            this.CBXprioridade.Name = "CBXprioridade";
            this.CBXprioridade.Size = new System.Drawing.Size(140, 24);
            this.CBXprioridade.TabIndex = 4;
            // 
            // CBXsetor
            // 
            this.CBXsetor.FormattingEnabled = true;
            this.CBXsetor.Items.AddRange(new object[] {
            "produção"});
            this.CBXsetor.Location = new System.Drawing.Point(249, 108);
            this.CBXsetor.Name = "CBXsetor";
            this.CBXsetor.Size = new System.Drawing.Size(140, 24);
            this.CBXsetor.TabIndex = 3;
            // 
            // CBXusuario
            // 
            this.CBXusuario.FormattingEnabled = true;
            this.CBXusuario.Items.AddRange(new object[] {
            "admin"});
            this.CBXusuario.Location = new System.Drawing.Point(249, 43);
            this.CBXusuario.Name = "CBXusuario";
            this.CBXusuario.Size = new System.Drawing.Size(140, 24);
            this.CBXusuario.TabIndex = 2;
            // 
            // BTNenviar
            // 
            this.BTNenviar.Location = new System.Drawing.Point(31, 248);
            this.BTNenviar.Name = "BTNenviar";
            this.BTNenviar.Size = new System.Drawing.Size(75, 23);
            this.BTNenviar.TabIndex = 5;
            this.BTNenviar.Text = "Enviar";
            this.BTNenviar.UseVisualStyleBackColor = true;
            this.BTNenviar.Click += new System.EventHandler(this.BTNenviar_Click);
            // 
            // TXTdescricao
            // 
            this.TXTdescricao.Location = new System.Drawing.Point(21, 117);
            this.TXTdescricao.Multiline = true;
            this.TXTdescricao.Name = "TXTdescricao";
            this.TXTdescricao.Size = new System.Drawing.Size(205, 73);
            this.TXTdescricao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(1, -7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 76);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "CRIAR TAREFAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(344, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cadastro de Usuários";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(546, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Criar Tarefas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(697, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tarefas";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // RBpronto
            // 
            this.RBpronto.AutoSize = true;
            this.RBpronto.Location = new System.Drawing.Point(296, 209);
            this.RBpronto.Name = "RBpronto";
            this.RBpronto.Size = new System.Drawing.Size(64, 20);
            this.RBpronto.TabIndex = 21;
            this.RBpronto.TabStop = true;
            this.RBpronto.Text = "Pronto";
            this.RBpronto.UseVisualStyleBackColor = true;
            // 
            // RBfazendo
            // 
            this.RBfazendo.AutoSize = true;
            this.RBfazendo.Location = new System.Drawing.Point(176, 209);
            this.RBfazendo.Name = "RBfazendo";
            this.RBfazendo.Size = new System.Drawing.Size(78, 20);
            this.RBfazendo.TabIndex = 20;
            this.RBfazendo.TabStop = true;
            this.RBfazendo.Text = "Fazendo";
            this.RBfazendo.UseVisualStyleBackColor = true;
            // 
            // RBafazer
            // 
            this.RBafazer.AutoSize = true;
            this.RBafazer.Location = new System.Drawing.Point(40, 209);
            this.RBafazer.Name = "RBafazer";
            this.RBafazer.Size = new System.Drawing.Size(66, 20);
            this.RBafazer.TabIndex = 19;
            this.RBafazer.TabStop = true;
            this.RBafazer.Text = "A fazer";
            this.RBafazer.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNenviar;
        private System.Windows.Forms.TextBox TXTdescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBXusuario;
        private System.Windows.Forms.ComboBox CBXprioridade;
        private System.Windows.Forms.ComboBox CBXsetor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXTtitulo;
        private System.Windows.Forms.RadioButton RBpronto;
        private System.Windows.Forms.RadioButton RBfazendo;
        private System.Windows.Forms.RadioButton RBafazer;
    }
}