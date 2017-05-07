

using System;
using System.Collections.Generic;
using System.Linq;
using Extincendio.Domain.Entities;
using Extincendio.Domain.Interfaces.Repositories;
using Extincendio.Domain.Interfaces.Services;

namespace Extincendio.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }

        
        public IEnumerable<Cliente> GetByName(string name)
        {
            return _clienteRepository.GetByName(name);
        }

        public IEnumerable<Cliente> GetByDocumento(string documento)
        {
            return _clienteRepository.GetByDocumento(documento);

        }

        public IEnumerable<Cliente> GetByRazaoSocial(string razaoSocial)
        {
            return _clienteRepository.GetByRazaoSocial(razaoSocial);

        }

        public IEnumerable<Cliente> GetByCidade(string cidade)
        {
            return _clienteRepository.GetByCidade(cidade);

        }

    }
}
