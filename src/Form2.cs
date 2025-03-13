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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();

            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BTNenviar_Click(object sender, EventArgs e)
        {
            string connString = "server=localhost;database=gerenciador;uid=root;pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    
                    string titulo = TXTtitulo.Text.Trim();
                    string descricao = TXTdescricao.Text.Trim();
                    string usuario = CBXusuario.SelectedItem != null ? CBXusuario.SelectedItem.ToString() : "";
                    string setor = CBXsetor.SelectedItem != null ? CBXsetor.SelectedItem.ToString() : "";
                    string prioridade = CBXprioridade.SelectedItem != null ? CBXprioridade.SelectedItem.ToString() : "";

                    // 2) Validação simples
                    if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(descricao) ||
                        string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(setor) ||
                        string.IsNullOrEmpty(prioridade))
                    {
                        MessageBox.Show("Por favor, preencha todos os campos antes de enviar.");
                        return;
                    }

                    // 3) Montar a query de inserção
                    string query = @"INSERT INTO cadastro 
                                (titulo, descricao, usuario, setor, prioridade) 
                             VALUES 
                                (@titulo, @descricao, @usuario, @setor, @prioridade)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // 4) Adicionar parâmetros
                        cmd.Parameters.AddWithValue("@titulo", titulo);
                        cmd.Parameters.AddWithValue("@descricao", descricao);
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@setor", setor);
                        cmd.Parameters.AddWithValue("@prioridade", prioridade);

                        // 5) Executar o comando
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro inserido com sucesso!");

                            // Limpar os campos após inserir
                            TXTtitulo.Clear();
                            TXTdescricao.Clear();
                            CBXusuario.SelectedIndex = -1;
                            CBXsetor.SelectedIndex = -1;
                            CBXprioridade.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível inserir o registro.");
                        }
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
