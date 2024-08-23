using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioSource music;

    public AudioClip upSound;


    private void Start()
    {
     //   music.clip = upSound;
     //   music.Play();
    }

    public void PlaySound()
    {
        music.clip = upSound;
        music.Play();
    }
}
