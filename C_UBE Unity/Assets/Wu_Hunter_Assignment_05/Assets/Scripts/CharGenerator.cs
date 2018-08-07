using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharGenerator : MonoBehaviour {

    // Mark S
    // attach this to a given char pre fab to assign them a random character
  
    public bool agitated; //  Calm
    public bool confused; // Inspire
    public bool angry; // Pressure

    // Use this for initialization
    void Start () {

        agitated = true;
        angry = true;

        confused = false;

    }

    // Update is called once per frame
    void Update () {




    }


}
