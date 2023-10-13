namespace DatabaseRelationships.Api.Models.DTOs;


public record struct CharacterCreateDTO(string Name, BackPackCreateDTO BackPack);