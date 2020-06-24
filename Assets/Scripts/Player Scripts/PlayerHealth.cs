using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    private PlayerScript playerScript;
    private Animator anim;

    private void Awake()
    {
        playerScript = GetComponent<PlayerScript>();
        anim = GetComponent<Animator>();
    }
    
    public void ApplyDamage(int damageAmout)
    {
        health -= damageAmout;
        if(health < 0)
        {
            health = 0;
        }
        // Display the health vallue

        if(health == 0)
        {
            playerScript.enabled = false;
            anim.Play(MyTags.DEAD_ANIMATION);

            // SHow GAme over 
        }
    }
}
