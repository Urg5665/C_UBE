using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueGenerator : MonoBehaviour {
    //    // Mark S  8_24
    // takes in characeter and runs through dialogue options

    public GameObject personWords;

    public GameObject character;



    public float bored; //  Calm
    public float confused; // Inspire
    public float angry; // Pressure

    public Button calm;
    public Button inspire;
    public Button pressure;



    public float phase;
    public bool correct;
    public bool charAlive;


    // Use this for initialization
    void Start () {

        calm = GameObject.Find("CalmButton").GetComponent<Button>();
        inspire = GameObject.Find("InspireButton").GetComponent<Button>();
        pressure = GameObject.Find("PressureButton").GetComponent<Button>();

        personWords = GameObject.Find("personWords");

        character = GameObject.Find("Character");



        bored = -1;
        confused = -1;
        angry = -1;


        phase = 0;
        correct = false;
        charAlive = false;

        character.SetActive(charAlive);


        calm.onClick.AddListener(calmClick0);
        inspire.onClick.AddListener(inspireClick0);
        pressure.onClick.AddListener(pressureClick0);

    }

    void calmClick0()
    {
        if (phase == 0)
            correct = true;
            bored += 1;
        if (bored == 0)
        {
            personWords.GetComponent<TextMesh>().text = "Phew, thats a relief.";
        }
        if (bored == 1)
        {
            personWords.GetComponent<TextMesh>().text = "Hey I'm fine - I'm ok now";
        }
        if (bored == 2)
        {
            personWords.GetComponent<TextMesh>().text = "Why are you still... Whats wrong?";
        }
        if (bored == 3)
        {
            personWords.GetComponent<TextMesh>().text = "You're hiding something about the C_UBE";
        }
        if (bored == 4)
        {
            personWords.GetComponent<TextMesh>().text = "Nope. You're being creepy. I'm gone.(Press Q)";
            phase = 1;
        }
    }

    void inspireClick0()
    {
        if (phase == 0)
        {
            correct = true;
            confused += 1;

        }
        if (confused == 0)
        {
            personWords.GetComponent<TextMesh>().text = "Wow... thats impressive. ";
        }
        if (confused == 1)
        {
            personWords.GetComponent<TextMesh>().text = "Alright I get it, its awesome and stuff ";
        }
        if (confused == 2)
        {
            personWords.GetComponent<TextMesh>().text = "Wait, One more time? " ;
        }
        if (confused == 3)
        {
            personWords.GetComponent<TextMesh>().text = "I'm not gonna lie... I'm lost";
        }
        if (confused == 4)
        {
            personWords.GetComponent<TextMesh>().text = "You had me, really. I'm just bored now( Press Q)";
            phase = 1;
        }
    }
 
    void pressureClick0()
    {
        if (phase == 0)
        {
            correct = true;
            angry += 1;

        }
        if (angry == 0)
        {
            personWords.GetComponent<TextMesh>().text = "Haha, Go easy on me";
        }
        if (angry == 1)
        {
            personWords.GetComponent<TextMesh>().text = "Jeez... Alright.";
        }
        if (angry == 2)
        {
            personWords.GetComponent<TextMesh>().text = "I don't care for your tone";
        }
        if (angry == 3)
        {
            personWords.GetComponent<TextMesh>().text = "Calm down, please";
        }
        if (angry == 4)
        {
            personWords.GetComponent<TextMesh>().text = "F*** off, You can't make me. Peace (Press Q)";
            phase = 1;
        }

    }

    // Update is called once per frame
    void FixedUpdate() {

        character.SetActive(charAlive);

        if (Input.GetKey(KeyCode.Q))
        {

            if(phase == 0)
            {
                personWords.GetComponent<TextMesh>().text = "Tell Me More About the C_UBE";
                charAlive = true;
            }
            if (phase == 1)
            {
                personWords.GetComponent<TextMesh>().text = " ";
                charAlive = false;
                personWords.SetActive(false);
            }

        }
            
    }

    IEnumerator WaitUntilReloaded()
        {
            yield return new WaitForSeconds(300);
        }

    }


