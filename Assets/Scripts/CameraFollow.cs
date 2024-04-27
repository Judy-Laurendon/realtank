using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ce script permet à la caméra de suivre le joueur dans le jeu.
public class CameraFollow : MonoBehaviour
{
    public GameObject player; // Référence au GameObject du joueur que la caméra doit suivre.
    public float distanceFromPlayer = 5; // Distance horizontale entre la caméra et le joueur.
    public float height = 2; // Hauteur verticale de la caméra par rapport au joueur.

    // La fonction Update est appelée une fois par frame.
    void Update()
    {
        // Définit la position de la caméra pour qu'elle suive le joueur tout en restant à une distance définie derrière lui.
        // Cela utilise la position du joueur et recule la caméra en arrière selon la direction du joueur (forward).
        transform.position = player.transform.position - player.transform.forward * distanceFromPlayer;

        // Oriente la caméra pour qu'elle regarde toujours vers le joueur.
        transform.LookAt(player.transform.position);

        // Ajuste la hauteur de la caméra en ajoutant la valeur 'height' à la composante y de la position de la caméra.
        transform.position = new Vector3(transform.position.x, transform.position.y + height, transform.position.z);
    }
}