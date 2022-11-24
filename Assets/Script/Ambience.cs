using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambience : MonoBehaviour
{
    public int activeTerrain = 0;
    private AudioSource thisAudioSource;

    [SerializeField]
    AudioClip terrainSound, floorSound, caveSound;

    void Awake()
    {
        activeTerrain = 0;
    }
    void Start()
    {
        thisAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        AmbiantSound();
    }

    public void AmbiantSound()
    {
        if (Character.activeTerrain == 0 && thisAudioSource.clip != terrainSound)
        {
            thisAudioSource.clip = terrainSound;
            thisAudioSource.Play();
        }
        if (Character.activeTerrain == 1 && thisAudioSource.clip != floorSound)
        {
            thisAudioSource.clip = floorSound;
            thisAudioSource.Play();
        }
        if (Character.activeTerrain == 2 && thisAudioSource.clip != caveSound)
        {
            thisAudioSource.clip = caveSound;
            thisAudioSource.Play();
        }

    }

}
