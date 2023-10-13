using Microsoft.EntityFrameworkCore;

namespace DatabaseRelationships.Api.Data;


public class BackPackContext : DbContext
{
    public BackPackContext(DbContextOptions<BackPackContext> options) : base(options)
    {
    }
}