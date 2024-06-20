using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class CrossScript : MonoBehaviour
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
   
