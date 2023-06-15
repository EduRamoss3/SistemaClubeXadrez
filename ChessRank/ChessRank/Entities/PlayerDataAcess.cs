using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe ;
using System.Data;
using System.Dynamic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Security.Cryptography;
using System.IO;
using System.Drawing;
using static System.Net.WebRequestMethods;
using File = System.IO.File;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ChessRank.Entities
{
    internal class PlayerDataAcess
    {
      
        private static SqlCeConnection con = new SqlCeConnection(@"Data Source=C:\\Users\\Eduardo\\source\\repos\\EduRamoss3\\FormsChess\\ChessRank\\ChessRank\\Data\\ChessData.sdf;");

        
        public static DataTable takePlayers()
        {
            
            SqlCeDataAdapter sqlCeData = new SqlCeDataAdapter("SELECT Id,Name,Rating,Imagem,Directory FROM PlayerTable", con);
            DataSet ds = new DataSet();
            sqlCeData.Fill(ds);
            
            return ds.Tables[0];
        }
        public static Player ShowPlayer(int id)
        {
            con.Close();
            Player player = new Player();
            string sql = "SELECT Name, Rating, State, Rating FROM PlayerTable  WHERE Id = @id";
            SqlCeCommand cmd = new SqlCeCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            SqlCeDataReader response = cmd.ExecuteReader();
            try {
                if (response.Read())
                {

                    player.Name = response.GetString(1);
                    player.State = response.GetString(3);
                    player.City = response.GetString(4);
                    player.Sex = response.GetString(5);
                    player.Directory = response.GetString(7);
                }
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Erro na conversão dos dados");
            }
          
            con.Close();
            return player;
        }
        public static bool EditPlayer(Player player)
        {
            con.Close();
            string sql = "UPDATE PlayerTable SET Name = @Name, Rating = @Rating , City = @City, State = @State, Sex = @Sex, Imagem = @Imagem, Directory = @Directory WHERE Id = @id";
            SqlCeCommand cmd = new SqlCeCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", player.Id);
            cmd.Parameters.AddWithValue("@Name", player.Name);
            cmd.Parameters.AddWithValue("@Rating", player.Rating);
            cmd.Parameters.AddWithValue("@City", player.City);
            cmd.Parameters.AddWithValue("@State", player.State);
            cmd.Parameters.AddWithValue("@Sex", player.Sex);
            cmd.Parameters.Add("@Imagem", SqlDbType.Image).Value = player.Imagem;
            cmd.Parameters.AddWithValue("@Directory", player.Directory);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlCeException)
            {
                MessageBox.Show("Erro no banco de dados");

            }
            catch (TimeoutException)
            {
                MessageBox.Show("Muita demora ao conectar ao banco de dados, feche e abra a o programa novamente");
            }
            catch (SqlNullValueException)
            {
                MessageBox.Show("Valores nulos");
            }

            con.Close();
            return true;

        }

        public static bool saveNewPlayers(Player player)
        {
            con.Close();
            string sql = "INSERT INTO PlayerTable (Name,Rating,City,State,Sex,Imagem,Directory) VALUES (@Name,@Rating,@City,@State,@Sex,@Imagem,@Directory) ";
            SqlCeCommand cmd = new SqlCeCommand(sql,con);
            
            cmd.Parameters.AddWithValue("@Name", player.Name);
            cmd.Parameters.AddWithValue("@Rating", player.Rating );
            cmd.Parameters.AddWithValue("@City", player.City );
            cmd.Parameters.AddWithValue("@State", player.State);
            cmd.Parameters.AddWithValue("@Sex", player.Sex);
            cmd.Parameters.AddWithValue("@Imagem", SqlDbType.Image).Value = player.Imagem;
            cmd.Parameters.AddWithValue("@Directory", player.Directory.ToString());

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlCeException)
            {
                MessageBox.Show("Erro no banco de dados");

            }
            catch (TimeoutException)
            {
                MessageBox.Show("Muita demora ao conectar ao banco de dados, feche e abra a o programa novamente");
            }
            catch (SqlNullValueException)
            {
                MessageBox.Show("Valores nulos");
            }

            
            con.Close();
            return true;
            
          
        }
        public static Player takingPlayerEdit(int id)
        {
           
            con.Close();
            Player players = new Player();
            string sql = "SELECT * FROM PlayerTable  WHERE Id = @id";
            SqlCeCommand cmd = new SqlCeCommand(sql, con);

            cmd.Parameters.AddWithValue("@id",id);



            con.Open();
            SqlCeDataReader response = cmd.ExecuteReader();

            if (response.Read())
            {
                Mainscreen v = new Mainscreen();
                try
                {
                    players.Id = response.GetInt32(0);
                    players.Rating = response.GetInt32(2);
                    players.Name = response.GetString(1);
                    players.State = response.GetString(3);
                    players.City = response.GetString(4);
                    players.Sex = response.GetString(5);
                    players.Directory = response.GetString(7);
                    object imagemObj = response.GetValue(6);
                    if (imagemObj != DBNull.Value)
                    {
                        byte[] imagemBytes = (byte[])imagemObj;
                        if (imagemBytes.Length > 0)
                        {

                            using (MemoryStream stream = new MemoryStream(imagemBytes))
                            {
                                Image imagem = Image.FromStream(stream);
                                v.pictureBox1.Image = imagem;
                            }
                        }
                        else
                        {
                            // Se o campo de imagem estiver vazio, limpar a PictureBox
                            v.pictureBox1.Image = null;
                        }
                    }
                    else
                    {
                        // Se o campo de imagem for NULL, limpar a PictureBox
                        v.pictureBox1.Image = null;
                    }
                    
                }
                catch (FormatException)
                {
                    MessageBox.Show("Formato de dados errado");
                }
             
               
            }

            con.Close();
            return players;
        }
        public static bool RemovePlayer(int id)
        {
            con.Close();
           
            string sql = "DELETE FROM PlayerTable WHERE Id = @id";
            SqlCeCommand sqlCeCommand = new SqlCeCommand(sql, con);
            sqlCeCommand.Parameters.AddWithValue("@id",id);
          
            try
            {
                con.Open();
                sqlCeCommand.ExecuteNonQuery();
            }
            catch (SqlCeException)
            {
                MessageBox.Show("Erro no banco de dados");

            }
            catch (TimeoutException)
            {
                MessageBox.Show("Muita demora ao conectar ao banco de dados, feche e abra a o programa novamente");
            }
            catch (SqlNullValueException)
            {
                MessageBox.Show("Valores nulos");
            }

            con.Close();
            return true;
        }
        public static byte[] ObterImagemDoBancoDeDados(int id)
        {
            con.Close();
            string sql = "SELECT Imagem FROM PlayerTable WHERE Id = @id";
            SqlCeCommand cmd = new SqlCeCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();

            try
            {
                SqlCeDataReader response = cmd.ExecuteReader();
                if (response.Read())
                {
                    if (!response.IsDBNull(response.GetOrdinal("Imagem")))
                    {
                        return (byte[])response["Imagem"];
                    }

                }

            }
            catch (SqlCeException)
            {
                MessageBox.Show("Erro no banco de dados");

            }
            catch (TimeoutException)
            {
                MessageBox.Show("Demora ao conectar ao banco de dados, feche e abra a o programa novamente");
            }
            catch (SqlNullValueException)
            {
                MessageBox.Show("Valores nulos");
            }


            con.Close();
            return null;
            
        }

    }
}
