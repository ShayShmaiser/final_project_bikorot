using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LimaCross : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private BoxCollider LimaCrossing;

    private void OnTriggerEnter(Collider other)
    {
        over();
    }
    public void over()
    {
        SceneManager.LoadScene("ending");
    }
}
