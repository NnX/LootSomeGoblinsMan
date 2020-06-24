using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvents : MonoBehaviour
{
    public GameObject player, playButton;

    void DeactivateGameObjects ()
    {
        playButton.SetActive(false);
        player.SetActive(false);
    }

    void ActivateGameObjects ()
    {
        playButton.SetActive(true);
        player.SetActive(true);
    }
}
