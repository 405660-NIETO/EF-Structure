using AutoMapper;

namespace PrimerApi.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        /*CreateMap<Monster, MonsterDto>()
            .ForMember(dest => dest.Tipo, opt => opt.MapFrom(src => src.Tipo)); // mapeamos directamente la entidad Tipo a TipoDto
        CreateMap<Tipo, TipoDto>();*/
    }
}