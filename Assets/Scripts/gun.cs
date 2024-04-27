using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ce script gère le tir de projectiles pour un personnage ou un objet dans le jeu.
public class gun : MonoBehaviour
{
    public Transform bulletSpawnPoint; // Point de départ du projectile; souvent attaché à la "bouche" du canon.
    public GameObject bulletPrefab; // Préfabriqué du projectile qui sera tiré.
    public float bulletSpeed = 10; // Vitesse à laquelle le projectile sera lancé.

    // Update est appelée une fois par image (frame), ce qui permet de gérer les entrées utilisateur.
    void Update()
    {
        // Vérifie si la touche Espace est pressée.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Crée une copie du préfabriqué de balle à la position et avec la rotation du point de tir.
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

            // Récupère le composant Rigidbody du projectile pour pouvoir manipuler sa physique.
            // Définit la vitesse du projectile en multipliant la direction "forward" du point de tir par la vitesse définie.
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        }
    }
}