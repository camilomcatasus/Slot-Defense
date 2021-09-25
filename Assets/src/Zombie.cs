using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float speed;
    private Transform moneyPos;
    private Money money;
    public int enemyHealth;



    void Start()
    {
        money = GameObject.FindGameObjectWithTag("Money").GetComponent<Money>();
        moneyPos = GameObject.FindGameObjectWithTag("Money").GetComponent<Transform>();
        //shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moneyPos.position, speed * Time.deltaTime);
    }
}
