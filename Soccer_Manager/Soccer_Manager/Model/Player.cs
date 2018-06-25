using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer_Manager.Model
{
    public class Player
    {
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public decimal Heigth { get; set; }
        public DateTime Birthdate { get; set; }
        public int Jerseynumber { get; set; }
        public enum  Position  { get; set; }
        public int PlayedGames { get; set; }
        public int Goals { get; set; }
        public enum Team { get; set; }





    }
}
