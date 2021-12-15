using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Filmes.Models
{
    [Table("addFilmeVm")]
    public class AddFilmeVm
    {
        [Required]
        public string Titulo { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Lancamento{ get; set; }
        public GeneroType Type { get; set; }
        public string Img { get; set; }
        public List<SelectListItem> Select {get; set;}

        public AddFilmeVm(){
            Select = new List<SelectListItem>();
            //<Optional values = "0"> Acao<Optional>
            Select.Add(new SelectListItem{
                Value = ((int) GeneroType.Acao).ToString(),
                Text = GeneroType.Acao.ToString()
            });

            Select.Add(new SelectListItem {
                Value = ((int) GeneroType.Suspense).ToString(),
                Text = GeneroType.Suspense.ToString()
            });

            Select.Add(new SelectListItem{
                Value = ((int) GeneroType.Comedia).ToString(),
                Text = GeneroType.Comedia.ToString()
            });

            Select.Add(new SelectListItem {
                Value = ((int) GeneroType.Terror).ToString(),
                Text = GeneroType.Terror.ToString()
            });

             Select.Add(new SelectListItem {
                Value = ((int) GeneroType.Aventura).ToString(),
                Text = GeneroType.Aventura.ToString()
            });
        }
    }
}