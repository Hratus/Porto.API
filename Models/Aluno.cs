
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace API.Models;
[Table("Alunos")]
public class Aluno 
{

    
    
    [Key]
    [Required]
    [StringLength(100)]
    public string? IdEmailAluno { get; set; }

    
    
    [Required]
    public string? Identificador { get; set; }
    
    
    [StringLength(80)]
    public string? Nome { get; set; }
    
    [Required]
    [Range(1,100)]
    public int Squad { get; set; }
    
    [Required]
    [StringLength(80)]
    public string? Faculdade { get; set; }
    
    [Required]
    [StringLength(80)]
    public string? Empresa { get; set; }
    
    [Required]
    [StringLength(10)]
    public string? Turma { get; set; }
    
    [Required]
    [StringLength(6)]
    public string? Turno { get; set; }
    
    [Required]
    [StringLength(80)]
    public string? Curso { get; set; }
    
    
    // public Squad? Squad { get; set; } //
    
    
    
   


    
    
    
    // public Faculdade? Faculdade { get; set; } //
    
    public DateTime DataCadastro { get; set; }

   
    
    
    
}