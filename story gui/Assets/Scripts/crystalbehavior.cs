using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class crystalbehavior : MonoBehaviour
{
    // public static float AscendSpeed = 0.5f;
    // public double descend = 2.0f;
    // public GameObject Crystal;
    // Vector3 movamout = new Vector3(0,AscendSpeed,0);
    public Animator animator;
    public string sceneName;
    public bool finale;
    public GameObject cutscene;
    public GameObject oldlvl;
    
    void Start()
    {
        
    }
    void OnMouseOver()
    {
        // Change the color of the GameObject to red when the mouse is over GameObject
        // crystal.transform.Translate(movamout);
        // hoverpad.GetComponent<CapsuleCollider>().enabled = true;
        animator.SetBool("Hoveredover",true);
    }


    void OnMouseExit()
    {
        // Reset the color of the GameObject back to normal
        // hoverpad.GetComponent<CapsuleCollider>().enabled = false;
        animator.SetBool("Hoveredover",false);
    }
     void OnMouseDown()
    {
        // load a new scene
        //SceneManager.LoadScene(sceneName);
        cutscene.SetActive(true);
        oldlvl.SetActive(false);
        if(finale)
        {
             //GameObject.Find("Canvas/ui/MAIN MENU/Continue")
             GameObject.Find("level/daynightcycle/sun").GetComponent<daynightCycle>().enabled = true;
             GameObject.Find("level/daynightcycle/moon").GetComponent<daynightCycle>().enabled = true;
             GameObject.Find("timeline assets/Enemy/lvl1n2").SetActive(true);
        }
    }
}

