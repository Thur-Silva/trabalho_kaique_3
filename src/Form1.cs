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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();

            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "server=localhost;database=gerenciador;uid=root;pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                  
                    string nome = TXTnome.Text.Trim();
                    string email = TXTemail.Text.Trim();

               
                    if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email))
                    {
                        MessageBox.Show("Por favor, preencha os campos de nome e email.");
                        return;
                    }

                 
                    string query = "INSERT INTO usuario (nome, email) VALUES (@nome, @email)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);

                   
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registro inserido com sucesso!");
                      
                        TXTnome.Clear();
                        TXTemail.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao inserir o registro.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

            }
        }
    }
}