
using Extincendio.Domain.Entities;
using System.Collections.Generic;

namespace Extincendio.Domain.Interfaces.Repositories
{
   public  interface IClienteRepository : IRepositoryBase<Cliente>
    {
        IEnumerable<Cliente> GetByName(string name);

        IEnumerable<Cliente> GetByDocumento(string documento);

        IEnumerable<Cliente> GetByRazaoSocial(string razaoSocial);

        IEnumerable<Cliente> GetByCidade(string cidade);

    }
}
