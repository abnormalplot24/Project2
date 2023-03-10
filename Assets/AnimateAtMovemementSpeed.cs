using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateAtMovemementSpeed : MonoBehaviour
{
    Vector3 previous_position;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        previous_position = transform.position;
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 current_position = transform.position;
        Vector3 delta = current_position - previous_position;
        float movement_speed = delta.magnitude;

        float movement_ratio = movement_speed / 0.0728f;
        animator.speed = movement_ratio;

        previous_position = current_position;

            
    }
}
