using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public float distanceFromPlayer = 5;
    public float height = 2;
    void Update()
    {
        transform.position = player.transform.position - player.transform.forward * distanceFromPlayer;
        transform.LookAt(player.transform.position);
        transform.position = new Vector3(transform.position.x, transform.position.y + height, transform.position.z);
    }
}
