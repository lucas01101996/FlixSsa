using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Filmes.Models
{
    [Table("filme")]
    public class Filme
    {
        public int FilmeId { get; set; }
        public string Titulo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Lancamento{ get; set; }
        [Display (Name = "Tipo")]
        public GeneroType Type { get; set; }
        public string Img { get; set; }
    }
}