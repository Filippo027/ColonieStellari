using System.Collections.Generic;
using UnityEngine;

public class Pianeta : EntitaSpaziale
{
    private Dictionary<Risorsa, float> mercato;
    public string Nome { get; private set; }

    public Pianeta(string id, string nome, Vector2 pos) : base(id, pos){
        Nome = nome;
        mercato = new Dictionary<Risorsa, float>();
    }

    public void SetPrezzo(Risorsa r, float prezzo){
        mercato[r] = prezzo;
    }

    public float GetPrezzo(Risorsa r){
        return mercato.ContainsKey(r) ? mercato[r] : float.PositiveInfinity;
    }

    public IReadOnlyDictionary<Risorsa,float> GetMercato() => mercato;

    public override void Aggiorna(float deltaTime) {
        // Esempio: variazione casuale prezzi (da implementare in seguito)
    }
}
