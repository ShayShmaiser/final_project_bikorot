using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aCross : MonoBehaviour
{
    [SerializeField] private GameObject CrossObj;
    [SerializeField] public GameObject Cross;
    [SerializeField] public GameObject empty;


    private void OnTriggerExit(Collider other)
    {
        CrossObj.SetActive(false);
        Cross.SetActive(true);
        empty.SetActive(true);
    }
}
