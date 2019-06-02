using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.Text;


public enum GameState
{
    Intro,
    lvl1,
    lvl2,
    lvl3,
    ending
}



public class GameStateManager : MonoBehaviour
{
    public static GameState gamestate;
    private bool Continue;
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameManager");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
        
    }

    void Start()
    {
        if(gamestate != GameState.Intro)
        {
            GameObject.Find("Canvas/ui/MAIN MENU/Continue").SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
