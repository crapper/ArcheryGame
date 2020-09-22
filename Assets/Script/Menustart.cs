using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menustart : MonoBehaviour
{
    GameObject submenu;
    // Start is called before the first frame update
    void Start()
    {
        Screen.lockCursor = false;
        submenu = GameObject.Find("Selection");
        submenu.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
