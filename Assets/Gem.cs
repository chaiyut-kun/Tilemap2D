using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

<<<<<<< HEAD
    private void OnTriggerEnter(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            // GetComponent<AudioSource>.Player();
=======
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            GetComponent<AudioSource>().Play();
>>>>>>> main
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            // Destroy(col);
        }
    }    
}
