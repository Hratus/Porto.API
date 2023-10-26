using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class Empresa
{

    [Key]
    [Required]
    public string? IdNomeEmpresa { get; set; }
    
    public string? Identificador { get; set; }
    
    [Required]
    [StringLength(100)]
    public string? MentorDaEmpresa { get; set; }

    public Empresa()
    {
        IList<Aluno> alunos = new List<Aluno>();
    }
    
    
    
    
    
    
    
    
    
    
    
}

