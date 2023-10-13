using AutoMapper;

namespace DatabaseRelationships.Api.Models.DTOs.Profiles;


public class DataProfile : Profile
{
    public DataProfile()
    {
        CreateMap<BackPack, BackPackCreateDTO>().ReverseMap();
        CreateMap<Character, CharacterCreateDTO>().ReverseMap();
    }
}