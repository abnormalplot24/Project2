using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDecider : MonoBehaviour
{
    public AudioClip ActionMusic;
    public AudioClip DefaultMusic;

    // Start is called before the first frame update
    void Start()
    {
        if(StateNameController.what_to_spawn_string == "Squirrel")
        {
            GetComponent<AudioSource>().clip = ActionMusic;
        }
        else
        {
            GetComponent<AudioSource>().clip = DefaultMusic;

        }
    }

    // Update is called once per frame

}
