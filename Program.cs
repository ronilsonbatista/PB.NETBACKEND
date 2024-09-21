public class Program
{
    public static List<Turma> turmas = new List<Turma>();
    public static List<Professor> professores = new List<Professor>();
    public static List<Disciplina> disciplinas = new List<Disciplina>();
    public static List<Aluno> alunos = new List<Aluno>();

    public static void Main()
    {
        adicionar();
    }

    public static void adicionar()
    {
        Professor professor = new Professor(1, "Prof. Weslley Maia");
        Disciplina disciplina = new Disciplina(101, "Programação em C#");
        professores.Add(professor);
        disciplinas.Add(disciplina);

        Turma turma = new Turma(2024, disciplina, professor);
        turmas.Add(turma);

        Aluno aluno1 = new Aluno(1001, "Ronilson Batista");
        Aluno aluno2 = new Aluno(1002, "Andreia Souza");
        alunos.Add(aluno1);
        alunos.Add(aluno2);

        Console.WriteLine(aluno1.AddTurma(turma));

        Console.WriteLine(aluno1.ExibirTurmas());
        Console.WriteLine(aluno2.ExibirTurmas());

        Console.WriteLine(turma.AddAluno(aluno1)); 
        Console.WriteLine(turma.AddAluno(aluno2));

        checkTurma(turma);
    }

    public static void checkTurma(Turma turma) {
         Console.WriteLine("É possível abrir a turma? " + (turma.AbrirTurma() ? "Sim" : "Não"));

        for (int i = 3; i <= 8; i++)
        {
            Aluno aluno = new Aluno(1000 + i, $"Aluno {i}");
            alunos.Add(aluno);
            Console.WriteLine(turma.AddAluno(aluno)); 
        }

        Aluno alunoExtra = new Aluno(1011, "Aluno Extra");
        Console.WriteLine(turma.AddAluno(alunoExtra));


        Console.WriteLine("\nPauta da turma:");
        Console.WriteLine(turma.GeraPauta());
    }
}