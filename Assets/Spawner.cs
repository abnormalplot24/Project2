using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mapbox;
using Mapbox.Utils;
using Mapbox.Unity.Map;
using TMPro;
using UnityEngine.UI;
public class Spawner : MonoBehaviour
{
    public static Vector3 currentLocation;
    public GameObject cursor;
    private GameObject interactiveTree;
    public AudioClip You_Will_Die;
    public AudioClip BossMusic;
    public AudioClip SquirrelSong;
    public AudioClip defaultMusic;
    public AudioClip GruntDeath;
    public AudioClip BossDeath;
    public GameObject arCamera;

    // Start is called before the first frame update
    void Start()
    {




        // Waits until the location service initializes

        // If the service didn't initialize in 20 seconds this cancels location service use.


        // If the connection succeeded, this retrieves the device's current location and displays it in the Console window.
        print("ARE YOU SEEING THIS???");
        if (StateNameController.spawn_anything)
        {

            print("DOO WE GET HEEREE");

            // We can put audio cues here maybe

            if(StateNameController.what_to_spawn_string == "FinalBoss")
            {
                GetComponent<AudioSource>().clip = BossMusic;
                GetComponent<AudioSource>().Play();
                GetComponent<AudioSource>().PlayOneShot(You_Will_Die);

            }
            else if(StateNameController.what_to_spawn_string == "Squirrel")
            {

                GetComponent<AudioSource>().clip = SquirrelSong;
                GetComponent<AudioSource>().Play();
                StateNameController.squirrel_killed = false;
                    

            }
            interactiveTree = Instantiate(StateNameController.what_to_spawn);
            interactiveTree.transform.position = new Vector3(arCamera.transform.position.x + 0.0f, arCamera.transform.position.y -3.0f, arCamera.transform.position.z + 18.0f);
            interactiveTree.transform.rotation = new Quaternion(0.0f, 180.0f,0.0f, 0.0f);
            print(StateNameController.what_to_spawn);
        }
    


    }

    // Update is called once per frame
    void Update()
    {

        if (StateNameController.what_to_spawn_string == "Squirrel" & StateNameController.squirrel_killed == true)
        {
            GetComponent<AudioSource>().clip = GruntDeath;

            GetComponent<AudioSource>().Play();

            GetComponent<AudioSource>().clip = defaultMusic;
            GetComponent<AudioSource>().Play();
        }
        if(StateNameController.what_to_spawn_string == "FinalBoss" & !StateNameController.final_boss_present)
        {
            GetComponent<AudioSource>().PlayOneShot(BossDeath);

            GetComponent<AudioSource>().clip = defaultMusic;
            GetComponent<AudioSource>().Play();

        }
    }
}
