using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

[Table("Faculdades")]
public class Faculdade
{
    
    
    [Key]
    [Required]
    public string? IdNome { get; set; }

    [Required] 
    public string? Identificador { get; set; }

    public Faculdade()
    {
        IList<Aluno> alunos = new List<Aluno>();
    }
    
}

