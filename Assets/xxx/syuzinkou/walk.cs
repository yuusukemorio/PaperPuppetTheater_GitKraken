using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localScale = new Vector3(0.50785f, 0.50785f, 0.50785f);
            animator.SetInteger("syuzinkou_anima", 1);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localScale = new Vector3(0.50785f, 0.50785f, -0.50785f);
            animator.SetInteger("syuzinkou_anima", 1);
        }
        else
        {
            animator.SetInteger("syuzinkou_anima", 0);
        }
    }
}
