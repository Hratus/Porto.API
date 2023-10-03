using System.Collections.ObjectModel;

namespace API.Models;

public class Empresa
{

    public Empresa()
    {
        Mentors = new Collection<Mentor>();

        Alunos = new Collection<Aluno>();
    }
    
    
    public int EmpresaId { get; set; }
    
    public string? EmpresaIdNome { get; set; }
    
    public ICollection<Mentor>?Mentors { get; set; }
    
    public ICollection<Aluno>? Alunos { get; set; }
}