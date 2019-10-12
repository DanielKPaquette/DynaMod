using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateModel : MonoBehaviour
{
    //The rotation speed of the model
    public float speed = 1.0f;

    //Update is called once per frame
    void Update()
    {
        //If we are holding down left click or touching the screen, rotate the model
        if (Input.GetMouseButton(0) || Input.touchCount > 0)
        {
            performRotation();
        }
    }

    private void performRotation()
    {
        /*
         * Get the position of the mouse/finger, increasing the speed by a factor 
         * of 100 so the rotation speed is quick
         */
        float xPos = Input.GetAxis("Mouse X") * 100 * speed * Mathf.Deg2Rad;
        float yPos = Input.GetAxis("Mouse Y") * 100 * speed * Mathf.Deg2Rad;

        /*
         * Rotate the object towards where the mouse/finger is being moved
         * Using world space instead on local space to keep rotation smooth
         */       
        transform.Rotate(Vector3.up, -xPos, Space.World);
        transform.Rotate(Vector3.right, yPos, Space.World);
    }
}