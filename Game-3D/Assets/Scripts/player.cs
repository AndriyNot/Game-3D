using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;


public class player : MonoBehaviour
{
    public Animator animator;
    public RigBuilder rigBuilder;
    public taskGeneration taskgeneration;
    public bool index = true;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

   
    void Update()
    {
       
        if (index == false)
        {
            animator.SetBool("movHand", true);
            index = true;
        }
        else
        {
            animator.SetBool("movHand", false);
            
        }
        if (taskgeneration.lossindex == false)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            animator.SetBool("los", true);
            rigBuilder.enabled = false;
        }
        if (taskgeneration.winindex == false)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            animator.SetBool("dance", true);
            rigBuilder.enabled = false;
        }
    }
     public void buttonPanel()
    {
        index = false;
    }
}
