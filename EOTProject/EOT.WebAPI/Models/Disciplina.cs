namespace EOT.WebAPI.Models
{
    public class Disciplina
    {
        public Disciplina() {}

        public int Id { get; set; }
        public string Nome { get; set; }
        public int ProfessorId { get; set; }
        
    }
}