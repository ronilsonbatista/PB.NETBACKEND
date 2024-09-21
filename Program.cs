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
        Professor professor1 = new Professor(1, "Prof. Weslley Maia");
        professores.Add(professor1);
        Professor professor2 = new Professor(2, "Prof. Lucca Augusto");
        professores.Add(professor2);


        Disciplina disciplina1 = new Disciplina(1, "Programação em C#");
        disciplinas.Add(disciplina1);
        Disciplina disciplina2 = new Disciplina(1, "Programação em Swift");
        disciplinas.Add(disciplina2);

        Aluno aluno1 = new Aluno(1, "Ronilson Batista");
        Aluno aluno2 = new Aluno(2, "Andreia Paiva");
        alunos.Add(aluno1);
        alunos.Add(aluno2);

        Turma turma1 = new Turma(1, disciplina1, professor1);
        turmas.Add(turma1);

        Turma turma2 = new Turma(2, disciplina2, professor2);
        turmas.Add(turma2);

        //Console.WriteLine(aluno1.AddTurma(turma));

        //Console.WriteLine(aluno1.ExibirTurmas());
        //Console.WriteLine(aluno2.ExibirTurmas());

        //Console.WriteLine(turma.AddAluno(aluno1)); 
        //Console.WriteLine(turma.AddAluno(aluno2));

        Console.WriteLine("Alocação de Turmas:");

        foreach (var turma in turmas)
        {
            Console.WriteLine("Turma: " + turma.Codigo);
            Console.WriteLine("Disciplina: " + turma.Disciplina.Nome + " Professor: "  + turma.Professor.Nome);
        }

        Console.WriteLine("Gerar Pauta da Turmas 1:");
        Console.WriteLine("\n" + turma1.GeraPauta());

        Console.WriteLine("Gerar Pauta da Turmas 2:");
        Console.WriteLine("\n" + turma2.GeraPauta());

        Console.WriteLine("Alocação de aluno 1:");
        Console.WriteLine(aluno1.ExibirTurmas());

        Console.WriteLine("Alocação de aluno 2:");
        Console.WriteLine(aluno2.ExibirTurmas());

        Console.WriteLine("Alocação de professor 1:");
        Console.WriteLine(professor1.ExibirTurmas());

        Console.WriteLine("Alocação de professor 2:");
        Console.WriteLine(professor2.ExibirTurmas());

        Console.WriteLine("Alocação de disciplina 1:");
        Console.WriteLine(disciplina1.ExibirTurmas());

        Console.WriteLine("Alocação de disciplina 2:");
        Console.WriteLine(disciplina2.ExibirTurmas());

        //checkTurma(turma1);
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