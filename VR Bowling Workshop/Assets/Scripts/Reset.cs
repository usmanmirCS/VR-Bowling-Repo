using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }
}
