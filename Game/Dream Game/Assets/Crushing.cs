using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crushing : MonoBehaviour
{
    public float upSpeed = 3f;
    public float downSpeed = 70f;

    public float distance = 2.15f;
    float up;
    float down;

    bool crush;

    // Start is called before the first frame update
    void Start()
    {
        up = transform.position.y;
        down = transform.position.y - distance;
        up = up + 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= up)
        {
            crush = true;
        }

        if (transform.position.y <= down)
        {
            crush = false;
        }

        if (crush)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - (downSpeed * Time.deltaTime));
        }

        if (!crush)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + (upSpeed * Time.deltaTime));
        }

    }

}
