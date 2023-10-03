using System.Collections.ObjectModel;

namespace API.Models;

public class Mentor
{

    public Mentor()
    {
        Alunos = new Collection<Aluno>();

        Squads = new Collection<Squad>();
    }
    
    public int MentorId { get; set; }
    
    public string? MentorNome { get; set; }
    
    public string? MentorEmail { get; set; }
    
    public string? MentorLinkedInUrl { get; set; }
    
    public Empresa? Empresa { get; set; }
    
    public ICollection<Aluno>? Alunos { get; set; }
    
    public ICollection<Squad>? Squads { get; set; }
}