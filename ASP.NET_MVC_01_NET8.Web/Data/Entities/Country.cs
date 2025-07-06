using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ASP.NET_MVC_01_NET8.Web.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name="País")]
        [MaxLength(50, ErrorMessage ="O campo {0} deve ter no máximo {1} caracteres!")]
        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        public string Name { get; set; }
    }
}
