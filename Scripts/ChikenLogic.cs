using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChikenLogic : MonoBehaviour
{
    public Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();

    }
    private void Update()
    {
        animator.SetBool("Move", true);   
    }
}
