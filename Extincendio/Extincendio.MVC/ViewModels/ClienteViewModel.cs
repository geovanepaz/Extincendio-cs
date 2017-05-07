using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Extincendio.MVC.ViewModels
{
    public class ClienteViewModel
    {

        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(14, ErrorMessage = "Máximo {1} caracteres")]
        [MinLength(11, ErrorMessage = "Minimo {1} caracteres")]
        public string Documento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(150, ErrorMessage = "Máximo {1} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {1} caracteres")]
        public string Nome { get; set; }

        public string RazaoSocial { get; set; }

        [DisplayName("IE")]
        public int? InscricaoEstadual { get; set; }

        public int? Telefone { get; set; }

        
        [MaxLength(100, ErrorMessage = "Máximo {1} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public int? Cep { get; set; }
        public int? Numero { get; set; }
        public string Bairro { get; set; }
        public string complemento { get; set; }
        public bool Ativo { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
    }
}