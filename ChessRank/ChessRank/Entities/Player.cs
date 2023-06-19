using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace ChessRank.Entities
{
    internal class Player
    {
       
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Name { get; set; } 
        public int Rating { get; set; }
        public int Position { get; protected set; }
        [Required]
        public string City { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string State { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public byte[] Imagem { get; set; }
        [Required]
        public string Directory { get; set; }
        

        public Player()
        {

        }
        public Player(int id,string name, int rating, int position)
        {
            Id = id;
            Name = name;
            Rating = rating;
            Position = position;
        }
        public Player(int id, string name, int rating, int position,string city, string state, string sex)
        {
            Id = id;
            Name = name;
            Rating = rating;
            Position = position;
            State = state;
            City = city;
            Sex = sex;
        }
       
    }
}
