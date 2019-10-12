using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabelRotate : MonoBehaviour
{
    //The point we are rotating around
    public GameObject axisPoint;

    //Distance we want between the label and the axis point
    public float labelDistance = 1.0f;

    //Rotation of 0,0,0 to keep the label always facing towards the camera and with no rotation
    private Vector3 setPosition = new Vector3(0, 0, 0);

    //The currentPosition of the label
    private Vector3 currentPosition;

    void Start()
    {
        //Set the label to start with facing forward with no rotation
        transform.eulerAngles = setPosition;

        //Move the label the correct distance away from the axis point 
        transform.position = (transform.position - axisPoint.transform.position).normalized * labelDistance + axisPoint.transform.position;

        //Get the current position once we have moded the label to its proper starting place
        currentPosition = transform.position;
    }

    void Update()
    {
        //Check if the label has rotated since the last frame and correct rotation if it has
        if(transform.eulerAngles != setPosition)
        {
            transform.eulerAngles = setPosition;
        }

        //Modify the position of the label if it has moved since last frame
        if(transform.position != currentPosition)
        {
            transform.position = (transform.position - axisPoint.transform.position).normalized * labelDistance + axisPoint.transform.position;
            currentPosition = transform.position;
        }
    }
}