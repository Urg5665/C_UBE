using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnOffUI : MonoBehaviour {


    public Canvas dUI;

    public bool isOn;

    

	// Use this for initialization
	void Start () {


        dUI = GetComponent<Canvas>();

        isOn = false;

    }
	
	// Update is called once per frame
	void Update () {

        if (((Input.GetKeyDown(KeyCode.Q)) && !isOn)) {
            dUI.enabled = true;
            isOn = true;  
        }
        else if (((Input.GetKeyDown(KeyCode.Q)) && isOn))
        {
            dUI.enabled = false;
            isOn = false;
        }

    }
}

