
using Extincendio.Domain.Entities;
using System.Collections.Generic;

namespace Extincendio.Application.Interfaces
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
        IEnumerable<Cliente> GetByName(string name);
        IEnumerable<Cliente> GetByDocumento(string documento);
        IEnumerable<Cliente> GetByRazaoSocial(string razaoSocial);
        IEnumerable<Cliente> GetByCidade(string cidade);
    }
}
