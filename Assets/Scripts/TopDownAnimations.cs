using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAnimations : MonoBehaviour
{
    // Start is called before the first frame update
    protected Animator animator;
    protected TopDownCharacterController controller;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<TopDownCharacterController>();
    }

    //check github

}
