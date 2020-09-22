using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
    public float max_time;
    float timer;
    public Slider slider;
    public GameObject end_menu, pause;
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = max_time;
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        slider.value = timer;
        if (slider.value == slider.maxValue)
        {
            end_menu.SetActive(true);
            Time.timeScale = 0;
            pause.SetActive(false);
        }
    }
}
