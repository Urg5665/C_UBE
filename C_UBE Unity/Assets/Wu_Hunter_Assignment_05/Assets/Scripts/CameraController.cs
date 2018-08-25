using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Mark S 8_24
public class CameraController : MonoBehaviour {
    private GameObject cameraObject;

    [SerializeField]
    private GameObject pcObj;
    [SerializeField]
    private float camDistance = 0f;

    private float currentX = 0.0f;
    private float currentY = 0.0f;

    public Camera fpsCam;

    public Transform cameraOrigin;

    public LineRenderer laserLine;

    public OnOffUI check;

    void Start () {
      
        //Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;

        laserLine = GetComponentInChildren<LineRenderer>();

        fpsCam = GetComponent<Camera>();

        RaycastHit hit;
        Ray ray = fpsCam.ScreenPointToRay(Input.mousePosition);


    }
    private void Update ()
    {
        currentX += Input.GetAxis("Mouse X");
        currentY += Input.GetAxis("Mouse Y");

        check = GameObject.Find("Canvas").GetComponent<OnOffUI>();

        cameraOrigin = this.transform;
    }


    private void FixedUpdate() {

       if (!check.isOn){
            Vector3 dir = new Vector3(0, 0, camDistance);
            Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);


            transform.position = Vector3.Lerp(transform.position, pcObj.transform.position + rotation * dir, 16f * Time.deltaTime);
            transform.LookAt(pcObj.transform.position);

            


            laserLine.enabled = true;



             
         


        }


    }
    
}
/*
 * 


 
     
    


     */


