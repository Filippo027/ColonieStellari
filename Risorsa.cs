public class Risorsa{
    public string Nome { get; private set; }

    public Risorsa(string nome){
        Nome = nome;
    }

    public override string ToString() => Nome;
}
