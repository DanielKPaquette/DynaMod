using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoPlacement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(0, Screen.height/2.8f);
    }
}