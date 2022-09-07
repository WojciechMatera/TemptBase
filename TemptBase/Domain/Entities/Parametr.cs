using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemptBase.Domain.Entities
{
    public class Parametr
    {
        [HiddenInput(DisplayValue=false)]
        public int ParametrID { get; set; }
        [Required(ErrorMessage = "Proszę podać nazwę produktu")]
        [Display(Name="Nazwa")]
        public string Name { get; set; }
     //   public string Description { get; set; }
        
        [Required(ErrorMessage = "Proszę podać poprawną wartość")]
        [Display(Name="Wartość")]
        public decimal Value { get; set; }
        [Required(ErrorMessage = "Proszę określić kategorię")]
        [Display(Name="Kategoria")]
        public string Category { get; set; }
        
    }
}
