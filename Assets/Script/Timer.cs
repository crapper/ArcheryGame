using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	public float myTimer=10;
	public Slider slider;
	Text text;
	Text score;

	void Start () {
		text = GetComponent<Text>();
		slider.maxValue = myTimer;
		slider.minValue = 0;
	}

	void Update () {
		if (myTimer > 0)
			myTimer -= Time.deltaTime;
		else {
			myTimer = 0;
			Time.timeScale = 0;
			SceneManager.LoadScene("Gameover");
		}
		slider.value = myTimer;
		text.text = (myTimer).ToString("00");
	}
}


