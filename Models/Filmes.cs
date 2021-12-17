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
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Lancamento{ get; set; }
        [Display (Name = "Genero")]
        public GeneroType Type { get; set; }
        public string Img { get; set; }
    }
}