public class Aluno
{
    public int Matricula { get; set; }
    public string Nome { get; set; }
    private List<Turma> turmas = new List<Turma>();

    public Aluno(int matricula, string nome)
    {
        Matricula = matricula;
        Nome = nome;
    }

    public override string ToString()
    {
        return "Aluno: " + Nome + " Matrícula: " + Matricula;
    }

    public string AddTurma(Turma turma)
    {
        if (!turmas.Contains(turma))
        {
            turmas.Add(turma);
            return Nome + " foi adicionado a turma " + turma.Codigo;
        }
        return Nome + "ja esta matriclado na turma " + turma.Codigo;
    }

    public string ExibirTurmas()
    {
        if (turmas.Count == 0)
        {
            return Nome + "não está matriculado em nenhuma turma.";
        }

        string resultado = Nome + "está matriculado nas seguintes turma:\n";

        foreach (var turma in turmas)
        {
            resultado += "- Turma " + turma.Codigo + " Disciplina: " + turma.Disciplina.Nome + "Professor: " + turma.Professor.Nome + "\n";
        }
        return resultado;
    }

}
