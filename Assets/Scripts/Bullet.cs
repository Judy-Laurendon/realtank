using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3; // Durée de vie de la balle avant auto-destruction

    void Awake()
    {
        Destroy(gameObject, life); // Détruit automatiquement la balle après 'life' secondes
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target")) // Vérifie si l'objet touché est une cible
        {
            Destroy(collision.gameObject); // Détruit la cible
            TargetManager.instance.TargetHit(); // Notifie le TargetManager qu'une cible a été touchée
            Destroy(gameObject); // Détruit la balle
        }
    }
}