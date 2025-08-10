public interface IRottaCommerciale{
    float CalcolaProfitto(Nave nave);
    float GetDuration();
}

public class RottaStandard : IRottaCommerciale{
    public Pianeta Origine { get; private set; }
    public Pianeta Destinazione { get; private set; }

    public RottaStandard(Pianeta o, Pianeta d){
        Origine = o;
        Destinazione = d;
    }

    public float CalcolaProfitto(Nave nave){
        return 0f; // da implementare nel Giorno 2
    }

    public float GetDuration(){
        return UnityEngine.Vector2.Distance(Origine.Posizione, Destinazione.Posizione);
    }
}
