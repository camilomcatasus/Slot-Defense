using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public float amount;
    public Text bet;

    private float betAmount;
    void Start()
    {
        betAmount = amount;

    }

    // Update is called once per frame
    void Update()
    {
        bet.text = "Amount " + (float)betAmount;

    }


    public void down(float reduce)
    {
        betAmount = betAmount - reduce;
    }
}
