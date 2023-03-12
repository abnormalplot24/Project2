using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornSpawner : MonoBehaviour
{
    public GameObject acorn_prefab;
    public Transform arCamera;
    public AudioClip PewPewPew;
    // Start is called before the first frame update
    void Start()
    {
        arCamera = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        //LaunchAcorn();
    }

    public float acorn_launch_velocity = 100.00f;
    public Vector3 offset;
    public void LaunchAcorn()
    {
        print("ACorn launched");
        GetComponent<AudioSource>().PlayOneShot(PewPewPew);

        arCamera = GameObject.FindGameObjectWithTag("MainCamera").transform;
        //Vector3 spawn_position = Camera.main.gameObject.transform.position;
        GameObject new_acorn = GameObject.Instantiate(acorn_prefab, arCamera.position + 0 * arCamera.right, arCamera.rotation);
        new_acorn.transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
        new_acorn.GetComponent<Rigidbody>().AddForce(arCamera.forward * acorn_launch_velocity);

    }
}
