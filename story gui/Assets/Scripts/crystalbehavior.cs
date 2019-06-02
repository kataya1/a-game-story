using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class crystalbehavior : MonoBehaviour
{
    // public static float AscendSpeed = 0.5f;
    // public double descend = 2.0f;
    public GameObject hoverpad;
    // Vector3 movamout = new Vector3(0,AscendSpeed,0);
    void OnMouseOver()
    {
        // Change the color of the GameObject to red when the mouse is over GameObject
        // crystal.transform.Translate(movamout);
        hoverpad.GetComponent<CapsuleCollider>().enabled = true;
        
    }


    void OnMouseExit()
    {
        // Reset the color of the GameObject back to normal
        hoverpad.GetComponent<CapsuleCollider>().enabled = false;
    }
}

