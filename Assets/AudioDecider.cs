using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDecider : MonoBehaviour
{
    public AudioClip squirrelMusic;
    public AudioClip defaultMusic;

    // Start is called before the first frame update
    void Start()
    {
        //determineSquirrel

    }

    // Update is called once per frame
    void Update()
    {
       if( GetComponent<isSquirrel>().squirrel_on_screen)
        {
            GetComponent<AudioSource>().clip = squirrelMusic;
        }
        else
        {
            GetComponent<AudioSource>().clip = defaultMusic;
        }
    }
}
