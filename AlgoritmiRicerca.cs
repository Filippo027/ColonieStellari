using System.Collections.Generic;

public static class AlgoritmiRicerca{
    public static Pianeta TrovaPianetaConPrezzoMinimo(IEnumerable<Pianeta> pianeti, Risorsa r){
        Pianeta best = null;
        float bestPrezzo = float.PositiveInfinity;
        foreach (var p in pianeti){
            float prezzo = p.GetPrezzo(r);
            if (prezzo < bestPrezzo){
                bestPrezzo = prezzo;
                best = p;
            }
        }
        return best;
    }
}
