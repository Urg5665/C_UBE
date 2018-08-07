using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueGenerator : MonoBehaviour {
    //    // Mark S  7_27
    // takes in characeter and runs through dialogue options

    //public GameObject person;

    //public int score;


    public bool agitated; //  Calm
    public bool confused; // Inspire
    public bool angry; // Pressure

    public Button calm;
    public Button inspire;
    public Button pressure;

    public Text personWords;

    public int phase;
    public bool correct;





    // Use this for initialization
    void Start () {

        //person = GameObject.Find("James").GetComponent<CharGenerator>();


        calm = GameObject.Find("CalmButton").GetComponent<Button>();
        inspire = GameObject.Find("InspireButton").GetComponent<Button>();
        pressure = GameObject.Find("PressureButton").GetComponent<Button>();



        personWords = GameObject.Find("personWords").GetComponent<Text>();

        agitated = true;
        angry = true;
        confused = false;

        phase = 0;
        correct = false;



        calm.onClick.AddListener(calmClick0);
        calm.onClick.AddListener(calmClick1);
        calm.onClick.AddListener(calmClick2);
        calm.onClick.AddListener(calmClick3);

        inspire.onClick.AddListener(inspireClick0);
        inspire.onClick.AddListener(inspireClick1);
        inspire.onClick.AddListener(inspireClick2);
        inspire.onClick.AddListener(inspireClick3);

        pressure.onClick.AddListener(pressureClick0);
        pressure.onClick.AddListener(pressureClick1);
        pressure.onClick.AddListener(pressureClick2);
        pressure.onClick.AddListener(pressureClick3);




    }

    void calmClick0()
    {
        if (phase == 0)
        {
            personWords.text = "Uh ... sounds good. Let’s begin?";
            correct = true;

        }

    }
    void calmClick1()
    {
        if (phase == 1)
        {
            personWords.text = "You’re sure about that? If you say so, I guess.";
            correct = true;
        }

    }
    void calmClick2()
    {
        if (phase == 2)
        {
            personWords.text = "I’m kind of still in the dark ... ";
            
        }

    }
    void calmClick3()
    {
        if (phase == 3)
        {
            personWords.text = "Phew, I was kind of scared but that wasn’t that bad. See you.";
            correct = true;
        }

    }
    void inspireClick0()
    {
        if (phase == 0)
        {
            personWords.text = "Great. Let’s begin then.";
            correct = true;

        }
    }
    void inspireClick1()
    {
        if (phase == 1)
        {
            personWords.text = "Interesting. I guess I can be of use after all.";
            correct = true;

        }
    }
    void inspireClick2()
    {
        if (phase == 2)
        {
            personWords.text = "Okay, it sounds like everyone should be allowed to try it at least once.";
        }
    }
    void inspireClick3()
    {
        if (phase == 3)
        {
            personWords.text = "Thanks, you have a nice day!";
            correct = true;

        }
    }
    void pressureClick0()
    {
        if (phase == 0)
        {
            personWords.text = "Alright, let’s do this.";
            correct = true;

        }
    }
    void pressureClick1()
    {
        if (phase == 1)
        {
            personWords.text = "Okay, I’m confused. You aren’t being reasonable here.";
            

        }
    }
    void pressureClick2()
    {
        if (phase == 2)
        {
            personWords.text = "I’m not sure I want to do this.";
            

        }
    }
    void pressureClick3()
    {
        if (phase == 3)
        {
            personWords.text = "There’s no way I’m leaving the planet after all. I’m going home now.";
            correct = true;

        }
    }



    // Update is called once per frame
    void FixedUpdate() {

        if (correct)
        {
            phase++;
            correct = false;
            if (phase == 1)
            {
                WaitUntilReloaded();

                //personWords.text = "There are many prerequisites that I don’t meet to be Q_UBE volunteer personnel. Why was I picked?";
            }
            if (phase == 2)
            {
                WaitUntilReloaded();
                //personWords.text = "Nobody knows anything about the Q_UBE and nobody has returned to talk about it. What am I supposed to expect?";
            }
            if (phase == 3)
            {
                WaitUntilReloaded();
                //personWords.text = "Alright, that was a good debriefing. I hope the results come soon. Let me know ASAP about my position.";
            }
        }
    }

    IEnumerator WaitUntilReloaded()
        {
            yield return new WaitForSeconds(300);
        }

    }

/*
 *       

 */
