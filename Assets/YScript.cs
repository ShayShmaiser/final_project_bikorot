using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YScript : MonoBehaviour
{
    [SerializeField] private GameObject CrossObj;
    [SerializeField] private GameObject Cross;
  
    private void OnTriggerExit()
    {
        CrossObj.SetActive(false);
        Cross.SetActive(true);
    }
}
