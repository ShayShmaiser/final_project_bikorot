using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kto29R : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private BoxCollider KHacia29r;

    private void OnTriggerEnter(Collider other)
    {
        over();
    }
    public void over()
    {
        SceneManager.LoadScene("ending");
    }
}
