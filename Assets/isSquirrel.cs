using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isSquirrel : MonoBehaviour
{
    public bool squirrel_on_screen;
    private void OnCollisionEnter(Collision collision)
    {
        
        //Not launching anything else, don't need???
        if (collision.gameObject.tag != "acorn")
            return;
        else
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            squirrel_on_screen = false;
        }
    }
}
