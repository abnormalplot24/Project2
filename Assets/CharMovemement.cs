using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovemement : MonoBehaviour
{
    private Animator animator;
    private Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        moveDirection = new Vector3(horizontal, 0, vertical);
        if (moveDirection == Vector3.zero)
        {
            animator.SetFloat("Speed", 0);
        }

        else
        {
            animator.SetFloat("Speed", 0.5f);
        }
    }
}
