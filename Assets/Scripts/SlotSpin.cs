using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotSpin : MonoBehaviour
{
    private int randomValue;
    private float timeInterval;
    public bool slotSelected;
    public string slotValue;

    // Start is called before the first frame update
    void Start()
    {
        slotSelected = true;
        slotValue = "";
        StartCoroutine("Rotate");
    }

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

            yield return new WaitForSeconds(timeInterval);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
