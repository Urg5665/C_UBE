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
            personWords.GetComponent<TextMesh>().text = "Nope. You're being creepy. I'm gone.(Q)";
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
            personWords.GetComponent<TextMesh>().text = "You had me, really. I'm just bored now(Q)";
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
            personWords.GetComponent<TextMesh>().text = "F*** off, You can't make me. Peace(Q)";
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

/*
 *                 if (phase == 0)
                {
                    personWords.GetComponent<TextMesh>().text = "Is this my briefing room? (Press E for options)";
                    correct = true;
                }

                if (phase == .5)
                {
                    personWords.GetComponent<TextMesh>().text = " There are many prerequisites that I don’t meet " +
                        " to be C_UBE volunteer personnel. Why was I picked?";
                    correct = true;
                }
                if (phase == 1.5)
                {
                    personWords.GetComponent<TextMesh>().text = "Nobody knows anything about the C_UBE and nobody has returned to talk about it. What am I supposed to expect?";
                    correct = true;
                }
                if (phase == 2.5)
                {
                    //personWords.GetComponent<TextMesh>().text = "Alright, that was a strong debriefing. Any last thoughts on my application? ";
                    correct = true;
                }

 *       
             if (bored == 0 && angry == 0 && confused == 0)
            {
                if (phase == 3)
                {
                    personWords.GetComponent<TextMesh>().text = "Alright, that was a strong debriefing. Any last thoughts on my application? ";
                    correct = true;
                }
            }
            if (Input.GetKey(KeyCode.E))
            {
                phase += 1f ;
                correct = false;
            }

    // old listeners

     void calmClick1()
    {
        if (phase == 1)
        {
            personWords.GetComponent<TextMesh>().text = "You’re sure about that? If you say so, I guess.(E)";
            correct = true;
            bored -= 1;
        }

    }
    void calmClick2()
    {
        if (phase == 2)
        {
            personWords.GetComponent<TextMesh>().text = "I’m kind of still in the dark ... ";
            correct = true;
        }

    }
    void calmClick3()
    {
        if (phase == 3)
        {
            personWords.GetComponent<TextMesh>().text = "Phew, I was kind of scared but that wasn’t that bad. See you.";
            correct = true;
            bored -= 1;

        }

        void inspireClick1()
    {
        if (phase == 1)
        {
            personWords.GetComponent<TextMesh>().text = "Okay, I’m confused. You aren’t being reasonable here.";
            correct = true;

        }
    }
    void inspireClick2()
    {
        if (phase == 2)
        {
            personWords.GetComponent<TextMesh>().text = "Okay, it sounds like everyone should be allowed to try it at least once.(E)";
            correct = true;
            confused -= 1;
        }
    }
    void inspireClick3()
    {
        if (phase == 3)
        {
            personWords.GetComponent<TextMesh>().text = "Thanks, you have a nice day!";
            correct = true;
      
        }

       inspire.onClick.AddListener(inspireClick1);
        inspire.onClick.AddListener(inspireClick2);
        inspire.onClick.AddListener(inspireClick3);


 */
