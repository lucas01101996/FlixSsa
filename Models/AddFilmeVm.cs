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
        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Tamanho do {0} tem que ter entre {2} e {1} ")]
        public string Titulo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "{0} required")]
        public DateTime Lancamento{ get; set; }
        [Display(Name="Genero")]
        [Required(ErrorMessage = "{0} required")]
        public GeneroType Type { get; set; }
        [Required(ErrorMessage = "{0} required")]
        public string Img { get; set; }
        [Required(ErrorMessage = "{0} required")]
        public List<SelectListItem> Select {get; set;}

        public AddFilmeVm(){
            Select = new List<SelectListItem>();
            //<option values = "1"> Acao</option>
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