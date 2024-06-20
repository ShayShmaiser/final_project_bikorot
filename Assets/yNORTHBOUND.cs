using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yNORTHBOUND : MonoBehaviour
{
    [SerializeField] private BoxCollider yy;
    [SerializeField] private GameObject Y;


   public void OnTriggerEnter(Collider yy)
    {
        Y.SetActive(false);
   }
}
