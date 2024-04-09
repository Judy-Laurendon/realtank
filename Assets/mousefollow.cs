using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    private Camera cam;
    public float followDistance = 10.0f; // Distance devant la caméra à laquelle l'objet doit se situer

    void Start()
    {
        cam = Camera.main; // Plus sûr de cette façon, au cas où le nom de votre caméra principale change
    }

    void Update()
    {
        // Calcule la position du monde pour le curseur à une certaine distance de la caméra
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = followDistance; // Vous pouvez ajuster cela pour être dynamique si nécessaire
        Vector3 worldPosition = cam.ScreenToWorldPoint(mousePosition);

        // Oriente l'objet pour qu'il regarde vers la position cible, ajustez selon les besoins pour rotation complète
        Vector3 direction = (worldPosition - transform.position).normalized;
        // Assurez-vous que la direction n'est pas nulle (l'objet n'essaie pas de regarder vers lui-même)
        if (direction != Vector3.zero)
        {
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            // S'applique la rotation. Vous pouvez également interpoler pour une transition plus douce avec Quaternion.Lerp ou Quaternion.Slerp
            transform.rotation = lookRotation;
        }
    }
}