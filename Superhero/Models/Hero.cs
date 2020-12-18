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
        [Display(Name ="Super Name")]
        public string name { get; set; }
        [Display(Name ="Hidden Identity")]
        public string alterEgo { get; set; }
        [Display(Name ="Main Power")]
        public string mainPower { get; set; }
        [Display(Name ="Secondary Power")]
        public string lesserPower { get; set; }
        [Display(Name ="Catchphrase")]
        public string catchPhrase { get; set; }
    }
}
