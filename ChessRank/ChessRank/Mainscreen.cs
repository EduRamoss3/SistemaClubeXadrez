using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChessRank.Entities;

namespace ChessRank
{
    public partial class Mainscreen : Form
    {


        public Mainscreen()
        {

            InitializeComponent();
            UpdateTable();
            tablePlayer.Columns["Id"].Visible = false;
            tablePlayer.Columns["Imagem"].Visible = false;
            tablePlayer.Columns["Name"].HeaderText = "Nome";
            tablePlayer.ScrollBars = ScrollBars.Vertical;
            tablePlayer.RightToLeft = RightToLeft.Yes;
            tablePlayer.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;


        }
        public void tablePlayer_CellClick(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(tablePlayer.SelectedRows[0].Cells[0].Value);

            byte[] imagemBytes = PlayerDataAcess.ObterImagemDoBancoDeDados(id);
            if (imagemBytes != null && imagemBytes.Length > 0)
            {
                using (MemoryStream stream = new MemoryStream(imagemBytes))
                {
                    Image imagem = Image.FromStream(stream);
                    pictureBox1.Image = imagem;
                }
            }
            else
            {
                // Se não houver imagem correspondente, limpar a PictureBox
                pictureBox1.Image = null;
            }
        }
        // Obter o ID selecionado na célula clicada



        public void UpdateTable()
        {
            tablePlayer.DataSource = Entities.PlayerDataAcess.takePlayers();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView16_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void newPlayer(object sender, EventArgs e)
        {

            new Registerscreen(this).Show();

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void editPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tablePlayer.SelectedRows[0].Cells[0].Value);
                new Registerscreen(this, id).Show();

            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Nenhum player foi selecionado para edição.");
            }
               

        }

        private void removePlayer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tablePlayer.SelectedRows[0].Cells[0].Value);
                if (PlayerDataAcess.RemovePlayer(id))
                {
                    MessageBox.Show("Player removido com sucesso!");
                    UpdateTable();
                }
                else
                {
                    MessageBox.Show("Erro ao remover jogador");
                }

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Nenhum player foi selecionado para ser removido.");
            }
               

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void tablePlayer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(tablePlayer.SelectedRows[0].Cells[0].Value);

            byte[] imagemBytes = PlayerDataAcess.ObterImagemDoBancoDeDados(id);
            if (imagemBytes != null && imagemBytes.Length > 0)
            {
                using (MemoryStream stream = new MemoryStream(imagemBytes))
                {
                    Image imagem = Image.FromStream(stream);
                    pictureBox1.Image = imagem;
                }
            }
            else
            {
                // Se não houver imagem correspondente, limpar a PictureBox
                pictureBox1.Image = null;
            }
            Player player = PlayerDataAcess.takingPlayerEdit(id);
            label7.Text = player.Rating.ToString();
            label4.Text = player.City;
            lblNamePlayer.Text = player.Name;
            lblEstado.Text = player.State;
            
            //lblRatingPlayer.Text = player.Rating.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        // Obter o ID selecionado na célula clicada
    }
}

