using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachine : MonoBehaviour
{
    // has three slots
    public SlotSpin s1;
    public SlotSpin s2;
    public SlotSpin s3;

    public float slot1Delay;
    public float slot2Delay;
    public float slot3Delay;

    public string slotSpinSound;
    public string slotPlaySound;

    public GameObject spawner;
    bool checkedSlots = true;

    AudioManager sounds;
    // Start is called before the first frame update
    void Start()
    {
        sounds = FindObjectOfType<AudioManager>();
        s1.timeToSlowDown = slot1Delay;
        s2.timeToSlowDown = slot2Delay;
        s3.timeToSlowDown = slot3Delay;
        spawner.SetActive(false);
    }

    void CheckSlots()
    {
        checkedSlots = true;
        if (s1.theSlot.Equals(s2.theSlot) || s2.theSlot.Equals(s3.theSlot) || s3.theSlot.Equals(s1.theSlot))
        {
            Debug.Log("You should have earned some money.");
            if (s1.theSlot.Equals(s2.theSlot) && s2.theSlot.Equals(s3.theSlot))
            {
                Debug.Log("You hit the jackpot!!!");
            }
        }

        spawner.SetActive(false);
    }

    public void SpinSlots()
    {
        spawner.SetActive(true);
        checkedSlots = false;
        Debug.Log(s1.slotSpeed);
        Debug.Log(s2.slotSpeed);
        Debug.Log(s3.slotSpeed);
        if (s1.slotSpeed < 0 && s2.slotSpeed < 0 && s3.slotSpeed < 0)
        {
            sounds.Play(slotSpinSound);
            sounds.Play(slotPlaySound);
            s1.Spin(2);
            s2.Spin(4);
            s3.Spin(6);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!checkedSlots && s1.slotSpeed < 0 && s2.slotSpeed < 0 && s3.slotSpeed < 0)
        {
            sounds.Stop(slotPlaySound);
            CheckSlots();
        }
    }
}
