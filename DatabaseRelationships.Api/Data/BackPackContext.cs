using DatabaseRelationships.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseRelationships.Api.Data;


public class BackPackContext : DbContext
{
    public BackPackContext(DbContextOptions<BackPackContext> options) : base(options)
    {
    }

    public DbSet<Character> Characters { get; set; }
    public DbSet<BackPack> BackPacks { get; set; }
}