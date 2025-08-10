using UnityEngine;

public abstract class EntitaSpaziale{
    public string Id { get; protected set; }
    public Vector2 Posizione { get; protected set; }

    public EntitaSpaziale(string id, Vector2 pos){
        Id = id;
        Posizione = pos;
    }

    public abstract void Aggiorna(float deltaTime);
}
