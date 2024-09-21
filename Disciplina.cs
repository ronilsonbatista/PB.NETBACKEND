public class Disciplina
{
    public int Codigo { get; set; }
    public string Nome { get; set; }

    public Disciplina(int codigo, string nome)
    {
        Codigo = codigo;
        Nome = nome;
    }

    public override string ToString()
    {
        return "Disciplina: " + Nome + " Código: " + Codigo;
    }
}
