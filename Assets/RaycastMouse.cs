using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RaycastMouse : MonoBehaviour
{
    public GameObject[] landmarks;
    public GameObject[] panels;
    static GameObject currentActivePanel = null;
    static bool palmText = false;
    static bool pineText = false;
    static bool firText = false;
    static bool oakText = false;
    static bool poplarText = false;
    // Start is called before the first frame update
    void Start()
    {
        /*GameObject diagPanel = GameObject.Find("DiagPanel");
        panels[0] = (diagPanel);
        panels[1] = (diagPanel);
        panels[2] = (diagPanel);
        panels[3] = (diagPanel);
        panels[4] = (diagPanel);*/
    }
    
    // Update is called once per frame
    void Update()
    {   
        float distance = 100f;
        if (Input.GetMouseButtonDown(0) && SceneManager.GetActiveScene().name == "exploration_scene")
        {
            print("creatingRay");
            //create a ray cast and set it to the mouses cursor position in game
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit_result;
            if (Physics.Raycast(ray, out hit_result))
            {
                //draw invisible ray cast/vector
                Debug.DrawLine(ray.origin, hit_result.point);
                //log $$anonymous$$t area to the console
                Debug.Log(hit_result.point);
                Transform objectHit = hit_result.transform;
                //GameObject[] landmarks = GameObject.FindGameObjectsWithTag("Landmark");
                GameObject landmarkSelected;
                int count = 0;
                foreach(GameObject landmark in landmarks)
                {
                    if(Mathf.Abs(landmark.transform.position.x - objectHit.position.x) < 5.0f &&
                        Mathf.Abs(landmark.transform.position.y - objectHit.position.y) < 5.0f &&
                        Mathf.Abs(landmark.transform.position.z - objectHit.position.z) < 5.0f)
                    {
                        landmarkSelected = landmark;
                        currentActivePanel = panels[count];
                        currentActivePanel.SetActive(true);
                        currentActivePanel.transform.position = GameObject.Find("GameplayCanvas").transform.position;
                        TextMeshProUGUI infoText = currentActivePanel.transform.Find("InfoText").GetComponent<TextMeshProUGUI>();
                        print(count);
                        switch (count)
                        {
                            case 0:
                                if (!ShopManager.palmUnlocked)
                                {
                                    ShopManager.palmUnlocked = true;
                                    infoText.text = infoText.text + "\n\n\n PALM SEED UNLOCKED  ";
                                }
                                else if (!palmText)
                                {
                                    infoText.text = infoText.text.Substring(0, infoText.text.Length - 21);
                                    palmText = true;
                                }
                                break;
                            case 1:
                                if (!ShopManager.pineUnlocked)
                                {
                                    ShopManager.pineUnlocked = true;
                                    infoText.text = infoText.text + "\n\n\n PINE SEED UNLOCKED  ";
                                }
                                else if (!pineText)
                                {
                                    infoText.text = infoText.text.Substring(0, infoText.text.Length - 21);
                                    pineText = true;
                                }
                                break;
                            case 2:
                                if (!ShopManager.firUnlocked)
                                {
                                    ShopManager.firUnlocked = true;
                                    infoText.text = infoText.text + "\n\n\n FIR SEED UNLOCKED   ";
                                }
                                else if (!firText)
                                {
                                    infoText.text = infoText.text.Substring(0, infoText.text.Length - 21);
                                    firText = true;
                                }
                                break;
                            case 3:
                                if (!ShopManager.oakUnlocked)
                                {
                                    ShopManager.oakUnlocked = true;
                                    infoText.text = infoText.text + "\n\n\n OAK SEED UNLOCKED   ";
                                }
                                else if (!oakText)
                                {
                                    infoText.text = infoText.text.Substring(0, infoText.text.Length - 21);
                                    oakText = true;
                                }
                                break;
                            case 4:
                                if (!ShopManager.poplarUnlocked)
                                {
                                    ShopManager.poplarUnlocked = true;
                                    infoText.text = infoText.text + "\n\n\n POPLAR SEED UNLOCKED";
                                }
                                else if (!poplarText)
                                {
                                    infoText.text = infoText.text.Substring(0, infoText.text.Length - 21);
                                    poplarText = true;
                                }
                                break;
                        }
                        break;
                    }
                    ++count;
                }

            }
            else
            {
                if (currentActivePanel != null)
                {
                    currentActivePanel.SetActive(false);
                    currentActivePanel = null;
                }
            }
        }
    }
}
