using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFinalBoss : MonoBehaviour
{
    public GameObject finalBoss;
    private GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        StateNameController.final_boss_present = false;
    }

    // Update is called once per frame
    void Update()
    {
        character = GameObject.Find("mickey-mouse@Walking 1");
        if (MoneyManager.currentBalance > 1000 & !StateNameController.final_boss_present)
        {
            print("WE MUST BE GETTING HERE");
            Vector3 startPosition = new Vector3(character.transform.position.x, character.transform.position.y, character.transform.position.z);
            GameObject FinalBoss = GameObject.Instantiate(finalBoss);
            FinalBoss.transform.position = startPosition;
            StateNameController.final_boss_present = true;
            print(StateNameController.final_boss_present);
        }
    }
}
