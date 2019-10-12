using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    //The label we are drawing the line from
    public GameObject label;

    //The reference point on the model we are drawing the line to
    public GameObject referencePoint;

    //The color of the line
    public Color lineColor;

    //The renderer for the line
    private LineRenderer line;

    //The position of the label, used to check if any changes hav occurred since the last frame
    private Vector3 labelPosition;

    //The position of the reference point, used to check if any changes hav occurred since the last frame
    private Vector3 referencePosition;
    
    //Use this for initialization
    void Start()
    {
        //Add a Line Renderer to the GameObject
        line = this.gameObject.AddComponent<LineRenderer>();

        // Set the width of the line
        line.startWidth = 0.05f;
        line.endWidth = 0.05f;

        //Set the number of vertex on the line
        line.positionCount = 2;

        //Draw the line
        line.SetPosition(0, label.transform.position);
        line.SetPosition(1, referencePoint.transform.position);

        //Set the line color
        line.material.color = lineColor;

        //Get initial positions for the label and reference point
        labelPosition = label.transform.position;
        referencePosition = referencePoint.transform.position;
    }

    //Update is called once per frame
    void Update()
    {
        //Update position of the two vertex of the Line Renderer if their position has changed since the last frame
        if(label.transform.position != labelPosition || referencePoint.transform.position != referencePosition)
        {
            //Set the new line positions
            line.SetPosition(0, label.transform.position);
            line.SetPosition(1, referencePoint.transform.position);

            //Update the current label and reference point positions
            labelPosition = label.transform.position;
            referencePosition = referencePoint.transform.position;
        }
    }
}