using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Pause : MonoBehaviour
{
    public bool IsPaused;
    
    public GameObject PauseText;
    
    public GameObject RestartText;

    
    void Start()
    {
    }
   
    void Update()
    {
        if (IsPaused)
        {
            
            PauseText.SetActive(true);
            
            RestartText.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
           
            PauseText.SetActive(false);
            
            RestartText.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            IsPaused = !IsPaused;
        }
    }
    public void continueButton()
    {
        IsPaused = !IsPaused;
    }
}

