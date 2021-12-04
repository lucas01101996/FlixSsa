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
        public DateTime Lancamento{ get; set; }
        public string Genero { get; set; }
        public string Img { get; set; }
    }
}