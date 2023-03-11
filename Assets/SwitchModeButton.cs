using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mapbox;
using Mapbox.Utils;
using Mapbox.Unity.Map;
using TMPro;
using UnityEngine.UI;

public class SwitchModeButton : MonoBehaviour
{
    public GameObject gameplay_canvas;

    public GameObject Squirrel__Object;

    static GameObject gameplay_canvas_instance;

    public GameObject switchModeButton;


    public List<GameObject> Squirrels;

    public List<GameObject> Trees;

    public GameObject interactionScene;

    GameObject character;
    public static Vector2d currentLocation;

    public AbstractMap map;
    public void Start()
    {
        if (gameplay_canvas_instance == null)
        {
            gameplay_canvas_instance = gameplay_canvas;
            DontDestroyOnLoad(gameplay_canvas);

        }
        else
        {
            Destroy(gameplay_canvas);
        }
        character = GameObject.Find("PlayerTarget");
    }


    public void OnSwitchButtonPressed()
    {
        bool check_trees = true;
        bool no_spawned_object = true;
                    character = GameObject.Find("PlayerTarget");

        //Debug.Log("BUTTON PRESSED");
        if (SceneManager.GetActiveScene().name == "interaction_scene")
        {   // interaction to exploration
            SceneManager.LoadScene("exploration_scene");
            TextMeshProUGUI text = switchModeButton.transform.Find("Text").GetComponent<TextMeshProUGUI>();
            text.SetText("Interact");
        }
        else if (SceneManager.GetActiveScene().name == "exploration_scene")
        { // exploration to interaction
            TextMeshProUGUI text = switchModeButton.transform.Find("Text").GetComponent<TextMeshProUGUI>();
            text.SetText("Explore");
            character = GameObject.Find("PlayerTarget");
            map = GameObject.Find("Map").GetComponent<AbstractMap>();
            Vector2d tempLocation = map.WorldToGeoPosition(character.transform.position);
            currentLocation = new Vector2d(tempLocation.x, tempLocation.y);
            //SceneManager.LoadScene("interaction_scene");


            foreach (GameObject Squirrel in GameObject.FindGameObjectsWithTag("Squirrel"))
            {
                Vector3 diff = Squirrel.transform.position - character.transform.position;
                print(diff);
                print("WE GET HERE???22");

                if (diff.sqrMagnitude < 200.0f)
                {
                    SpawnSquirrelScene();
                    check_trees = false;
                    no_spawned_object = false;
                    StateNameController.spawn_anything = true;
                    StateNameController.what_to_spawn_string = "Squirrel";

                }

            }
            if (check_trees)
            {
                print("WE GET HERE???23");
                foreach (GameObject Tree in GameObject.FindGameObjectsWithTag("Tree"))
                {
                    Vector3 diff = Tree.transform.position - character.transform.position;
                    print(diff);
                    if (diff.sqrMagnitude < 200.0f)
                    {
                        print(Tree);
                        SpawnTreeScene(Tree);
                        no_spawned_object = false;
                        StateNameController.spawn_anything = true;
                        StateNameController.what_to_spawn_string = "Tree";

                    }

                }
            }
            if (no_spawned_object)
            {
                SceneManager.LoadScene("interaction_scene");
                StateNameController.what_to_spawn_string = "Nothing";
                StateNameController.spawn_anything = false;


            }
        }
    }

    void SpawnSquirrelScene()
    {
        SceneManager.LoadScene("interaction_scene");
        StateNameController.what_to_spawn = Squirrel__Object;


    }

    void SpawnTreeScene(GameObject Tree_Specific)
    {
        SceneManager.LoadScene("interaction_scene");
        StateNameController.what_to_spawn = Tree_Specific;

    }
}

