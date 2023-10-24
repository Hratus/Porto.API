//using API.Models;

using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Context;

public class AppBdContext : DbContext
{
    public AppBdContext(DbContextOptions<AppBdContext> options) : base(options)
    {}
    
    public DbSet<Aluno>? Alunos { get; set; } 
     public DbSet<Mentor>? Mentores { get; set; } 
   // public DbSet<Faculdade>? Faculdades { get; set; } //
    //public DbSet<Squad>? Squads { get; set; } //
  //  public DbSet<Empresa>? Empresas { get; set; } //
}