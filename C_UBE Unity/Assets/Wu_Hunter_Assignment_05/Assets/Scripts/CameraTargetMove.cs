using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTargetMove : MonoBehaviour {

    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float currentZ = 0.0f;

    // Use this for initialization
    void Start () {


}
	
	// Update is called once per frame
	private void Update () {

    currentX += Input.GetAxis("Mouse X");
    currentY += Input.GetAxis("Mouse Y");
    currentZ += Input.GetAxis("Mouse Z");
    }

    private void FixedUpdate()
{
        transform.position = new Vector3(currentX/2, currentY/2, currentZ/2);
}
}
