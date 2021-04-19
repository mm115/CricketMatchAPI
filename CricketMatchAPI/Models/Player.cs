using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CricketMatchAPI.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; } // this is the foreign key
        public string player_Name { get; set; } // this is the name of the player
        public string player_Email { get; set; } // this is the player email
        public string player_Score { get; set; } // this is the score of the player
        public string player_Age { get; set; } // this is the player age

    }
}
