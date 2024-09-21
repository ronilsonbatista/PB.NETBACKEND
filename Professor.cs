public class Professor
{
    public int Matricula { get; set; }
    public string Nome { get; set; }
    private List<Turma> Turmas { get; set; }

    public Professor(int matricula, string nome)
    {
        Matricula = matricula;
         Nome = nome;
        Turmas = new List<Turma>();
    }

    public void AddTurma(Turma turma)
    {
        Turmas.Add(turma);
    }

    public string ExibirTurmas()
    {
        string turmasList = "Turmas do Professor " + Nome + ":";
        foreach (var turma in Turmas)
        {
            turmasList += "- Turma Código: " + turma.Codigo + "\n";
        }
        return turmasList;
    }

    public override string ToString()
    {
          return "Professor: " + Nome + " Matrícula: " + Matricula;
    }
}
