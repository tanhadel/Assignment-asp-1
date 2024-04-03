using Microsoft.EntityFrameworkCore;
using SubApi.Entities;

namespace SubApi.Contexts;

public class ApiContext(DbContextOptions<ApiContext> options) : DbContext(options)
{


    public DbSet<SubEntity> Subscribers { get; set; }
}
