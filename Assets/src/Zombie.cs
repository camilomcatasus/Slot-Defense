using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float speed;
    private Transform moneyPos;
    private Money money;
    public int enemyHealth;
    public string zombieAttackSound;
    public string zombieDeathSound;

    private Animator anim;

    private bool dead;

    public float deathTime;

    AudioManager sounds;




    void Start()
    {
        sounds = FindObjectOfType<AudioManager>();
        dead = false;
        money = GameObject.FindGameObjectWithTag("Money").GetComponent<Money>();
        moneyPos = GameObject.FindGameObjectWithTag("Money").GetComponent<Transform>();
        anim = GetComponent<Animator>();
        //shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }

    void Update()
    {
        if (dead)
        {
            if (deathTime <= 0)
            {
                Destroy(gameObject);
            }

            deathTime -= Time.deltaTime;
        }

        transform.position = Vector2.MoveTowards(transform.position, moneyPos.position, speed * Time.deltaTime);
    }


    public void death()
    {
        speed = 0;
        anim.SetTrigger("Death_Trigger");
        sounds.Play(zombieDeathSound);
        dead = true;

    }




    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Money"))
        {
            sounds.Play(zombieAttackSound);
            Destroy(gameObject);
            money.down(1);
        }
    }

}
