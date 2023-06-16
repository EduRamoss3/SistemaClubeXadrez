using ChessRank.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;
using System.IO;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace ChessRank
{
    public partial class Registerscreen : Form
    {

        private Mainscreen _mainscreen;
        private Player player;
        public Registerscreen(Mainscreen mainscreen)
        {
            _mainscreen = mainscreen;
            InitializeComponent();
        }
        public Registerscreen(Mainscreen mainscreen, int Id) // Reutilizando a tela register screen com base no ID do jogador
        {
            _mainscreen = mainscreen;
            InitializeComponent();
            player = PlayerDataAcess.takingPlayerEdit(Id);
            label1.Text = "EDITAR JOGADOR";
            PlayerToScreen(player);
            btnRegister.Visible = false;
            button1.Visible = true;
            lblDirectory.Visible = false;

        }
        private void PlayerToScreen(Player player) //Mandar as informaçoes do jogador para tela
        {
            lblId.Visible = true;
            btnBack.Visible = false;
            lblId.Text = player.Id.ToString();
            textName.Text = player.Name;
            textRating.Text = player.Rating.ToString();
            textCity.Text = player.City;
            lblDirectory.Text = player.Directory;

            textEstate.Text = player.State;

            if (player.Sex == "M")
            {
                radioMasc.Checked = true;
            }
            if (player.Sex == "F")
            {
                radioFemini.Checked = true;
            }
            try
            {
                byte[] imageBytes = PlayerDataAcess.ObterImagemDoBancoDeDados(player.Id); // Recupere o array de bytes do banco de dados

                using (MemoryStream stream = new MemoryStream(imageBytes))
                {
                    Image imagem = Image.FromStream(stream);
                    pictureBox1.Image = imagem;

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro ao selecionar imagem perfil");
            }
        }
        private void saveAction(object sender, EventArgs e)
        {

            //Mover os dados para a classe funcionarios
            try
            {
                Player player = new Player();
                player.Name = textName.Text;
                player.Rating = int.Parse(textRating.Text);
                player.City = textCity.Text;
                player.State = textEstate.Text;
                player.Sex = (radioMasc.Checked) ? "M" : "F";

                if (pictureBox1.Image == null)
                {
                    lblErrors.Text = "A imagem é obrigatória.";
                    return; // Abortar o salvamento dos dados
                }
                else
                {
                    Bitmap bitmap = new Bitmap(lblDirectory.Text);
                    player.Directory = lblDirectory.Text;

                    using (MemoryStream stream = new MemoryStream())
                    {
                        bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                        byte[] imagemBytes = stream.ToArray();

                        player.Imagem = imagemBytes;
                    }
                    List<ValidationResult> validationResults = new List<ValidationResult>();
                    ValidationContext context = new ValidationContext(player);
                    bool validate = Validator.TryValidateObject(player, context, validationResults, true);


                    if (validate)
                    {
                        //Salvar os dados
                        //Fechar e atualizar a tela principal

                        if (PlayerDataAcess.saveNewPlayers(player))
                        {
                            //Sucesso

                            _mainscreen.UpdateTable();
                            this.Close();
                        }
                        else
                        {
                            lblErrors.Text = "Erro na inserção de dados!";
                            //Erro
                        }
                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder();
                        //Validação de erros
                        foreach (ValidationResult validationResult in validationResults)
                        {
                            sb.AppendLine(validationResult.ErrorMessage);
                        }
                        lblErrors.Text = sb.ToString();
                    }

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique todos os campos antes de cadastrar.");
            }


        }

        private void button1_Click(object sender, EventArgs e)     //Botão ''Pronto'', para concluir as informações e salva-las.
        {
            try
            {
                Player player = new Player();
                player.Id = int.Parse(lblId.Text);
                player.Name = textName.Text;
                player.Rating = int.Parse(textRating.Text);
                player.City = textCity.Text;
                player.State = textEstate.Text;
                player.Sex = (radioMasc.Checked) ? "M" : "F";
                player.Directory = lblDirectory.Text;
                Bitmap bitmap = new Bitmap(player.Directory);

                using (MemoryStream stream = new MemoryStream())
                {
                    bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                    byte[] imagemBytes = stream.ToArray();

                    player.Imagem = imagemBytes;
                }
                List<ValidationResult> validationResults = new List<ValidationResult>();
                ValidationContext context = new ValidationContext(player);
                bool validate = Validator.TryValidateObject(player, context, validationResults, true);


                if (validate)
                {
                    //Salvar os dados
                    //Fechar e atualizar a tela principal
                    bool result = PlayerDataAcess.EditPlayer(player);

                    if (result)
                    {

                        //Sucesso
                        _mainscreen.UpdateTable();
                        this.Close();
                    }
                    else
                    {
                        lblErrors.Text = "Erro na inserção de dados!";
                        //Erro
                    }
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    //Validação de erros
                    foreach (ValidationResult validationResult in validationResults)
                    {
                        sb.AppendLine(validationResult.ErrorMessage);
                    }
                    lblErrors.Text = sb.ToString();
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique se todos os campos estão no formato correto");
            }


        }

        private void btnInput_Click(object sender, EventArgs e) // Botão para abrir a caixa de dialogo e salvar um arquivo IMG.
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string file = openFileDialog.FileName;
                    lblDirectory.Text = openFileDialog.FileName;
                    File.ReadAllBytes(file);
                    pictureBox1.Image = Image.FromFile(file);


                }
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Por favor, selecione uma imagem com formato correto.");

            }

        }

    }
}

