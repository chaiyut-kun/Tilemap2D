using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float max_health;
    public float health;
    void Start()
    {
        
        health = max_health;
        TakeDamage(1);
        
    }
    public void TakeDamage(float dmg)
    {
        health -= dmg;
        Debug.Log($"Player health {health}");
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
