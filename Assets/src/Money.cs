using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public float amount;
    public Text bet;
    public SlotMachine slotMachine;
    private float betAmount;
    void Start()
    {
        betAmount = amount;

    }

    // Update is called once per frame
    void Update()
    {
        

    }


    public void down(float reduce)
    {
        slotMachine.value -= reduce;
        slotMachine.UpdateWallet();
    }
}
