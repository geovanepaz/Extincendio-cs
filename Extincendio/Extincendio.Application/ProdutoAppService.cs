using Extincendio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extincendio.Domain.Interfaces.Services;
using Extincendio.Application.Interfaces;
using Extincendio.Domain.Services;

namespace Extincendio.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            : base(produtoService)
        {
            _produtoService = produtoService;
           
        }


    }
   
}
