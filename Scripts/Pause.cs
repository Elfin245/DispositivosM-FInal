using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject Pauser;
    //bool isPaused;

    void Start()
    {
        Pauser.SetActive(false);
    }
    //void Awake()
    //{
    //    Time.timeScale = 1;
    //    Pauser.SetActive(false);
    //    isPaused = false;
    //}
    public void Paused()
    {
        //if (Input.GetButtonDown()&&!isPaused)
        //{
        //    Time.timeScale = 0;
        //    Pauser.SetActive(true);
        //    isPaused= true;
        //}
        //else if (Input.GetButtonDown() && !isPaused)
        //{
        //    Time.timeScale = 1;
        //    Pauser.SetActive(false);
        //    isPaused=false;
        //}
        if (Time.timeScale==1f)
        {
            Time.timeScale = 0f;
        }
        Pauser.SetActive(true);
    }
    public void Resume()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
        }
        Pauser.SetActive(false);
    }
}
