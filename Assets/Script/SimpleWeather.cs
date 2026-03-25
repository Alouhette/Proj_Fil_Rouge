using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using TMPro;

public class ControleurMeteoReel : MonoBehaviour
{
    [Header("Paramètres API")]
    // Coordonnées pour Saguenay (Chicoutimi), Québec
    public string latitude = "48.42";
    public string longitude = "-71.06";

    [Header("Références Objets")]
    public GameObject neige;
    public GameObject pluie;
    public ParticleSystem neigeParticles;
    public ParticleSystem pluieParticles;
    public TextMeshProUGUI texteEcran;

    void Start()
    {

        StartCoroutine(GetWeather());
        
    }

    IEnumerator GetWeather()
    {
        string url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&current_weather=true";
        
        UnityWebRequest request = UnityWebRequest.Get(url);
        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.Success)
        {
            WeatherData data = JsonUtility.FromJson<WeatherData>(request.downloadHandler.text);
            AppliquerMeteo(data.current_weather.temperature, data.current_weather.weathercode);
        }
        else
        {
            Debug.LogError("Erreur API : " + request.error);
            texteEcran.text = "Erreur connexion météo";
        }
    }

    void AppliquerMeteo(float temp, int code)
    {

        texteEcran.text = $"Météo réelle : {temp:F1}°C (Code: {code})";

        // LOGIQUE DE DÉCISION
        // Codes Open-Meteo : 71-77 = Neige | 51-67 = Pluie
        bool estEnNeige = (code >= 71 && code <= 77) || (temp <= 0f && code > 0);
        bool estEnPluie = (code >= 51 && code <= 67) || (temp > 0f && code > 0);

        // --- GESTION NEIGE ---
        neige.SetActive(estEnNeige);
        if (estEnNeige) {
            if (!neigeParticles.isPlaying) neigeParticles.Play();
            texteEcran.color = Color.cyan;
        } else {
            neigeParticles.Stop();
        }

        // --- GESTION PLUIE ---
        pluie.SetActive(estEnPluie);
        if (estEnPluie) {
            if (!pluieParticles.isPlaying) pluieParticles.Play();
            texteEcran.color = Color.blue;
        } else {
            pluieParticles.Stop();
        }
        
        // Si c'est dégagé (Code 0)
        if (code == 0) texteEcran.color = Color.yellow;
    }

    // Pour forcer un rafraîchissement
    void RefreshWeather() { StartCoroutine(GetWeather()); }
}

// Classes pour le JSON
[System.Serializable] public class WeatherData { public CurrentWeather current_weather; }
[System.Serializable] public class CurrentWeather { public float temperature; public int weathercode; }
