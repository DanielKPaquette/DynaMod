using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LabelClick : MonoBehaviour
{
    //A .txt file that we read from to get the information text for the current label
    public TextAsset informationText;

    //The audio clip that will be played when the label is clicked
    public AudioSource labelAudio;

    //The GUIStyle for this label, deretmines the text color, background, and padding for the text
    public GUIStyle textBoxStyling;

    //A Vector2 for keeping track of scroll position
    private Vector2 scrollPosition;

    //Track if we have clicked on the label
    private bool isClicked = false;

    //Check if OnMouseUp has been called when we click, if not we will hid our textbox
    private bool mouseUpCalled = false;

    //Called once per frame
    void Update()
    {
        //When we click see if we have clicked on the label, if not hide the textbox
        if(Input.GetMouseButtonUp(0) && !mouseUpCalled)
        {
            //We have clicked away from the label, stop displaying the textbox
            isClicked = false;
            //Reset the scrollbar position
            scrollPosition = Vector2.zero;

            //Stop any audio that is playing
            labelAudio.Stop();
            //Reset the audio to the beginning
            labelAudio.time = 0;
        }
        else if(mouseUpCalled)
        {
            //Set variable back to false if it is still true to prevent false positives
            mouseUpCalled = false;
        }
    }

    //Called when the collider for the label object is clicked 
    void OnMouseUp() 
    {
        //Toggle the text box if clicked multiple times
        isClicked = !isClicked;

        //Play the audio track when the label is clicked
        if(isClicked)
        {
            labelAudio.Play();
        }
        else
        {
            //Stop the audio track and reset it to the beginning for the next time it is clicked
            labelAudio.Stop();
            labelAudio.time = 0;
        }

        //Tell update function that we have clicked on the label this frame
        mouseUpCalled = true;
    }

    private void OnGUI()
    {
        //Display a textbox when we click on the label
        if (isClicked)
        {
            //Dynamically change the font size to match the screen resolution
            textBoxStyling.fontSize = Screen.width / 50;

            /*
             * Create a scroll view, dynamically set its boundaries and inner 
             * content boundaries from the screen size, also get the current 
             * scroll position and update when we move the scroll bar
            */            
            scrollPosition = GUI.BeginScrollView(new Rect(0, Screen.height - Screen.height/6, Screen.width, Screen.height/7), 
                scrollPosition, new Rect(0, 0, Screen.width-Screen.width/50, Screen.height));

            //Make a label that dispalys the text of our information file
            GUI.Label(new Rect(0, 0, Screen.width, Screen.height), informationText.text, textBoxStyling);

            //End the scroll view that we began above.
            GUI.EndScrollView();
        }
    }
}