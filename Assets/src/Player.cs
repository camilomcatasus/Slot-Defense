using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame updat

    private Zombie zombie ;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);

            if (hit)
            {
                zombie = hit.collider.gameObject.GetComponent<Zombie>();

                zombie.death();
            }
        }


        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.touches[0].position).x, Camera.main.ScreenToWorldPoint(Input.touches[0].position).y);
            RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);

            if (hit)
            {
                zombie = hit.collider.gameObject.GetComponent<Zombie>();

                zombie.death();
            }

        }

    }
}
