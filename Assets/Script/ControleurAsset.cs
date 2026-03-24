using UnityEngine;
using TMPro;

public class ControleurAsset : MonoBehaviour
{
    public float temp = 0f; 
    public GameObject neige;
    public GameObject pluie;
    public ParticleSystem neigeParticles;
    public ParticleSystem pluieParticles;
    public TextMeshProUGUI texteEcran;

    void Update()
    {
        // Sécurité : On vérifie que les deux objets sont bien assignés
        if (neige != null && pluie != null)
        {
            if (temp <= 0f)
            {
                // Cas : Il neige
                if (!neige.activeSelf){
                	

                	neige.SetActive(true);
                	texteEcran.text = "Météo: Neige (" + temp.ToString("F1") + ")";
                	texteEcran.color = Color.blue;
                }
                if(pluieParticles.isPlaying) pluieParticles.Stop(); 
                if(!neigeParticles.isPlaying) neigeParticles.Play();
                if (pluie.activeSelf) pluie.SetActive(false);
                
                	
            }
            else
            {
                // Cas : Il pleut

                if (!pluie.activeSelf){
                
                  pluie.SetActive(true);
                  texteEcran.text = "Météo: Pluie (" + temp.ToString("F1") + ")";
                } 
                if(neigeParticles.isPlaying) neigeParticles.Stop();
                if(!pluieParticles.isPlaying) pluieParticles.Play();
                                if (neige.activeSelf) neige.SetActive(false);
            }
        }
    }
}
