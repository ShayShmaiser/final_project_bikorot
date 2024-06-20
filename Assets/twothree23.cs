using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twothree23 : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private BoxCollider tootree;


    private void OnTriggerEnter(Collider tootree)
    {
        player.transform.position = respawnPoint.transform.position;
    }
}
