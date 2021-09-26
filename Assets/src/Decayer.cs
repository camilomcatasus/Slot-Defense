using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decayer : MonoBehaviour
{

    public float lifeTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }

        lifeTime -= Time.deltaTime;
    }
}
