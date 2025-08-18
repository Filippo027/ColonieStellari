using UnityEngine;

public class RottaStandard : IRottaCommerciale {
    public Pianeta Origine { get; private set; }
    public Pianeta Destinazione { get; private set; }
    public string Nome => $"{Origine.Nome} → {Destinazione.Nome}";

    public RottaStandard(Pianeta o, Pianeta d) {
        Origine = o;
        Destinazione = d;
    }

    public float CalcolaProfitto() {
        // Per ora ritorna un valore fittizio
        return UnityEngine.Random.Range(100, 500);
    }

    public float GetDurata() {
        return Vector2.Distance(Origine.Posizione, Destinazione.Posizione);
    }
}
