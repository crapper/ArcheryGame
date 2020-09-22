using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    int score;
    int highest;
    int order;
    Text sco;
    Text hsco;
    // Start is called before the first frame update
    void Start()
    {
        Screen.lockCursor = false;
        sco = GameObject.Find("Tempscore").GetComponent<Text>();
        hsco = GameObject.Find("Highestscore").GetComponent<Text>();
        order = PlayerPrefs.GetInt("order", 0);
        score = PlayerPrefs.GetInt("temp", 0);
        if (order == 3)
        {
            highest = PlayerPrefs.GetInt("stage3", 0);
        }
        else
            if (order == 1)
             {
                highest = PlayerPrefs.GetInt("stage1", 0);
            }
            else
                if (order == 2)
                 {
                     highest = PlayerPrefs.GetInt("stage2", 0);
                 }

        sco.text = score + "";
        hsco.text = highest + "";
    }
}
