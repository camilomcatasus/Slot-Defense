using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotSpin : MonoBehaviour
{
    private int randomValue;
    private float timeInterval;
    public bool slotSelected;
    public string slotValue;
    public float delayToSlowDown;
    public float maxTimeBWMovement;
    public float minTimeToSlowDown;
    public float maxTimeToSlowDown;
    public float timeToSlowDown;
    float timeBWMovement;
    float slotSpeed = 4;
    public string theSlot;

    // Start is called before the first frame update
    void Start()
    {
        //timeToSlowDown = Random.Range(minTimeToSlowDown, maxTimeToSlowDown);
        slotSelected = true;
        slotValue = "";
        // StartCoroutine("Rotate");
    }

    /*
    private IEnumerator Rotate()
    {
        slotSelected = false;
        timeInterval = 0.025f;

        for (int i = 0; i < 100; i++)
        {
            if (transform.position.y <= 0.5f)
                transform.position = new Vector2(transform.position.x, 6.4f);

            transform.position = new Vector2(transform.position.x, transform.position.y - 0.25f);

            yield return new WaitForSeconds(timeInterval);
        }

        randomValue = Random.Range(60, 100);

        switch (randomValue % 3)
        {
            case 1:
                randomValue += 2;
                break;
            case 2:
                randomValue += 1;
                break;
        }

        for (int i = 0; i < randomValue; i++)
        {
            if (transform.position.y <= 0.5f)
                transform.position = new Vector2(transform.position.x, 6.4f);

            transform.position = new Vector2(transform.position.x, transform.position.y - 0.25f);

            if (i > Mathf.RoundToInt(randomValue * 0.25f))
                timeInterval = 0.05f;
            if (i > Mathf.RoundToInt(randomValue * 0.50f))
                timeInterval = 0.1f;
            if (i > Mathf.RoundToInt(randomValue * 0.75f))
                timeInterval = 0.15f;
            if (i > Mathf.RoundToInt(randomValue * 0.95f))
                timeInterval = 0.20f;

            Debug.Log("I'm here");
            yield return new WaitForSeconds(timeInterval);
        }

    }
    */

    public void Spin(float delayToSlow)
    {
        delayToSlowDown = delayToSlow;
        slotSpeed = 4;
    }

    public void MoveDown()
    {
        if (slotSpeed == 4)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.75f);
        }
        else if (slotSpeed == 3)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.375f);
        }
        else if (slotSpeed == 2)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.1875f);
        }
        else if (slotSpeed == 1)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.09375f);
        }
        else if (slotSpeed == 0)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.09375f);
            LockOnSlot();
        }
        else
        {

        }
    }

    public void LockOnSlot()
    {
        if (transform.position.y >= 6.35f) // pumpkin
        {
            slotSpeed = -1;
            theSlot = "pumpkin";
        }
        else if (transform.position.y >= 4.85f && transform.position.y <= 4.95f) // mouth
        {
            slotSpeed = -1;
            theSlot = "mouth";
        }
        else if (transform.position.y >= 3.35f && transform.position.y <= 3.45f) // ghost
        {
            slotSpeed = -1;
            theSlot = "ghost";
        }
        else if (transform.position.y >= 1.85f && transform.position.y <= 1.95f) // cc
        {
            slotSpeed = -1;
            theSlot = "cc";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBWMovement <=0 )
        {
            MoveDown();
            timeBWMovement = maxTimeBWMovement;
        }

        if (transform.position.y >= 6.4f)
        {
            transform.position = new Vector2(transform.position.x, 0.5f);
        }

        if (timeToSlowDown <= 0)
        {
            timeToSlowDown = Random.Range(minTimeToSlowDown, maxTimeToSlowDown);
            if (slotSpeed >= 0)
            {
                slotSpeed--;
            }
        }

        timeBWMovement -= Time.deltaTime;
        timeToSlowDown -= Time.deltaTime;
    }
}
