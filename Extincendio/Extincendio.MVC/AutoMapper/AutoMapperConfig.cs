
using AutoMapper;
using Extincendio.Domain.Entities;
using Extincendio.MVC.ViewModels;

namespace Extincendio.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
                x.CreateMap<Produto, ProdutoViewModel>();
                x.CreateMap<ProdutoViewModel, Produto>();
                x.CreateMap<Cliente, ClienteViewModel>();
                x.CreateMap<ClienteViewModel, Cliente>();

            }

                );
        }
    }
}