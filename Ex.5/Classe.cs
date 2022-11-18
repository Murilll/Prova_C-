public class Cliente
{
    public string Nome { get; set; }
    public bool Premium { get; set; }
    public int DiaNascimento { get; set; }
    public int MesNascimento { get; set; }
    public int AnoNascimento { get; set; }

    public Cliente()
    {}

    public Cliente(string nome, bool premium, int dia, int mes, int ano)
    {
        Nome = nome;
        Premium = premium;
        DiaNascimento = dia;
        MesNascimento = mes;
        AnoNascimento = ano;
    }


    public void Save()
    {
        StreamWriter writer = new StreamWriter(this.Nome + ".txt");

        writer.WriteLine(this.Nome);
        writer.WriteLine(this.Premium);
        writer.WriteLine(this.DiaNascimento);
        writer.WriteLine(this.MesNascimento);
        writer.WriteLine(this.AnoNascimento);

        writer.Close();
    }

    public static Cliente Load(string nome)
    {
        StreamReader reader = new StreamReader(nome + ".txt");

        nome = reader.ReadLine();
        bool premiun = bool.Parse(reader.ReadLine());

        // TODO
        
        Cliente cliente = new Cliente(nome, premiun, -1, -1, -1);
        return cliente;
    }
}

public class Produto
{
    public string Nome { get; set; }
    public int Codigo { get; set; }
   
    public Produto()
    {}

    public Produto(string nome, int codigo)
    {
        Nome = nome;
        Codigo = codigo;
    }

}