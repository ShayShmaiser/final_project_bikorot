using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CONTINUE : MonoBehaviour
{
    public void OPENGAME()
    {
        SceneManager.LoadScene("game");
    }
}
