using System.Collections.Generic;

public class RotteManager{
    private List<IRottaCommerciale> rotte = new List<IRottaCommerciale>();

    public void AggiungiRotta(IRottaCommerciale rotta){
        rotte.Add(rotta);
    }

    public List<IRottaCommerciale> CercaPerNome(string keyword){
        var risultati = new List<IRottaCommerciale>();
        foreach(var r in rotte){
            if (r.Nome.ToLower().Contains(keyword.ToLower())){
                risultati.Add(r);
            }
        }
        return risultati;
    }

    public void OrdinaPerProfittoDecrescente(){
        // Algoritmo di ordinamento (Selection Sort)
        for (int i = 0; i < rotte.Count - 1; i++){
            int maxIndex = i;
            for (int j = i + 1; j < rotte.Count; j++){
                if (rotte[j].CalcolaProfitto() > rotte[maxIndex].CalcolaProfitto()){
                    maxIndex = j;
                }
            }
            var temp = rotte[i];
            rotte[i] = rotte[maxIndex];
            rotte[maxIndex] = temp;
        }
    }

    public List<IRottaCommerciale> GetRotte(){
        return new List<IRottaCommerciale>(rotte);
    }
}
