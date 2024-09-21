public class Program
{
    public static void Main()
    {
        adicionarDisciplina();
    }

    public static void adicionarDisciplina()
    {
        Professor professor = new Professor(1, "Prof. Weslley Maia");
        Disciplina disciplina = new Disciplina(101, "Programação em C#");

        Turma turma = new Turma(2024, disciplina, professor);

        Aluno aluno1 = new Aluno(1001, "Ronilson Batista");
        Aluno aluno2 = new Aluno(1002, "Andreia Souza");

        Console.WriteLine(turma.AddAluno(aluno1)); 
        Console.WriteLine(turma.AddAluno(aluno2)); 

        checkTurma(turma);
    }

    public static void checkTurma(Turma turma) {
         Console.WriteLine("É possível abrir a turma? " + (turma.AbrirTurma() ? "Sim" : "Não"));

        for (int i = 3; i <= 8; i++)
        {
            Aluno aluno = new Aluno(1000 + i, $"Aluno {i}");
            Console.WriteLine(turma.AddAluno(aluno)); 
        }

        Aluno alunoExtra = new Aluno(1011, "Aluno Extra");
        Console.WriteLine(turma.AddAluno(alunoExtra));

        Console.WriteLine("\nPauta da turma:");
        Console.WriteLine(turma.GeraPauta());
    }
}