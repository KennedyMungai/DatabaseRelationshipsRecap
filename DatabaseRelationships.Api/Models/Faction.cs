namespace DatabaseRelationships.Api.Models;


public class Faction
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Character> Characters { get; set; } = new List<Character>();
}