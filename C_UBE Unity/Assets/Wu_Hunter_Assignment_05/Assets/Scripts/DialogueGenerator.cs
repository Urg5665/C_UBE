using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueGenerator : MonoBehaviour {
    //    // Mark S  7_27
    // takes in characeter and runs through dialogue options

    public GameObject personWords;

    //public Component personWordsText;
    //public int score;


    public float agitated; //  Calm
    public float confused; // Inspire
    public float angry; // Pressure

    public Button calm;
    public Button inspire;
    public Button pressure;

    //public Text personWords;



    public float phase;
    public bool correct;





    // Use this for initialization
    void Start () {

        //person = GameObject.Find("James").GetComponent<CharGenerator>();


        calm = GameObject.Find("CalmButton").GetComponent<Button>();
        inspire = GameObject.Find("InspireButton").GetComponent<Button>();
        pressure = GameObject.Find("PressureButton").GetComponent<Button>();



        personWords = GameObject.Find("personWords");

        //personWordsText = personWords.

        agitated = 2;
        confused = 1;
        angry = 0;


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
            personWords.GetComponent<TextMesh>().text = "Uh ... sounds good. Let’s begin? (E) ";
            
            correct = true;
        }

    }
    void calmClick1()
    {
        if (phase == 1)
        {
            personWords.GetComponent<TextMesh>().text = "You’re sure about that? If you say so, I guess.(E)";
            correct = true;
            agitated -= 1;
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
            agitated -= 1;

        }

    }
    void inspireClick0()
    {
        if (phase == 0)
        {
            personWords.GetComponent<TextMesh>().text = "Great. Let’s begin then.(E)";
            correct = true;
        }
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
    }
    void pressureClick0()
    {
        if (phase == 0)
        {
            personWords.GetComponent<TextMesh>().text = "Jeez... Alright.(E)";
            correct = true;
        }
    }
    void pressureClick1()
    {
        if (phase == 1)
        {
            personWords.GetComponent<TextMesh>().text = "Please, You are coming on way too strong.";
            correct = true;
        }
    }
    void pressureClick2()
    {
        if (phase == 2)
        {
            personWords.GetComponent<TextMesh>().text = "Look, I’m not sure I want to do this.";
            correct = true;
        }
    }
    void pressureClick3()
    {
        if (phase == 3)
        {
            personWords.GetComponent<TextMesh>().text = "Wait ... There’s no way I’m leaving the planet now.";
            correct = true;
     
        }
    }



    // Update is called once per frame
    void FixedUpdate() {

        Debug.Log(agitated);
        Debug.Log(angry);
        Debug.Log(confused);




        if (correct)
        {
            if (agitated == 0 && angry == 0 && confused == 0)
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

 */
