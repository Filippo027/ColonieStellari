using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour{
    public static GameController Instance { get; private set; }
    
    public RotteManager RotteManager { get; private set; }

    void Awake(){
        if (Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
            InizializzaGioco();
        }else{
            Destroy(gameObject);
        }
    }

    private void InizializzaGioco(){
        RotteManager = new RotteManager();

        // Pianeti di esempio
        Pianeta terra = new Pianeta("Terra", new Vector3(0, 0, 0), 8000000000, 1000f);
        Pianeta marte = new Pianeta("Marte", new Vector3(100, 0, 0), 2000000, 500f);
        Pianeta giove = new Pianeta("Giove", new Vector3(300, 0, 0), 0, 2000f);

        // Rotte di esempio
        RotteManager.AggiungiRotta(new RottaStandard("Terra-Marte", terra, marte, 100, 500));
        RotteManager.AggiungiRotta(new RottaStandard("Terra-Giove", terra, giove, 200, 800));
        RotteManager.AggiungiRotta(new RottaStandard("Marte-Giove", marte, giove, 150, 600));
    }

    public List<IRottaCommerciale> CercaRotte(string keyword){
        return RotteManager.CercaPerNome(keyword);
    }

    public List<IRottaCommerciale> GetRotte(){
        return RotteManager.GetRotte();
    }

    public void OrdinaRottePerProfitto(){
        RotteManager.OrdinaPerProfittoDecrescente();
    }
}
