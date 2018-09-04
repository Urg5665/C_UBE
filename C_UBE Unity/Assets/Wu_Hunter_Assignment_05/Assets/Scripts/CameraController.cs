using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Mark S 9_4
public class CameraController : MonoBehaviour {

    private GameObject cameraTarget;

    private GameObject character;
   

    [SerializeField]
    private GameObject pcObj;
    [SerializeField]
    private float camDistance = 0f;

    private float currentX = 0.0f;
    private float currentY = 0.0f;

    public Camera fpsCam;

    public float targetDistance;

    public Vector3 cameraOrigin;

    public GameObject sysText;

    public GameObject cabinet1;
    public GameObject cabinet2;


    //public LineRenderer laserLine;

    public OnOffUI check;

    void Start () {
      
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;

        cabinet1 = GameObject.Find("CabinetCanvas");
        cabinet2 = GameObject.Find("CabinetCanvas (1)");

        fpsCam = GetComponent<Camera>();

        sysText = GameObject.Find("sysText");

        Ray ray = fpsCam.ScreenPointToRay(Input.mousePosition);

        cabinet1.SetActive(false);
        cabinet2.SetActive(false);


    }
    private void Update ()
    {
        currentX += Input.GetAxis("Mouse X");
        currentY += Input.GetAxis("Mouse Y");

        check = GameObject.Find("Canvas").GetComponent<OnOffUI>();

        character = GameObject.Find("CharacterPivot");

        cameraOrigin = this.transform.position;
            

    }


    private void FixedUpdate() {

        if (Input.GetKey(KeyCode.Q))
        {
            Cursor.lockState = CursorLockMode.None;
            transform.LookAt(character.transform.position);
        }

        RaycastHit hit;

        if (!check.isOn){
            Vector3 dir = new Vector3(0, 0, camDistance);
            Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);

            Cursor.lockState = CursorLockMode.Locked;



            transform.position = Vector3.Lerp(transform.position, pcObj.transform.position + rotation * dir, 16f * Time.deltaTime);
            transform.LookAt(pcObj.transform.position);

            

            if (Physics.Raycast(cameraOrigin, fpsCam.transform.forward, out hit))
            {
                targetDistance = hit.distance;

                Transform targetTransform = hit.transform;

                GameObject targetObject = targetTransform.gameObject;

                sysText.GetComponent<Text>().text = targetObject.name;

                Animator targetAnimation = targetObject.GetComponent<Animator>();

                bool isOn = targetAnimation.enabled;




                if (Input.GetKeyDown(KeyCode.E) && !isOn)
                {

                    targetAnimation.enabled = true;
                    if (targetObject.name == GameObject.Find("Cabinet (E)").name)
                    {
                        cabinet1.SetActive(true);
                    }
                    if (targetObject.name == GameObject.Find("Filing_Cabinet_Open (1)").name)
                    {
                        cabinet2.SetActive(true);
                    }

                }
                else if (Input.GetKeyDown(KeyCode.E) && isOn)
                {
                    targetAnimation.enabled = false;
                    if (targetObject.name == GameObject.Find("Cabinet (E)").name)
                    {
                        cabinet1.SetActive(false);
                    }
                    if (targetObject.name == GameObject.Find("Filing_Cabinet_Open (1)").name)
                    {
                        cabinet2.SetActive(false);
                    }

                }
               





            }
            else
            {
                sysText.GetComponent<Text>().text =  " ";
            }






        }






    }


    }
    

/*
 * 


 
     
    


     */


