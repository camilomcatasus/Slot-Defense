using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Button spinButton;
    public Button settingsButton;
    
    public Spawner spawner;
    public string music;
    public List<GameObject> cols;
   // public int index = 0;
    AudioManager sounds;

    public List<Sprite> backgrounds;
    public List<Sprite> slots;
    public List<GameObject> enemy;
    public List<Color> uiColors;

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
        spinButton.GetComponent<Image>().color = uiColors[index];
        settingsButton.GetComponent<Image>().color = uiColors[index];
        foreach (GameObject gameObject in cols)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = slots[index];
        }
        spawner.enemy[0] = enemy[index];
        background.GetComponent<SpriteRenderer>().sprite = backgrounds[index];
    }

    // Update is called once per frame
    void Update()
    {

    }
}
