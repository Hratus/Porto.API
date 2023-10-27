using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

[Table("Empresas")]
public class Empresa
{
    
    [Key]
    [Required]
    public string? IdNomeEmpresa { get; set; }
    
    [Required]
    public string? Identificador { get; set; }
    
    
    
    
    

  
    
    
    
    
    
    
    
    
    
    
}

