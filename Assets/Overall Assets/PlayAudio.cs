using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(BackgroundMusic.Instance != null && !BackgroundMusic.Instance.gameObject.GetComponent<AudioSource>().isPlaying)
        {
            BackgroundMusic.Instance.gameObject.GetComponent<AudioSource>().Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
