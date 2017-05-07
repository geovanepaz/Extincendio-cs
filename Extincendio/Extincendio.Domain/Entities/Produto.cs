using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extincendio.Domain.Entities
{
    public class Produto
    {

        public int ProdutoId { get; set; }
        public string Codigo { get; set; }
        public string AgenteExtintor { get; set; }
        public string CapacidadeExtintora { get; set; }
        public string Carga { get; set; }
        public DateTime ValidadeSelo { get; set; }
        public DateTime DataReteste { get; set; }
        public Decimal valorUnitario { get; set; }
    }
}
