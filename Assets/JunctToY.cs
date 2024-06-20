using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JunctToY : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private BoxCollider JunctiToY;

    private void OnTriggerEnter(Collider other)
    {
        over();
    }
    public void over()
    {
        SceneManager.LoadScene("ending");
    }
}
