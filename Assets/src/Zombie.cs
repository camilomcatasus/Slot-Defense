using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float speed;
    private Transform moneyPos;
    private Money money;
    public int enemyHealth;

    public Animator animator;




    void Start()
    {
        money = GameObject.FindGameObjectWithTag("Money").GetComponent<Money>();
        moneyPos = GameObject.FindGameObjectWithTag("Money").GetComponent<Transform>();
        //shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moneyPos.position, speed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);

            if (hit)
            {
                animator.SetTrigger("Death_Trigger");
                speed = 0;
            }
        }
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Money"))
        {
            Destroy(gameObject);
            money.down(1);
        }
    }

}
