public class Professor
{
    public int Matricula { get; set; }
    public string Nome { get; set; }

    public Professor(int matricula, string nome)
    {
        Matricula = matricula;
         Nome = nome;
    }

    public override string ToString()
    {
          return "Professor: " + Nome + " Matrícula: " + Matricula;
    }
}
