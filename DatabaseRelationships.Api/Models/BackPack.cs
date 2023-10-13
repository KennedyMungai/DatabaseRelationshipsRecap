namespace DatabaseRelationships.Api.Models;


public class BackPack
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public int CharacterId { get; set; }
    public Character Character { get; set; } = new Character();
}