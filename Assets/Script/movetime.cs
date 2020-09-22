using UnityEngine;
using System.Collections;

public class movetime : MonoBehaviour
{
    void Update()
    {
       
        transform.Translate(Vector3.right * Time.deltaTime * 60);

        
        transform.Translate(Vector3.up * Time.deltaTime, Space.World);
    }
}