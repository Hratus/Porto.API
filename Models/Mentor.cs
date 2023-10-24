

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;
[Table("Mentores")]
public class Mentor
{
    public  Mentor()
    {
        
        IList<Aluno> alunos = new List<Aluno>(); // verificar se isso esta certo

        // Squads = new Collection<Squad>(); //
    }
    
    [Key]
    [Required]
    [StringLength(100)]
    public string? Id { get; set; }
    
    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }
    
    
    
    [Required]
    [StringLength(200)]
    public string? LinkedInUrl { get; set; }
    
    // public Empresa? Empresa { get; set; } //
    
   //public IList<Aluno> Alunos { get; set;}//
    
    //public IList<Squad> Squads { get; set; } //
}