using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _3º_Trabalho__Kaique
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Listas para armazenar os registros
        private List<string> titulos = new List<string>();
        private List<string> descricoes = new List<string>();
        private List<string> usuarios = new List<string>();
        private List<string> setores = new List<string>();
        private List<string> prioridades = new List<string>();
        private List<string> statusList = new List<string>();

        private int indiceAtual = 0; // Índice de controle para navegação
        private string comboStatus = ""; // Status selecionado

        private void BTNbuscar_Click(object sender, EventArgs e)
        {
            string connString = "server=localhost;database=gerenciador;uid=root;pwd=;";

            if (CBXstatus.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um status para buscar.");
                return;
            }

            comboStatus = CBXstatus.SelectedItem.ToString().Trim();
            BuscarRegistros(connString, comboStatus);
        }

        private void BuscarRegistros(string connString, string status)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string selectQuery = @"SELECT titulo, descricao, usuario, setor, prioridade, status FROM cadastro WHERE status = @status ORDER BY id DESC";

                    using (MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn))
                    {
                        selectCmd.Parameters.AddWithValue("@status", status);

                        using (MySqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            titulos.Clear();
                            descricoes.Clear();
                            usuarios.Clear();
                            setores.Clear();
                            prioridades.Clear();
                            statusList.Clear();

                            while (reader.Read())
                            {
                                titulos.Add(reader["titulo"].ToString());
                                descricoes.Add(reader["descricao"].ToString());
                                usuarios.Add(reader["usuario"].ToString());
                                setores.Add(reader["setor"].ToString());
                                prioridades.Add(reader["prioridade"].ToString());
                                statusList.Add(reader["status"].ToString());
                            }

                            indiceAtual = 0;
                            AtualizarInterface();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void AtualizarInterface()
        {
            if (titulos.Count == 0)
            {
                MessageBox.Show("Nenhum registro encontrado para o status fornecido.");
                return;
            }

            if (indiceAtual < titulos.Count)
            {
                TXTtitulo1.Text = titulos[indiceAtual];
                TXTdescricao1.Text = descricoes[indiceAtual];
                CBXusuario1.SelectedItem = usuarios[indiceAtual];
                CBXsetor1.SelectedItem = setores[indiceAtual];
                CBXprioridade1.SelectedItem = prioridades[indiceAtual];
                AtualizarStatusRadioButton(statusList[indiceAtual], 1);
            }
            else
            {
                LimparCampos(1);
            }

            if (indiceAtual + 1 < titulos.Count)
            {
                TXTtitulo2.Text = titulos[indiceAtual + 1];
                TXTdescricao2.Text = descricoes[indiceAtual + 1];
                CBXusuario2.SelectedItem = usuarios[indiceAtual + 1];
                CBXsetor2.SelectedItem = setores[indiceAtual + 1];
                CBXprioridade2.SelectedItem = prioridades[indiceAtual + 1];
                AtualizarStatusRadioButton(statusList[indiceAtual + 1], 2);
            }
            else
            {
                LimparCampos(2);
            }
        }

        private void AtualizarStatusRadioButton(string status, int grupo)
        {
            if (grupo == 1)
            {
                RBafazer.Checked = status == "A fazer";
                RBfazendo.Checked = status == "Fazendo";
                RBpronto.Checked = status == "Pronto";
            }
            else
            {
                RBafazer2.Checked = status == "A fazer";
                RBfazendo2.Checked = status == "Fazendo";
                RBpronto2.Checked = status == "Pronto";
            }
        }

        private void LimparCampos(int grupo)
        {
            if (grupo == 1)
            {
                TXTtitulo1.Text = "";
                TXTdescricao1.Text = "";
                CBXusuario1.SelectedItem = null;
                CBXsetor1.SelectedItem = null;
                CBXprioridade1.SelectedItem = null;
                RBafazer.Checked = false;
                RBfazendo.Checked = false;
                RBpronto.Checked = false;
            }
            else
            {
                TXTtitulo2.Text = "";
                TXTdescricao2.Text = "";
                CBXusuario2.SelectedItem = null;
                CBXsetor2.SelectedItem = null;
                CBXprioridade2.SelectedItem = null;
                RBafazer2.Checked = false;
                RBfazendo2.Checked = false;
                RBpronto2.Checked = false;
            }
        }

        private void BTNanterior_Click(object sender, EventArgs e)
        {
            if (indiceAtual - 2 >= 0)
            {
                indiceAtual -= 2;
                AtualizarInterface();
            }
        }

     

        // Funções recuperadas do código antigo

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // Implementação vazia conforme o código antigo.
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Implementação vazia conforme o código antigo.
        }

        private void button5_Click(object sender, EventArgs e)
        { 
             if (indiceAtual + 2 < titulos.Count)
            {
                indiceAtual += 2;
                AtualizarInterface();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Implementação vazia conforme o código antigo.
        }

        private void lblId1_Click(object sender, EventArgs e)
        {
            // Implementação vazia conforme o código antigo.
        }

        private void lblId2_Click(object sender, EventArgs e)
        {
            // Implementação vazia conforme o código antigo.
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Implementação vazia conforme o código antigo.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Implementação vazia conforme o código antigo.
        }

        private void BTNenviar_Click(object sender, EventArgs e)
        {
            // Implementação vazia conforme o código antigo.
        }
    }
}
