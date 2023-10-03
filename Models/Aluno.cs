using System.Data;

namespace API.Models;

public class Aluno
{

    
    
    public int AlunoId { get; set; }
    
    public string? AlunoNome { get; set; }
    
    public byte AlunoSquad { get; set; }
    
    public string? AlunoFaculdade { get; set; }
    
    public string? AlunoEmpresa { get; set; }
    
    public string? AlunoTurma { get; set; }
    
    public string? AlunoTurno { get; set; }
    
    public string? AlunoMentor { get; set; }
    
    public Squad? Squad { get; set; }
    
    public Empresa? Empresa { get; set; }
    
    public Mentor? Mentor { get; set; }
    
    public Faculdade? Faculdade { get; set; }
    
    public DateTime DataCadastro { get; set; }
    
    
}