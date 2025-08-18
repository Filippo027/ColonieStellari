using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public static GameController Instance { get; private set; }

    public RotteManager RotteManager { get; private set; }

    void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            InizializzaGioco();
        } else {
            Destroy(gameObject);
        }
    }

    private void InizializzaGioco() {
        RotteManager = new RotteManager();

        // Pianeti di esempio 
        Pianeta terra = new Pianeta("p1", "Terra", new Vector2(0, 0));
        Pianeta marte = new Pianeta("p2", "Marte", new Vector2(5, 0));
        Pianeta giove = new Pianeta("p3", "Giove", new Vector2(10, 0));

        // Rotte di esempio 
        RotteManager.AggiungiRotta(new RottaStandard(terra, marte));
        RotteManager.AggiungiRotta(new RottaStandard(terra, giove));
        RotteManager.AggiungiRotta(new RottaStandard(marte, giove));
    }

    // Accesso pubblico per la UI
    public List<IRottaCommerciale> CercaRotte(string keyword) {
        return RotteManager.CercaPerNome(keyword);
    }

    public List<IRottaCommerciale> GetRotte() {
        return RotteManager.GetRotte();
    }

    public void OrdinaRottePerProfitto() {
        RotteManager.OrdinaPerProfittoDecrescente();
    }
}
