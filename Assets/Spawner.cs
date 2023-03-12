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

    // Start is called before the first frame update
    void Start()
    {

        Input.location.Start();

        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            maxWait--;
        }

        // If the service didn't initialize in 20 seconds this cancels location service use.
        if (maxWait < 1)
        {
            print("Timed out");
        }

        // If the connection failed this cancels location service use.
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            print("Unable to determine device location");
        }
        else
        {
            // If the connection succeeded, this retrieves the device's current location and displays it in the Console window.
            print("Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp);


            if (StateNameController.spawn_anything)
            {
                print("DOO WE GET HEEREE");
                interactiveTree = Instantiate(StateNameController.what_to_spawn);
                print(StateNameController.what_to_spawn);
                currentLocation = new Vector3(cursor.transform.position.x, cursor.transform.position.y, cursor.transform.position.z);
                interactiveTree.transform.position = new Vector3(Input.location.lastData.latitude, Input.location.lastData.altitude, Input.location.lastData.longitude + 10.0f);
                interactiveTree.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
                interactiveTree.transform.rotation = new Quaternion(0.0f, 180.0f, 0.0f, 0.0f);
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (StateNameController.spawn_anything)
        {
            currentLocation = new Vector3(cursor.transform.position.x, cursor.transform.position.y, cursor.transform.position.z);
            interactiveTree.transform.position = new Vector3((float)currentLocation.x, (float)currentLocation.y, (float)currentLocation.z + 10.0f);
            interactiveTree.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            interactiveTree.transform.rotation = new Quaternion(0.0f, 180.0f, 0.0f, 0.0f);
        }
    }
}
