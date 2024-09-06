using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float max_health;
    public float health;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        health = max_health;
        TakeDamage(1);
        
    }
    public void TakeDamage(float dmg)
    {
        health -= dmg;
        Debug.Log($"Player health {health}");
        animator.SetBool("Hurt",true);
        if(health <= 0)
        {
            Debug.Log("You are dead!"); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
