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
        public int Id { get; set; }
        public string player_Name { get; set; }
        public string player_Email { get; set; }
        public string player_Score { get; set; }
        public string player_Age { get; set; }

    }
}
