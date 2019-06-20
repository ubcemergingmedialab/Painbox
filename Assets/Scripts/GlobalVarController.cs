using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVarController : MonoBehaviour {
    public int decider;
    private static bool created = false;

    public GlobalVarController instance = null;
    void Awake()
    {
        PlayerPrefs.SetInt("Vertical", 0);
        PlayerPrefs.SetInt("Horizontal", 0);
        if (!created)
        { DontDestroyOnLoad(this.gameObject);
            created = true;
        }
       
       
        
    }


    public void VerticalChanger()
    {
       decider = 1;
        PlayerPrefs.SetInt("Vertical",1);
        PlayerPrefs.SetInt("Horizontal", 0);
        print(1);
    }

    public void HorizontalChanger()
    {
        decider = 2;
        PlayerPrefs.SetInt("Vertical", 0);
        PlayerPrefs.SetInt("Horizontal", 1);
        print(2);
    }
    public int getDecider()
    {
        return decider;
    }




}
