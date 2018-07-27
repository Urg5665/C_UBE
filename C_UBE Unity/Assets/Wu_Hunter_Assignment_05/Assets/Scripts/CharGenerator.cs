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
        agitated = (Random.value > 0.5f);
        confused = (Random.value > 0.5f);
        angry = (Random.value > 0.5f);

        //Debug.Log(agitated);
        //Debug.Log(confused);
        //Debug.Log(angry);





    }

    // Update is called once per frame
    void Update () {
		
	}


}
