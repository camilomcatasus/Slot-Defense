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


    // Start is called before the first frame update
    void Start()
    {
        s1.timeToSlowDown = slot1Delay;
        s2.timeToSlowDown = slot2Delay;
        s3.timeToSlowDown = slot3Delay;
    }

    void CheckSlots()
    {
        if (s1.theSlot.Equals(s2.theSlot) || s2.theSlot.Equals(s3.theSlot) || s3.theSlot.Equals(s1.theSlot))
        {
            Debug.Log("You should have earned some money.");
            if (s1.theSlot.Equals(s2.theSlot) && s2.theSlot.Equals(s3.theSlot))
            {
                Debug.Log("You hit the jackpot!!!");
            }
        }
    }

    public void SpinSlots()
    {
        if(s1.slotSpeed < 0 && s2.slotSpeed < 0 && s3.slotSpeed < 0)
        {
            s1.Spin(2);
            s2.Spin(4);
            s3.Spin(6);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (s1.theSlot != "" && s2.theSlot != "" && s3.theSlot != "" )
        {
            CheckSlots();
        }
    }
}
