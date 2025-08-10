using System.Collections.Generic;
using UnityEngine;

public abstract class Nave : EntitaSpaziale{
    public int Capacita { get; protected set; }
    public float Carburante { get; protected set; }
    public Dictionary<Risorsa,int> Inventario { get; private set; }
    public Queue<ComandoNave> QueueComandi { get; private set; }

    public Nave(string id, Vector2 pos, int capacita, float carburante) : base(id, pos){
        Capacita = capacita;
        Carburante = carburante;
        Inventario = new Dictionary<Risorsa,int>();
        QueueComandi = new Queue<ComandoNave>();
    }

    public abstract void EseguiProssimoComando();
    public abstract float CalcolaConsumo(float distanza);

    public void AggiungiComando(ComandoNave c){
        QueueComandi.Enqueue(c);
    }
}
