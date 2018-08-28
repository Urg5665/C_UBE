using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnOffUI : MonoBehaviour {


    public Canvas dUI;

    public bool isOn;

    public Canvas RetUI;

   

    

	// Use this for initialization
	void Start () {

        dUI = GetComponent<Canvas>();
        RetUI = GameObject.Find("ReticuleCanvas").GetComponent<Canvas>();
        isOn = false;
    }
	
	// Update is called once per frame
	void Update () {

        if (((Input.GetKeyDown(KeyCode.Q)) && !isOn)) {
            dUI.enabled = true;
            RetUI.enabled = false;
            isOn = true;  
        }
        else if (((Input.GetKeyDown(KeyCode.Q)) && isOn))
        {
            dUI.enabled = false;
            RetUI.enabled = true;
            isOn = false;
        }

    }
}

