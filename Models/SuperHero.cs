using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroesNew.Models
{
    public class SuperHero
    {
        [Key]
        public int Id { get; set; }
        public string Round_1_B1 { get; set; }
        public string Round_1_B2 { get; set; }
        public string Round_2_B1 { get; set; }
        public string Round_2_B2 { get; set; }
        public string Round_3_B1 { get; set; }
       public string Round_3_B2 { get; set; }//comment this out
    }
}
