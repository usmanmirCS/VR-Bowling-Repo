using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRecoverer : MonoBehaviour
{
    public Transform m_recoverSpot;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            other.transform.position = m_recoverSpot.position;
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }
}
