using System;
using UnityEngine;
using UnityEngine.UI;

public class FpsShooter1 : MonoBehaviour
{
    int sc1;
    public GameObject arrow1;
    Ray ray;
    RaycastHit hit;
    public AudioSource a;
    Text texta1;
    GameObject pause;
    int score1 = 0;
    float targettime = 10000000000000000f;



    void Start()
    {
        Time.timeScale = 1;
        texta1 = GameObject.Find("score1").GetComponent<Text>();
        a = GameObject.Find("woodhit1").GetComponent<AudioSource>();
        pause = GameObject.Find("Pausemenu");
        pause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Screen.lockCursor = false;
            Time.timeScale = 0;
            pause.SetActive(true);
        }
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if ((hit.collider.gameObject.name == "Archerytarget") && (pause.activeInHierarchy == false))
                {
                    score1 = score1 + 1;
                    texta1.text = score1 + "";
                    a.Play();
                    var cloneof = Instantiate(arrow1, hit.point, Quaternion.identity);
                }
            }
        }

        PlayerPrefs.SetInt("temp", score1);
        PlayerPrefs.SetInt("order", 1);
        if (score1 >= PlayerPrefs.GetInt("stage1", sc1))
        {
            PlayerPrefs.SetInt("stage1", score1);
        }
        PlayerPrefs.Save();

    }

    public void restart()
    {
        Screen.lockCursor = true;
    }

}
