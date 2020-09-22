using System;
using UnityEngine;
using UnityEngine.UI;

public class shoot : MonoBehaviour
{
    int sc2;
    Ray ray;
    RaycastHit hit;
    //public GameObject target;
    public AudioSource a;
    public AudioSource bgm;
    Text texta;
    GameObject pause2;
    int score = 0;
    float targettime = 10000000000000000f;
    void Start()
    {
        Time.timeScale = 1;
        Screen.lockCursor = true;
        texta = GameObject.Find("Counter").GetComponent<Text>();
        a = GameObject.Find("woodhit").GetComponent<AudioSource>();
        pause2 = GameObject.Find("menu");
        pause2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Screen.lockCursor = false;
            Time.timeScale = 0;
            pause2.SetActive(true);
            bgm.enabled = false;
        }
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (((hit.collider.gameObject.name == "target1")|| (hit.collider.gameObject.name == "target2")|| (hit.collider.gameObject.name == "target3")|| (hit.collider.gameObject.name == "target4"))&& (pause2.activeInHierarchy == false))
                {
                    score = score + 2;
                    texta.text = score + "";
                    a.Play();
                }
            }
        }
        PlayerPrefs.SetInt("temp", score);
        PlayerPrefs.SetInt("order", 2);
        if (score >= PlayerPrefs.GetInt("stage2", sc2))
        {
            PlayerPrefs.SetInt("stage2", score);
        }
        PlayerPrefs.Save();
    }

    public void restart()
    {
        Screen.lockCursor = true;
        bgm.enabled = true;
    }
}

