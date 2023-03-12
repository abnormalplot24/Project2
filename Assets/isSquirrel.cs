using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isSquirrel : MonoBehaviour
{
    private int hit_count;

    private void Start()
    {
        if (StateNameController.final_boss_present)
        {
            hit_count = 4;
        }
        else
        {
            hit_count = 0;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {

        //Not launching anything else, don't need???
        if (collision.gameObject.tag != "acorn")
        {
            print("DO WE END UP HERE ON ACCIDENT");
            return;
        }
        else
        {
            print("ACORN HIT!!");
            if (hit_count > 0)
            {
                hit_count --;
            }
            else
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
                print("KILL KILL KILL");
                StateNameController.final_boss_present = false;
                StateNameController.squirrel_killed = true;
            }
        }
    }
}
