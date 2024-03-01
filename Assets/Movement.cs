using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {        // Check for player input
        if (Input.GetKeyDown(KeyCode.UpArrow)) // Use KeyCode.UpArrow for the forward arrow key
        {
            // Player pressed forward arrow key, start moving
            animator.SetBool("IsRunning", true);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow)) // Use KeyCode.UpArrow for the forward arrow key
        {
            // Player released forward arrow key, stop moving
            animator.SetBool("IsRunning", false);
        }

        // Move the character
        if (animator.GetBool("IsRunning"))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}
