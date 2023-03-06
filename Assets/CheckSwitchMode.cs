using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mapbox;
using Mapbox.Utils;
using Mapbox.Unity.Map;
using TMPro;
using UnityEngine.UI;

public class CheckSwitchMode : MonoBehaviour
{
    public AbstractMap map;

    public GameObject whats_inside_the_box;
    public GameObject Squirrel;
    GameObject character;

    Vector2d currentLocation;

    // Start is called before the first frame update
    void Start()
    {
        whats_inside_the_box = GameObject.FindWithTag("SwitchModeButton");
        print("TRYING anything at htis point");
        print(whats_inside_the_box.GetComponent<SwitchModeButton>().what_to_spawn);
        //if (whats_inside_the_box.GetComponent<SwitchModeButton>().what_to_spawn == "Squirrel")
        //{
            print("WE SHORUSLD ALSO BE SEEING THIS @!");
            character = GameObject.Find("PlayerTarget");
            map = GameObject.Find("Map").GetComponent<AbstractMap>();
            Vector2d tempLocation = map.WorldToGeoPosition(character.transform.position);
            currentLocation = new Vector2d(tempLocation.x, tempLocation.y);

            GameObject use = Instantiate(Squirrel);
            currentLocation = new Vector2d(tempLocation.x, tempLocation.y);
            //  GameObject newSquirrel = Instantiate(Squirrel);
            use.transform.position = new Vector3((float)currentLocation.x, (float)currentLocation.y, 0.0f);
            use.transform.localScale = new Vector3(10.0f, 10.0f, 10.0f);
            GameObject.Find("Audio").GetComponent<isSquirrel>().squirrel_on_screen = true;
        //}
    }

    // Update is called once per frame
    void Update()
    {



    }
}
