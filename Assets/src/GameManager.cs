using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Spawner spawner;
    public string music;
   // public int index = 0;
    AudioManager sounds;

    public List<Sprite> backgrounds;
    public List<Sprite> slots;
    public List<GameObject> enemy;

    public GameObject background;

    // Start is called before the first frame update
    void Start()
    {
        sounds = FindObjectOfType<AudioManager>();
        sounds.Play(music);
    }
    public void SwitchSetting(int index)
    {
        //this.index = index;
        spawner.enemy[0] = enemy[index];
        background.GetComponent<SpriteRenderer>().sprite = backgrounds[index];
    }    

    // Update is called once per frame
    void Update()
    {
        
    }
}
