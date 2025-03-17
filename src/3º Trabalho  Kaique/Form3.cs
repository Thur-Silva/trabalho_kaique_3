using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            ///
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

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
      
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblId1_Click(object sender, EventArgs e)
        {

        }

        private void lblId2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        // Variáveis de controle
        private int lastId = -1;  // Armazena o último id exibido (inicialmente nenhum)
        private string comboStatus = "";  // Renomeado de status para comboStatus

        private void BTNenviar_Click(object sender, EventArgs e)
        {
           
        }

        private void BuscarRegistros(string connString, string status, int offset)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // Modificar a consulta SQL para buscar dois registros, considerando o offset
                    string selectQuery = @"
                SELECT titulo, descricao, usuario, setor, prioridade, status, id
                FROM cadastro
                WHERE status = @status
                ORDER BY id DESC
                LIMIT 2 OFFSET @offset";  

                    using (MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn))
                    {
                        // Adiciona os parâmetros para evitar SQL Injection
                        selectCmd.Parameters.AddWithValue("@status", status);
                        selectCmd.Parameters.AddWithValue("@offset", offset);

                        using (MySqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                int count = 0;
                                int firstId = -1;  // Armazenar o primeiro id do conjunto de registros

                                while (reader.Read())
                                {
                                    count++;

                                    // Preencher o primeiro conjunto de campos (registro mais recente)
                                    if (count == 1)
                                    {
                                        TXTtitulo1.Text = reader["titulo"].ToString();
                                        TXTdescricao1.Text = reader["descricao"].ToString();
                                        CBXusuario1.SelectedItem = reader["usuario"].ToString();
                                        CBXsetor1.SelectedItem = reader["setor"].ToString();
                                        CBXprioridade1.SelectedItem = reader["prioridade"].ToString();

                                        // Preencher e ativar o radio button com base no status recuperado
                                        string recordStatus = reader["status"].ToString();
                                        switch (recordStatus)
                                        {
                                            case "A fazer":
                                                RBafazer.Checked = true;
                                                break;
                                            case "Fazendo":
                                                RBfazendo.Checked = true;
                                                break;
                                            case "Pronto":
                                                RBpronto.Checked = true;
                                                break;
                                            default:
                                                RBafazer.Checked = true; // Padrão
                                                break;
                                        }

                                        firstId = Convert.ToInt32(reader["id"]);
                                    }

                                    // Preencher o segundo conjunto de campos (registro mais antigo)
                                    if (count == 2)
                                    {
                                        TXTtitulo2.Text = reader["titulo"].ToString();
                                        TXTdescricao2.Text = reader["descricao"].ToString();
                                        CBXusuario2.SelectedItem = reader["usuario"].ToString();
                                        CBXsetor2.SelectedItem = reader["setor"].ToString();
                                        CBXprioridade2.SelectedItem = reader["prioridade"].ToString();

                                        // Preencher e ativar o radio button com base no status recuperado
                                        string recordStatus = reader["status"].ToString();
                                        switch (recordStatus)
                                        {
                                            case "A fazer":
                                                RBafazer2.Checked = true;
                                                break;
                                            case "Fazendo":
                                                RBfazendo2.Checked = true;
                                                break;
                                            case "Pronto":
                                                RBpronto2.Checked = true;
                                                break;
                                            default:
                                                RBafazer2.Checked = true; // Padrão
                                                break;
                                        }
                                    }
                                }

                              
                            }
                            else
                            {
                                MessageBox.Show("Nenhum registro encontrado para o status fornecido.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }


        private void BTNanterior_Click(object sender, EventArgs e)
        {
           
        }

        private void BTNbuscar_Click(object sender, EventArgs e)
        {
            string connString = "server=localhost;database=gerenciador;uid=root;pwd=;";

            // Captura o status selecionado
            if (CBXstatus.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um status para buscar.");
                return;
            }

            // Renomeia a variável aqui para "comboStatus"
            comboStatus = CBXstatus.SelectedItem.ToString().Trim();

            BuscarRegistros(connString, comboStatus, 0);  // Chama a função de busca com offset 0 (primeira vez)
        }
    }
}
