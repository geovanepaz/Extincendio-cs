using Extincendio.Domain.Entities;
using Extincendio.Domain.Interfaces.Repositories;

namespace Extincendio.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
    }
}
