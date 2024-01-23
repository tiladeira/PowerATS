using PowerATS.API.DTO;
using PowerATS.Domain.Entities;

namespace PowerATS.API.AutoMapper
{
    public class MapperProfile : global::AutoMapper.Profile
    {
        public MapperProfile()
        {
            CreateMap<Candidato, CandidatoDto>().ReverseMap();
            CreateMap<Curriculo, CurriculoDto>().ReverseMap();
            CreateMap<Vaga, VagaDto>().ReverseMap();
            CreateMap<CandidatoVaga, CandidatoVagaDto>().ReverseMap();
        }
    }
}
