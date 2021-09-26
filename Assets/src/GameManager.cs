using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public string music;

    AudioManager sounds;

    // Start is called before the first frame update
    void Start()
    {
        sounds = FindObjectOfType<AudioManager>();
        sounds.Play(music);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
