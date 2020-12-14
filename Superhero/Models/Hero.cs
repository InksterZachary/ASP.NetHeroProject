using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Superhero.Models
{
    public class Hero
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string alterEgo { get; set; }
        public string mainPower { get; set; }
        public string lesserPower { get; set; }
        public string catchPhrase { get; set; }
    }
}
