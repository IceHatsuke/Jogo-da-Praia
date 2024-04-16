using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AspiradorAnimation : MonoBehaviour
{

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.enabled = !animator.enabled;
        }
    }
}
