using System;
using System.Collections.Generic;

public class Turma
{
    public int Codigo { get; set; }
    public Disciplina Disciplina { get;  set; }
    public Professor Professor { get; set; }
    private List<Aluno> Alunos;
    private const int MaxAlunos = 10;

    public Turma(int codigo, Disciplina disciplina, Professor professor)
    {
        Codigo = codigo;
        Disciplina = disciplina;
        Professor = professor;
        Alunos = new List<Aluno>();
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

    public string GeraPauta()
    {
        string turma = "Turma : "  + Codigo;
        string disciplina = "Disciplina: " + Disciplina.Nome;
        string professor = "Professor: " + Professor.Nome;

        string pauta = turma + "\n" + disciplina + "\n" + professor + "\n" + "Alunos Inscritos:\n";

        foreach (Aluno aluno in Alunos)
        {
            pauta += $"- {aluno.Nome}\n";
        }
        return pauta;
    }
}

