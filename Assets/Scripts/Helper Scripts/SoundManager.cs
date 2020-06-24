using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField]
    private  AudioSource coinSoundSource;

    private void Awake()
    {
        MakeInstence();
    }

    void MakeInstence()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }

    public void PlayCoinSound()
    {
        coinSoundSource.Play();
    }
}
