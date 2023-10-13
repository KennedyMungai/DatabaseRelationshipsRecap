namespace DatabaseRelationships.Api.Models;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public BackPack BackPack { get; set; } = new BackPack();
}