using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerAction : MonoBehaviour
{

    public float AscendSpeed = 15f;
    // Start is called before the first frame update
    void OnTriggerStay(Collider other)
    {
        // other.GetComponent<Rigidbody>().AddForce(Vector3.up * AscendSpeed, ForceMode.Acceleration);
        GetComponent<Rigidbody>().AddForce(Vector3.up * AscendSpeed, ForceMode.Acceleration);
    }
}
