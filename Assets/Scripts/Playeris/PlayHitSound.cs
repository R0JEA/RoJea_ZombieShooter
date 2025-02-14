using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayHitSound : MonoBehaviour
{
    public static AudioClip playerHitSound;
    static AudioSource audioSrc;
    
    // Start is called before the first frame update
    void Start()
    {
      audioSrc = GetComponent<AudioSource>();
      playerHitSound = Resources.Load<AudioClip>("hitSound");
    }

    public static void PlayerSound() {
      audioSrc.Play();
    }
}
