using UnityEngine;

public class NaveCargo : Nave{
    public NaveCargo(string id, Vector2 pos) : base(id, pos, capacita: 100, carburante: 500f) {}

    public override void EseguiProssimoComando(){
        if (QueueComandi.Count == 0) return;
        var cmd = QueueComandi.Dequeue();
        // TODO: implementare logica movimento/azione
    }

    public override float CalcolaConsumo(float distanza){
        return distanza * 1.0f; // formula semplice
    }
}
