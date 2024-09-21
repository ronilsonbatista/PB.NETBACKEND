public class Disciplina
{
    public int Codigo { get; set; }
    public string Nome { get; set; }

    private List<Turma> Turmas { get; set; }


    public Disciplina(int codigo, string nome)
    {
        Codigo = codigo;
        Nome = nome;
        Turmas = new List<Turma>();
    }

    public void AddTurma(Turma turma)
    {
        Turmas.Add(turma);
    }

    public string ExibirTurmas()
    {
        string turmasList = "Turmas da Disciplina " + Nome + ":";
        foreach (var turma in Turmas)
        {
            turmasList += "- Turma Código: " + turma.Codigo + "\n";
        }
        return turmasList;
    }

    public override string ToString()
    {
        return "Disciplina: " + Nome + " Código: " + Codigo;
    }
}
