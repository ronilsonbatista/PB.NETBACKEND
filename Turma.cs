using System;
using System.Collections.Generic;

public class Turma
{
    public int Codigo { get; set; }
    public Disciplina Disciplina { get; set; }
    public Professor Professor { get; set; }
    private List<Aluno> Alunos;
    private List<Turma> Turmas { get; set; }
    private const int MaxAlunos = 10;

    public Turma(int codigo, Disciplina disciplina, Professor professor)
    {
        Codigo = codigo;
        Disciplina = disciplina;
        Professor = professor;
        Alunos = new List<Aluno>();
        Turmas = new List<Turma>();
    }

    public string AddAluno(Aluno aluno)
    {
        if (Alunos.Count < MaxAlunos)
        {
            Alunos.Add(aluno);
            return "Aluno adicionado";
        }
        else { return "Turma cheia"; }
    }

    public bool AbrirTurma()
    {
        return Alunos.Count >= 2;
    }

    public void AddProfessor(Professor professor)
    {
        this.Professor = professor;
    }

    public void AddDisciplina(Disciplina disciplina)
    {
        this.Disciplina = disciplina;
    }

    public string GeraPauta()
    {
        string turma = "Turma : " + Codigo;
        string disciplina = "Disciplina: " + Disciplina.Nome;
        string professor = "Professor: " + Professor.Nome;

        string pauta = turma + "\n" + disciplina + "\n" + professor + "\n" + "Alunos Inscritos:\n";

        foreach (Aluno aluno in Alunos)
        {
            pauta += $"- {aluno.Nome}\n";
        }
        return pauta;
    }

    public string GerarAula()
    {
        return "Aula da turma " + Codigo + "gerada com sucesso";
    }
}
