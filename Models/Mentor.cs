﻿

using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;
[Table("Mentores")]
public class Mentor
{
    public  Mentor()
    {
        
        IList<Aluno> alunos = new List<Aluno>(); 
        
    }
    
    [Key]
    [Required]
    [StringLength(100)]
    public string? IdEmail { get; set; }
    
    [Required]
    public string? Identificador { get; set; }
    
    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }
    
    
    
    [Required]
    [StringLength(200)]
    public string? LinkedInUrl { get; set; }

    [ForeignKey("Alunos")]
    public Aluno? Aluno { get; set; }

    // public Empresa? Empresa { get; set; } //

    //public IList<Squad> Squads { get; set; } //
}