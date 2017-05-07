using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Extincendio.MVC.ViewModels
{
    public class ProdutoViewModel
    {   [Key]
        public int? ProdutoId { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(150, ErrorMessage = "Máximo {1} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {1} caracteres")]
        public string Codigo { get; set; }
        [DisplayName("Agente Extintor")]
        public string AgenteExtintor { get; set; }
        [DisplayName("Capacidade Extintora")]
        public string CapacidadeExtintora { get; set; }
        public string Carga { get; set; }
        [DisplayName("Validade Selo")]
        public DateTime ValidadeSelo { get; set; }
        [DisplayName("Data Reteste")]
        public DateTime DataReteste { get; set; }
        [DisplayName("valor Unitario")]
        public Decimal valorUnitario { get; set; }
    }
}