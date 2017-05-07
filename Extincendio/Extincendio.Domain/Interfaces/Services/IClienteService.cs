using Extincendio.Domain.Entities;
using Extincendio.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace Extincendio.Domain.Interfaces.Services
{
   public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);

        IEnumerable<Cliente> GetByName(string name);

        IEnumerable<Cliente> GetByDocumento(string documento);

        IEnumerable<Cliente> GetByRazaoSocial(string razaoSocial);

        IEnumerable<Cliente> GetByCidade(string cidade);
    }
}
