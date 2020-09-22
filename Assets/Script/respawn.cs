using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    double Timer;
    // Start is called before the first frame update
    void Start()
    {
        //self = GameObject.GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<MeshRenderer>().enabled == false && Timer <=0 )
        {
            Timer = 1.5;
        }
        Timer = Timer - Time.deltaTime;
        if (Timer < 0)
        {
            GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
