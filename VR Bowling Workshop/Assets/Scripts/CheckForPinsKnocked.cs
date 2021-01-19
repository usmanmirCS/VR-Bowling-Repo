using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForPinsKnocked : MonoBehaviour
{
    public GameObject ps;
    public int pinCount = 10;
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Pin")
        {
            pinCount--;
            if(pinCount == 0)
            {
                ps.SetActive(true);
            }
        }
    }
}
