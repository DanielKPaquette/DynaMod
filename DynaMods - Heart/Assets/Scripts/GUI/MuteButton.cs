using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteButton : MonoBehaviour
{
    public GameObject labelsParent;
    public SpriteRenderer sprite;
    public Sprite muteSprite;
    public Sprite soundSprite;
    private AudioSource[] audioSources;
    private bool muted = false;
    // Start is called before the first frame update
    void Start()
    {
        audioSources = labelsParent.GetComponentsInChildren<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localPosition = new Vector3(Screen.width/2.5f, Screen.height/2.8f);
    }

    void OnMouseUp()
    {
        muted = !muted;
        if (muted) 
        {
            sprite.sprite = muteSprite;
            foreach(AudioSource audioClip in audioSources)
            {
                audioClip.mute = true;
            }
        }
        else
        {
            sprite.sprite = soundSprite;
            foreach (AudioSource audioClip in audioSources)
            {
                audioClip.mute = false;
            }
        }
    }
}