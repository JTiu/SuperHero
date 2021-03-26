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
        public string Round_3_B2 { get; set; }
        public string Round_4_B1 { get; set; }
        public string Round_4_B2 { get; set; }
        public string Round_5_B1 { get; set; }
        public string Round_5_B2 { get; set; }
        public string Round_6_B1 { get; set; }
        public string Round_6_B2 { get; set; }
        public string Round_7_B1 { get; set; }
        public string Round_7_B2 { get; set; }
        public string Round_8_B1 { get; set; }
        public string Round_8_B2 { get; set; }
        public string Round_9_B1 { get; set; }
        public string Round_9_B2 { get; set; }
        public string Round_10_B1 { get; set; }
        public string Round_10_B2 { get; set; }
        public string Round_11_B1 { get; set; }
        public string Round_11_B2 { get; set; }
        public string Round_12_B1 { get; set; }
        public string Round_12_B2 { get; set; }
    }
}
