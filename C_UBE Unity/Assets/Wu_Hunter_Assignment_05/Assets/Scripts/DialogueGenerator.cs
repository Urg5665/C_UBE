using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueGenerator : MonoBehaviour {
    //    // Mark S  8_24
    // takes in characeter and runs through dialogue options

    public GameObject personWords;
    public GameObject guardWords;

    public GameObject character;
    public GameObject guard;


    public float scared; //  Calm
    public float confused; // Inspire
    public float angry; // Pressure

    public Button calm;
    public Button inspire;
    public Button pressure;



    public float phase; // This Dude Is Important



    public bool correct;
    public bool charAlive;


    // Use this for initialization
    void Start () {

        calm = GameObject.Find("CalmButton").GetComponent<Button>();
        inspire = GameObject.Find("InspireButton").GetComponent<Button>();
        pressure = GameObject.Find("PressureButton").GetComponent<Button>();

        personWords = GameObject.Find("personWords");
        guardWords = GameObject.Find("guardWords");

        character = GameObject.Find("Character");
        guard = GameObject.Find("Guard_BaseModel");

        guard.SetActive(false);
        guardWords.SetActive(false);

        scared = -1;
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
            scared += 1;
        if (scared == 0)
        {
            personWords.GetComponent<TextMesh>().text = "Phew, thats a relief.";
        }
        if (scared == 1)
        {
            personWords.GetComponent<TextMesh>().text = "Hey I'm fine - I'm ok now";
        }
        if (scared == 2)
        {
            personWords.GetComponent<TextMesh>().text = "Why are you still... Whats wrong?";
        }
        if (scared == 3)
        {
            personWords.GetComponent<TextMesh>().text = "You're hiding something about the C_UBE";
        }
        if (scared == 4)
        {
            personWords.GetComponent<TextMesh>().text = "Nope. You're being too creepy.";
            
        }
        if (scared == 5)
        {
            personWords.GetComponent<TextMesh>().text = "(Press Q)";
            guardWords.SetActive(true);
            guardWords.GetComponent<TextMesh>().text = "I'm Gone";
            phase = 1;
        }
        if (confused == 5)
        {
            personWords.GetComponent<TextMesh>().text = "(Press Q)";
            guardWords.SetActive(true);
            guardWords.GetComponent<TextMesh>().text = "I hope you find someone smarter";
            phase = 1;

        }
        if (angry == 5)
        {
            guard.SetActive(true);
            guardWords.SetActive(true);
            guardWords.GetComponent<TextMesh>().text = "Sir, we are goin to have to ask you to leave";
            personWords.GetComponent<TextMesh>().text = "Press Q";
            phase = 1;
        }


        if (angry > 2 && confused > 2 && scared > 2)
        {
            guard.SetActive(true);
            guardWords.SetActive(true);
            guardWords.GetComponent<TextMesh>().text = "You have passed the psych exam";
            personWords.GetComponent<TextMesh>().text = "Todd will escort you to the C_UBE(Press Q)";
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
            personWords.GetComponent<TextMesh>().text = "You had me, really. I'm just bored now";
            
        }
        if (scared == 5)
        {
            personWords.GetComponent<TextMesh>().text = "(Press Q)";
            guardWords.SetActive(true);
            guardWords.GetComponent<TextMesh>().text = "I'm Gone";
            phase = 1;
        }
        if (confused == 5)
        {
            personWords.GetComponent<TextMesh>().text = "(Press Q)";
            guardWords.SetActive(true);
            guardWords.GetComponent<TextMesh>().text = "I hope you find someone smarter";
            phase = 1;

        }

        if (angry == 5)
        {
            guard.SetActive(true);
            guardWords.SetActive(true);
            guardWords.GetComponent<TextMesh>().text = "Sir, we are goin to have to ask you to leave";
            personWords.GetComponent<TextMesh>().text = "(Press Q)";
            phase = 1;
        }

        if (angry > 2 && confused > 2 && scared > 2)
        {
            guard.SetActive(true);
            guardWords.SetActive(true);
            guardWords.GetComponent<TextMesh>().text = "You have passed the psych exam";
            personWords.GetComponent<TextMesh>().text = "Todd will escort you to the C_UBE(Press Q)";
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
            personWords.GetComponent<TextMesh>().text = "F*** off, You can't make me.";
            
        }
        if (scared == 5)
        {
            personWords.GetComponent<TextMesh>().text = "(Press Q)";
            guardWords.SetActive(true);
            guardWords.GetComponent<TextMesh>().text = "I'm Gone";
            phase = 1;
        }
        if (confused == 5)
        {
            personWords.GetComponent<TextMesh>().text = "(Press Q)";
            guardWords.SetActive(true);
            guardWords.GetComponent<TextMesh>().text = "I hope you find someone smarter";
            phase = 1;

        }
        if (angry == 5 )
        {
            guard.SetActive(true);
            guardWords.SetActive(true);
            guardWords.GetComponent<TextMesh>().text = "Sir, we are goin to have to ask you to leave";
            personWords.GetComponent<TextMesh>().text = "Press Q";
            phase = 1;
        }

        if (angry > 2 && confused > 2 && scared > 2)
        {
            guard.SetActive(true);
            guardWords.SetActive(true);
            guardWords.GetComponent<TextMesh>().text = "You have passed the psych exam";
            personWords.GetComponent<TextMesh>().text = "Todd will escort you to the C_UBE(Press Q)";
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
                guard.SetActive(false);
                guardWords.SetActive(false);

            }

        }

        if (Input.GetKey(KeyCode.R))
        {
            phase = 0;
            scared = -1;
            confused = -1;
            angry = -1;
            personWords.SetActive(true);
            personWords.GetComponent<TextMesh>().text = "Am I at the Right Place? (Q)";

        }



            
    }




    }


