public class ComandoNave{
    public string Tipo { get; private set; }
    public Pianeta Target { get; private set; }

    public ComandoNave(string tipo, Pianeta target){
        Tipo = tipo;
        Target = target;
    }
}
