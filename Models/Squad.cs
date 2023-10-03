using System.Collections.ObjectModel;

namespace API.Models;

public class Squad
{

 public Squad()
 {
  Alunos = new Collection<Aluno>();
 }
 
 public byte SquadId { get; set; }
 
 public string? SquadEmpresa { get; set; }
 
 public string? SquadMenrtor { get; set; }
 
 public Mentor? Mentor { get; set; }
 
 public ICollection<Aluno>? Alunos { get; set; }
 
}