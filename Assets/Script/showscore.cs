using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showscore : MonoBehaviour
{
    int score;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score =  PlayerPrefs.GetInt("Tempscore", 0);
        text.text = "Score: " + score.ToString();
    }
}
