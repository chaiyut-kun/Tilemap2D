using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float max_health;
    public float health;
    private Animator animator;
    private bool can_take_dmg = true;
    void Start()
    {
        animator = GetComponentInParent<Animator>();
        health = max_health;
        TakeDamage(1);
        
    }
    public void TakeDamage(float dmg)
    {
        if (!can_take_dmg) 
        {
            return;
        }

        health -= dmg;
        Debug.Log($"Player health {health}");
        animator.SetBool("Hurt",true);

        if(health <= 0)
        {
            animator.SetBool("Dead",true);   
            GetComponent<PolygonCollider2D>().enabled = false;
            GetComponentInParent<GatherInput>().DisableControl();
            Debug.Log("You are dead!"); 
            
        }

        animator.SetBool("Hurt",false);
        StartCoroutine(DamagePrevention());
    }
    public IEnumerator DamagePrevention()
    {
        can_take_dmg = false;
        yield return new WaitForSeconds(0.15f);

        if (health > 0 )
        {
            can_take_dmg = true;
            animator.SetBool("Hurt",false);
            // -> idle animation 
        }
        else {
            animator.SetBool("Dead",true);
            // -> dead animation
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
