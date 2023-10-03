using System.Collections.ObjectModel;

namespace API.Models;

public class Faculdade
{

    public Faculdade()
    {
        Alunos = new Collection<Aluno>();
    }
    
    public int FaculdadeId { get; set; }
    
    public string? FaculdadeNome { get; set; }
    
    public string? FaculdadeEndereco { get; set; }
    
    public ICollection<Aluno>? Alunos { get; set; }
    
}