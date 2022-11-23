using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambience : MonoBehaviour
{
    public int activeTerrain = 0;

    [SerializeField]
    List<AudioClip> terrainSound, floorSound, caveSound;
    void Awake()
    {
        activeTerrain = 0;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AmbiantSound();
    }

    public void AmbiantSound()
    {
        if (Character.activeTerrain == 0)
        {
            GetComponent<AudioSource>().clip = terrainSound[Random.Range(0, terrainSound.Count)];
            GetComponent<AudioSource>().Play();
        }
        if (Character.activeTerrain == 1)
        {
            GetComponent<AudioSource>().clip = (floorSound[Random.Range(0, floorSound.Count)]);
            GetComponent<AudioSource>().Play();
        }
        if (Character.activeTerrain == 2)
        {
            GetComponent<AudioSource>().clip = (caveSound[Random.Range(0, caveSound.Count)]);
            GetComponent<AudioSource>().Play();
        }

    }

}
