using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnOffUI : MonoBehaviour {


    public Canvas dUI;

    public bool isOn;

    

	// Use this for initialization
	void Start () {

        //buttonImage = GetComponent<Image>();

        dUI = GetComponent<Canvas>();

        isOn = false;

    }
	
	// Update is called once per frame
	void Update () {

        

        if ((Input.GetKeyDown(KeyCode.E)) && !isOn) {
            dUI.enabled = true;
            isOn = true;  
        }
        else if ((Input.GetKeyDown(KeyCode.E)) && isOn)
        {
            dUI.enabled = false;
            isOn = false;
        }

    }
}
/*
         if ((Input.GetKeyDown(KeyCode.E))) {
            isOn = true;  
        }
        if (isOn)
        {
            dUI.enabled = true;
        }
        else if (!isOn)
        {
            dUI.enabled = false;

        }
     */
