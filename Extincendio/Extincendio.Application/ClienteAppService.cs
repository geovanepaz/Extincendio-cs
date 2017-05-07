using Extincendio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extincendio.Domain.Interfaces.Services;
using Extincendio.Application.Interfaces;

namespace Extincendio.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
            : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais()
        {
            return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        }


        public IEnumerable<Cliente> GetByName(string name)
        {
            return _clienteService.GetByName(name);
        }

        public IEnumerable<Cliente> GetByDocumento(string documento)
        {
            return _clienteService.GetByDocumento(documento);

        }

        public IEnumerable<Cliente> GetByRazaoSocial(string razaoSocial)
        {
            return _clienteService.GetByRazaoSocial(razaoSocial);

        }

        public IEnumerable<Cliente> GetByCidade(string cidade)
        {
            return _clienteService.GetByCidade(cidade);

        }
    }
   
}
