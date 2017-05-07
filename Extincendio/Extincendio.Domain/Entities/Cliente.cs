using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extincendio.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Documento { get; set; }
        public string Nome { get; set; }
        public string RazaoSocial { get; set; }
        public int? InscricaoEstadual { get; set; }
        public int? Telefone { get; set; }
        public string Email { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int? Cep { get; set; }
        public int? Numero { get; set; }
        public string complemento { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }
    }
}
