using Extincendio.Domain.Entities;
using Extincendio.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Extincendio.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {

        public IEnumerable<Cliente> GetByName(string name)
        {
            return Db.Clientes.Where(p => p.Nome.Contains(name)).ToList();
           
        }

        public IEnumerable<Cliente> GetByDocumento(string documento)
        {
        
            return Db.Clientes.Where(p => p.Documento == documento).ToList();

        }

        public IEnumerable<Cliente> GetByRazaoSocial(string razaoSocial)
        {
            return Db.Clientes.Where(p => p.RazaoSocial.Contains(razaoSocial)).ToList();

        }

        public IEnumerable<Cliente> GetByCidade(string cidade)
        {
            return Db.Clientes.Where(p => p.Cidade.Contains(cidade)).ToList();

        }
    }
}
