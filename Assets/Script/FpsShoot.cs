using System;
using UnityEngine;
using UnityEngine.UI;

public class FpsShoot: MonoBehaviour
{
    int sc3;
    public GameObject arrow;
    Ray ray;
    RaycastHit hit;
    //public GameObject target;
    public AudioSource a;
    public AudioSource bgm;
    Text texta;
    GameObject pause;
    int score=0;
    float targettime = 10000000000000000f;
     public GameObject parent;
     MeshRenderer mr;
    void Start()
    {
        Time.timeScale = 1;
        Screen.lockCursor = true;
        texta = GameObject.Find("score").GetComponent<Text>();
        a = GameObject.Find("woodhit").GetComponent<AudioSource>();
        pause = GameObject.Find("Pausemenu");
        mr = GameObject.Find("Target").GetComponent<MeshRenderer>();
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
            bgm.enabled = false;
        }
       ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (Input.GetMouseButtonDown(0))
                {
                if ((hit.collider.gameObject.name == "Target") && (hit.transform.GetComponent<MeshRenderer>().enabled==true) && (pause.activeInHierarchy == false))
                {
                    score = score + 5;
                    texta.text = score + "";
                    a.Play();
                         var cloneof = Instantiate(arrow, hit.point, Quaternion.identity);
                       cloneof.transform.SetParent(parent.transform);
                        mr.enabled = false;
                          parent.SetActive(false);
                       System.Random rnd = new System.Random();
                      int month = rnd.Next(1, 3);
                        targettime = Time.time + 5f;
                     }
                }
            }
        if (Time.time.ToString("00") == targettime.ToString("00")) {
            mr.enabled = true;
            parent.SetActive(true);
        }
        PlayerPrefs.SetInt("temp", score);
        PlayerPrefs.SetInt("order", 3);
        if (score >= PlayerPrefs.GetInt("stage3", sc3))
        {
            PlayerPrefs.SetInt("stage3", score);
        }
        PlayerPrefs.Save();
    }

    public void restart()
    {
        Screen.lockCursor = true;
    }

}
