using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordWide.Model
{
    public class Word
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string EnglishWord { get; set; }
        [MaxLength(50)]
        public string TranslateWord { get; set; }
        [Required]
        public bool IsKnown { get; set; }
        public double Progress { get; set; }
    }
}
