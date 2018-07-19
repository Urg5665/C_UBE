using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    private GameObject cameraObject;

    [SerializeField]
    private GameObject pcObj;
    [SerializeField]
    private float camDistance = 0f;

    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float currentZ = 0.0f;




    void Start () {
      
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;


		
	}
	// Update is called once per frame
    private void Update ()
    {
        currentX += Input.GetAxis("Mouse X");
        currentY -= Input.GetAxis("Mouse Y");
        currentZ += Input.GetAxis("Mouse Z");

        


    }


    private void FixedUpdate() {


       Vector3 dir = new Vector3(0, 0, -camDistance);
       //set the rotation of the camera
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);

        //lerp camera positon to new positoin                 -define new position as pc positon, offset by the rotation, 
        //Move Backwards 

        //multiplying a positiong by a qyaternion rotatest the positon


        transform.position = Vector3.Lerp(transform.position,pcObj.transform.position + rotation * dir, 1f * Time.deltaTime);
        transform.LookAt(pcObj.transform.position);
        






    }
    
}
/*
 * 
 *     float smooth = 5.0f;
    float tiltAngle = 60.0f;

    void Update()
    {
        // Smoothly tilts a transform towards a target rotation.
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);

 
     
     
     


    
       transform.rotation = new Quaternion(0,currentX, 0, 1);
       transform.position = Vector3.Lerp(transform.position, pcObj.transform.position + rotation * dir, 1f * Time.deltaTime);


     */


