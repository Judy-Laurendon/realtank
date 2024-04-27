using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TargetManager : MonoBehaviour
{
    public static TargetManager instance;
    public int totalTargets;
    public int targetsHit = 0;
    public TextMeshProUGUI targetsRemainingText; // UI pour afficher les cibles restantes
    public GameObject ImageFin;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        UpdateTargetsRemaining();
    }

    public void TargetHit()
    {
        targetsHit++;
        UpdateTargetsRemaining();
        CheckGameEnd();
    }

    private void UpdateTargetsRemaining()
    {
        int targetsRemaining = totalTargets - targetsHit;
        targetsRemainingText.text = "Cibles restantes: " + targetsRemaining;
    }

    private void CheckGameEnd()
    {
        if (targetsHit >= totalTargets)
        {
            Debug.Log("Toutes les cibles ont été touchées. Jeu terminé !");
            ImageFin.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}