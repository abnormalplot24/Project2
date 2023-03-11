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
    public static Vector2d currentLocation;
    public GameObject cursor;

    // Start is called before the first frame update
    void Start()
    {

        if (StateNameController.spawn_anything)
        {
            GameObject interactiveTree = Instantiate(StateNameController.what_to_spawn);
            print(StateNameController.what_to_spawn);
            currentLocation = new Vector2d(cursor.transform.position.x, cursor.transform.position.y);
            interactiveTree.transform.position = new Vector3((float)currentLocation.x, (float)currentLocation.y, 0.0f);
            interactiveTree.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
