using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endscore : MonoBehaviour
{
    int score, Highest;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score = PlayerPrefs.GetInt("Tempscore", 0);
        Highest = PlayerPrefs.GetInt("level2", 0);
        text.text = "Score: " + score.ToString() + "\nHighest Score: " + Highest.ToString();
    }
}
