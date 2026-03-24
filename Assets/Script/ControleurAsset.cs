using UnityEngine;

public class ControleurAsset : MonoBehaviour
{
    public float temp = 0f; 
    public GameObject neige;
    public GameObject pluie;

    void Update()
    {
        // Sécurité : On vérifie que les deux objets sont bien assignés
        if (neige != null && pluie != null)
        {
            if (temp <= 0f)
            {
                // Cas : Il neige
                if (!neige.activeSelf) neige.SetActive(true);
                if (pluie.activeSelf) pluie.SetActive(false);
            }
            else
            {
                // Cas : Il pleut
                if (neige.activeSelf) neige.SetActive(false);
                if (!pluie.activeSelf) pluie.SetActive(true);
            }
        }
    }
}
