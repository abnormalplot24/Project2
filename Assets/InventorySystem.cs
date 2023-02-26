using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Mapbox.Utils;


public class InventorySystem : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cursor;
    public AudioClip spawn_sound_effect;
    void Start()
    {
        Button inventoryButton = transform.Find("Viewport").Find("Content").Find("StreetTreeButton").GetComponent<Button>();
        TextMeshProUGUI quantity_text = inventoryButton.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
        quantity_text.text = UnityEngine.Random.Range(1, 9).ToString();
        inventoryButton.onClick.AddListener(OnPressTree0);

        inventoryButton = transform.Find("Viewport").Find("Content").Find("PalmButton").GetComponent<Button>();
        quantity_text = inventoryButton.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
        quantity_text.text = UnityEngine.Random.Range(1, 9).ToString();
        inventoryButton.onClick.AddListener(OnPressTree1);

        inventoryButton = transform.Find("Viewport").Find("Content").Find("PineButton").GetComponent<Button>();
        quantity_text = inventoryButton.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
        quantity_text.text = UnityEngine.Random.Range(1, 9).ToString();
        inventoryButton.onClick.AddListener(OnPressTree2);

        inventoryButton = transform.Find("Viewport").Find("Content").Find("FirButton").GetComponent<Button>();
        quantity_text = inventoryButton.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
        quantity_text.text = UnityEngine.Random.Range(1, 9).ToString();
        inventoryButton.onClick.AddListener(OnPressTree3);

        inventoryButton = transform.Find("Viewport").Find("Content").Find("OakButton").GetComponent<Button>();
        quantity_text = inventoryButton.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
        quantity_text.text = UnityEngine.Random.Range(1, 9).ToString();
        inventoryButton.onClick.AddListener(OnPressTree4);

        inventoryButton = transform.Find("Viewport").Find("Content").Find("PoplarButton").GetComponent<Button>();
        quantity_text = inventoryButton.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
        quantity_text.text = UnityEngine.Random.Range(1, 9).ToString();
        inventoryButton.onClick.AddListener(OnPressTree5);

        inventoryButton = transform.Find("Viewport").Find("Content").Find("AcornButton").GetComponent<Button>();
        quantity_text = inventoryButton.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
        quantity_text.text = UnityEngine.Random.Range(1, 9).ToString();
        inventoryButton.onClick.AddListener(OnPressAcorn);
    }

    void OnPressAcorn()
    {
        if (SceneManager.GetActiveScene().name == "interaction_scene")
        {
            Button inventoryButton = transform.Find("Viewport").Find("Content").Find("AcornButton").GetComponent<Button>();
            TextMeshProUGUI quantity_text = inventoryButton.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
            if (float.Parse(quantity_text.text) > 0)
            {
                quantity_text.text = (float.Parse(quantity_text.text) - 1).ToString();
                GameObject acornSpawner = GameObject.Find("AcornSpawner");
                acornSpawner.GetComponent<AcornSpawner>().LaunchAcorn();
                AudioSource.PlayClipAtPoint(spawn_sound_effect, Camera.main.transform.position);
            }
        }
    }
    void OnPressTree0()
    {
        if (SceneManager.GetActiveScene().name == "interaction_scene")
        {
            Button inventoryButton = transform.Find("Viewport").Find("Content").Find("StreetTreeButton").GetComponent<Button>();
            TextMeshProUGUI quantity_text = inventoryButton.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
            if (float.Parse(quantity_text.text) > 0)
            {
                cursor = GameObject.FindGameObjectWithTag("Cursor").transform;
                SpawnTree("street", cursor.position, true);
                quantity_text.text = (float.Parse(quantity_text.text) - 1).ToString();
                AudioSource.PlayClipAtPoint(spawn_sound_effect, Camera.main.transform.position);
            }
        }
    }
    void OnPressTree1()
    {
        if (SceneManager.GetActiveScene().name == "interaction_scene")
        {
            Button inventoryButton = transform.Find("Viewport").Find("Content").Find("PalmButton").GetComponent<Button>();
            TextMeshProUGUI quantity_text = inventoryButton.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
            if (float.Parse(quantity_text.text) > 0)
            {
                cursor = GameObject.FindGameObjectWithTag("Cursor").transform;
                SpawnTree("palm", cursor.position, true);
                quantity_text.text = (float.Parse(quantity_text.text) - 1).ToString();
                AudioSource.PlayClipAtPoint(spawn_sound_effect, Camera.main.transform.position);
            }
        }
    }
    void OnPressTree2()
    {
        if (SceneManager.GetActiveScene().name == "interaction_scene")
        {
            Button inventoryButton = transform.Find("Viewport").Find("Content").Find("PineButton").GetComponent<Button>();
            TextMeshProUGUI quantity_text = inventoryButton.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
            if (float.Parse(quantity_text.text) > 0)
            {
                cursor = GameObject.FindGameObjectWithTag("Cursor").transform;
                SpawnTree("pine", cursor.position, true);
                quantity_text.text = (float.Parse(quantity_text.text) - 1).ToString();
                AudioSource.PlayClipAtPoint(spawn_sound_effect, Camera.main.transform.position);
            }
        }
    }

    void OnPressTree3()
    {
        if (SceneManager.GetActiveScene().name == "interaction_scene")
        {
            Button inventoryButton = transform.Find("Viewport").Find("Content").Find("FirButton").GetComponent<Button>();
            TextMeshProUGUI quantity_text = inventoryButton.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
            if (float.Parse(quantity_text.text) > 0)
            {
                cursor = GameObject.FindGameObjectWithTag("Cursor").transform;
                SpawnTree("fir", cursor.position, true);
                quantity_text.text = (float.Parse(quantity_text.text) - 1).ToString();
                AudioSource.PlayClipAtPoint(spawn_sound_effect, Camera.main.transform.position);
            }
        }
    }

    void OnPressTree4()
    {
        if (SceneManager.GetActiveScene().name == "interaction_scene")
        {
            Button inventoryButton = transform.Find("Viewport").Find("Content").Find("OakButton").GetComponent<Button>();
            TextMeshProUGUI quantity_text = inventoryButton.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
            if (float.Parse(quantity_text.text) > 0)
            {
                cursor = GameObject.FindGameObjectWithTag("Cursor").transform;
                SpawnTree("oak", cursor.position, true);
                quantity_text.text = (float.Parse(quantity_text.text) - 1).ToString();
                AudioSource.PlayClipAtPoint(spawn_sound_effect, Camera.main.transform.position);
            }
        }
    }

    void OnPressTree5()
    {
        if (SceneManager.GetActiveScene().name == "interaction_scene")
        {
            Button inventoryButton = transform.Find("Viewport").Find("Content").Find("PoplarButton").GetComponent<Button>();
            TextMeshProUGUI quantity_text = inventoryButton.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
            if (float.Parse(quantity_text.text) > 0)
            {
                cursor = GameObject.FindGameObjectWithTag("Cursor").transform;
                SpawnTree("poplar", cursor.position, true);
                quantity_text.text = (float.Parse(quantity_text.text) - 1).ToString();
                AudioSource.PlayClipAtPoint(spawn_sound_effect, Camera.main.transform.position);
            }
        }
    }

    public GameObject palm_tree_prefab;
    public GameObject pine_tree_prefab;
    public GameObject fir_tree_prefab;
    public GameObject street_tree_prefab;
    public GameObject oak_tree_prefab;
    public GameObject poplar_tree_prefab;

    //public Mapbox.Unity.Location.EditorLocationProviderLocationLog script;
    //public TreeDataManager script;

    public GameObject SpawnTree(string tree_type, Vector3 location, bool fromSeed)
    {
        //print("spawnTree: " + tree_type + " " + location + " " + fromSeed);
        //Vector2d current_player_latlong = new Vector2d(LocationProvider.GetComponent<LocationInfo>().latitude, LocationProvider.GetComponent<LocationInfo>().longitude);//Mapbox.Unity.Location.AbstractLocationProvider._currentLocation;// EditorLocationProviderLocationLog.current_player_latlong;
        float varianceAmount = 0.0003f;
        Vector2d variance = new Vector2d(Random.Range(-varianceAmount, varianceAmount), Random.Range(-varianceAmount, varianceAmount));
        Vector2d latlong = SwitchModeButton.currentLocation + variance;

        GameObject new_tree;
        if (tree_type == "palm")
        {   
            new_tree = GameObject.Instantiate(palm_tree_prefab);
        }
        else if (tree_type == "pine")
        {
            new_tree = GameObject.Instantiate(pine_tree_prefab);
        }
        else if (tree_type == "street")
        {
            new_tree = GameObject.Instantiate(street_tree_prefab);
        }
        else if (tree_type == "poplar")
        {
            new_tree = GameObject.Instantiate(poplar_tree_prefab);
        }
        else if (tree_type == "oak")
        {
            new_tree = GameObject.Instantiate(oak_tree_prefab);
        }
        else if (tree_type == "fir")
        {
            new_tree = GameObject.Instantiate(fir_tree_prefab);
        }
        else
        {
            new_tree = GameObject.Instantiate(street_tree_prefab);
        }
        new_tree.transform.SetPositionAndRotation(location, cursor.rotation * Quaternion.Euler(0, 0, 0));
        new_tree.transform.localScale -= new Vector3(0.9f, 0.9f, 0.9f);

        if (fromSeed == true)
        {
            TreeDataManager.all_trees.Add(new TreeDatum(tree_type, latlong, 0.0f, 1.0f));
        }
        //print(latlong);
        print(TreeDataManager.all_trees.Count);
        return new_tree;
    }
    // Update is called once per frame
    void Update()
    {

    }
}