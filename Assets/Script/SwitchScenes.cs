using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour {
	public AudioSource bgm;
	void Start()
	{
		bgm.Play();
	}
	public void NextScene (string sceneName) {
		SceneManager.LoadScene(sceneName);
	}
}


