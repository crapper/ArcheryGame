using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Vector3 origin;
    bool direction = true;
    public float space;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        origin = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        if (direction)
        {
            if((GetComponent<Transform>().position.x - origin.x) > space)
            {
                direction = false;
            }
            else
            {
                transform.Translate( speed * Time.deltaTime, 0, 0);
            }
        }
        else
        {
            if( (origin.x - GetComponent<Transform>().position.x) > space)
            {
                direction = true;
            }
            else
            {
                transform.Translate( -speed * Time.deltaTime, 0, 0);
            }
        }
    }
}
