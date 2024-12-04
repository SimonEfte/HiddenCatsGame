using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class MenuManager : MonoBehaviour
{
    [Header("Main")]
    public GameObject screen1;
    [Header("Shop")]
    public GameObject screen2;
    [Header("Character")]
    public GameObject screen3;
    [Header("LeaderBoard")]
    public GameObject screen4;
    [Header("Level")]
    public GameObject screen5;
    [Header("winner")]
    public GameObject screen6;
    [Header("Level Clear Dialog")]
    public GameObject screen7;
    [Header("Acheivements Dialog")]
    public GameObject screen8;
    [Header("message Dialog")]
    public GameObject screen9;


    public void DisableAll()
    {
        screen1.SetActive(false);
        screen2.SetActive(false);
        screen3.SetActive(false);
        screen4.SetActive(false);
        screen5.SetActive(false);
        screen6.SetActive(false); 
    }

    public void ShowScreen(int screenNo)
    {
        switch (screenNo)
        {
            case 1:
                DisableAll();
                screen1.SetActive(true);
                break;
            case 2:
                DisableAll();
                screen2.SetActive(true);
                break;
            case 3:
                DisableAll();
                screen3.SetActive(true);
                break;
            case 4:
                DisableAll();
                screen4.SetActive(true);
                break;
            case 5:
                DisableAll();
                screen5.SetActive(true);
                break;
            case 6:
                DisableAll();
                screen6.SetActive(true);
                break;
            case 7:
              
                screen7.SetActive(true);
                break;
            case 8:
               
                screen8.SetActive(true);
                break;
            case 9:

                screen9.SetActive(true);
                break;
        }
    }

    public void Back()
    {
        if (screen7.activeSelf)
            StartCoroutine( waitForSoundToPlay(screen7));
        else if (screen8.activeSelf)
            StartCoroutine(waitForSoundToPlay(screen8));
        else if (screen9.activeSelf)
            StartCoroutine(waitForSoundToPlay(screen9));
        else
        {
            DisableAll();
            screen1.SetActive(true);
        }
    }

    IEnumerator waitForSoundToPlay(GameObject screen)
    {
        print("runned");
        yield return new WaitForSeconds(0.15f);
        screen.SetActive(false);

    }
}