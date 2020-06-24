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

    private void Start()
    {
        GameplayController.instance.DisplayHealth(health);
    }

    public void ApplyDamage(int damageAmout)
    {
        health -= damageAmout;

        if(health < 0)
        {
            health = 0;
        }

        GameplayController.instance.DisplayHealth(health);

        if (health == 0)
        {
            playerScript.enabled = false;
            anim.Play(MyTags.DEAD_ANIMATION);

            // SHow GAme over 
            GameplayController.instance.isPlayerAlive = false;
            //Gameover pane;
            GameplayController.instance.GameOver();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == MyTags.COIN_TAG)
        {
            other.gameObject.SetActive(false);
            GameplayController.instance.CoinCollected();
            SoundManager.instance.PlayCoinSound();
        }
    }
} // class
