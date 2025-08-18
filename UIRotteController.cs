using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class UIRotteController : MonoBehaviour {
    public Transform listaRotteContainer;
    public GameObject elementoRottaPrefab;
    public TMP_InputField campoRicerca;

    void Start() {
        AggiornaLista();
    }

    public void AggiornaLista() {
        foreach (Transform child in listaRotteContainer) {
            Destroy(child.gameObject);
        }

        List<IRottaCommerciale> rotte = GameController.Instance.GetRotte();

        foreach (var rotta in rotte) {
            GameObject nuovoElemento = Instantiate(elementoRottaPrefab, listaRotteContainer);
            nuovoElemento.GetComponentInChildren<TMP_Text>().text =
                $"{rotta.Nome} - Profitto: {rotta.CalcolaProfitto()}";
        }
    }

    public void FiltraPerRicerca() {
        string keyword = campoRicerca.text;
        List<IRottaCommerciale> rotteFiltrate = GameController.Instance.CercaRotte(keyword);

        foreach (Transform child in listaRotteContainer) {
            Destroy(child.gameObject);
        }

        foreach (var rotta in rotteFiltrate) {
            GameObject nuovoElemento = Instantiate(elementoRottaPrefab, listaRotteContainer);
            nuovoElemento.GetComponentInChildren<TMP_Text>().text =
                $"{rotta.Nome} - Profitto: {rotta.CalcolaProfitto()}";
        }
    }

    public void OrdinaPerProfitto() {
        GameController.Instance.OrdinaRottePerProfitto();
        AggiornaLista();
    }
}
