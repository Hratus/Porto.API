using System.Data;

namespace API.Models;

public class Aluno
{
    public int AlunoId { get; set; }
    
    public byte AlunoSquad { get; set; }
    
    public string? AlunoNome { get; set; }
    
    public string? AlunoFaculdade { get; set; }
    
    public string? AlunoEmpresa { get; set; }
    
    public string? AlunoEmail { get; set; }
    
    public DateTime DataCadastro { get; set; }
}