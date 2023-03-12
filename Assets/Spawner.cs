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
    // Start is called before the first frame update
    void Start()
    {

        Input.location.Start();


        // If the service didn't initialize in 20 seconds this cancels location service use.

       
            // If the connection succeeded, this retrieves the device's current location and displays it in the Console window.
            print("Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp);


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
            print(StateNameController.what_to_spawn);
            currentLocation = new Vector3(cursor.transform.position.x, cursor.transform.position.y, cursor.transform.position.z);
            interactiveTree.transform.position = new Vector3(Input.location.lastData.latitude, Input.location.lastData.altitude - 3.0f, Input.location.lastData.longitude + 10.0f);
            interactiveTree.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
            interactiveTree.transform.rotation = new Quaternion(0.0f, 180.0f, 0.0f, 0.0f);
        }
    


    }

    // Update is called once per frame
    void Update()
    {

        if (StateNameController.what_to_spawn_string == "Squirrel" & StateNameController.squirrel_killed == true)
        {
            GetComponent<AudioSource>().Stop();
            GetComponent<AudioSource>().PlayOneShot(GruntDeath);

            GetComponent<AudioSource>().clip = defaultMusic;
            GetComponent<AudioSource>().Play();
        }
        if(StateNameController.what_to_spawn_string == "FinalBoss" & !StateNameController.final_boss_present)
        {
            GetComponent<AudioSource>().Stop();
            GetComponent<AudioSource>().PlayOneShot(BossDeath);

            GetComponent<AudioSource>().clip = defaultMusic;
            GetComponent<AudioSource>().Play();

        }
    }
}
