using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsOptions : MonoBehaviour
{
    public Camera cameraMain;

    // Reference to the Dropdown component
    public TMP_Dropdown resolutionDropdown;

    // List of available resolutions
    private List<Resolution> resolutions = new List<Resolution>();

    private void Start()
    {
        changeRes = false;

        // Define a list of supported resolutions
        resolutions = new List<Resolution>
        {
            new Resolution { width = 800, height = 600 },
            new Resolution { width = 1024, height = 768 },
            new Resolution { width = 1280, height = 720 },
            new Resolution { width = 1280, height = 800 },
            new Resolution { width = 1280, height = 1024 },
            new Resolution { width = 1366, height = 768 },
            new Resolution { width = 1600, height = 900 },
            new Resolution { width = 1920, height = 1080 },
            new Resolution { width = 1920, height = 1200 },
            new Resolution { width = 2560, height = 1440 },
            new Resolution { width = 2560, height = 1600 },
            new Resolution { width = 2560, height = 1080 },
            new Resolution { width = 3440, height = 1440 },
            new Resolution { width = 3840, height = 1440 },
            new Resolution { width = 3840, height = 2160 },
            new Resolution { width = 3840, height = 2400 }
            // Add any other resolutions you want to support here
        };

        // Add the supported resolutions to the dropdown
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Count; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public static bool changeRes;

    public GameObject catBar, posterBar, options, hints;

    public static bool isNormalRes;

    public void SetResolution(int resolutionIndex)
    {
        //cameraMain.transform.position = new Vector3(0, 0, 0);
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
        changeRes = true;

        //StartCoroutine(wait());
        

    }

    /*IEnumerator wait()
    {
        yield return new WaitForSeconds(0.07f);

        if (Settings.isInMainScreen == true)
        {
            if (Screen.width == 800 && Screen.height == 600) { blockResolution(); }
            if (Screen.width == 1024 && Screen.height == 768) { blockResolution(); }
            if (Screen.width == 1280 && Screen.height == 1024) { blockResolution(); }

            if (Screen.width == 1280 && Screen.height == 720) { setNormalRes(); }
            if (Screen.width == 1366 && Screen.height == 768) { setNormalRes(); }
            if (Screen.width == 1600 && Screen.height == 900) { setNormalRes(); }
            if (Screen.width == 1920 && Screen.height == 1080) { setNormalRes(); }
            if (Screen.width == 2560 && Screen.height == 1440) { setNormalRes(); }
            if (Screen.width == 3840 && Screen.height == 2160) { setNormalRes(); }

            if (Screen.width == 1280 && Screen.height == 800) { sixtiinBy10Res(); }
            if (Screen.width == 1920 && Screen.height == 1200) { sixtiinBy10Res(); }
            if (Screen.width == 2560 && Screen.height == 1600) { sixtiinBy10Res(); }
            if (Screen.width == 3840 && Screen.height == 2400) { sixtiinBy10Res(); }

            if (Screen.width == 2560 && Screen.height == 1080) { wideScreen1(); }
            if (Screen.width == 3840 && Screen.height == 1440) { wideScreen2(); }
        }

        if (Settings.isInMainScreen == false)
        {
            if (Screen.width == 800 && Screen.height == 600) { blockResolutionPlaying(); }
            if (Screen.width == 1024 && Screen.height == 768) { blockResolutionPlaying(); }
            if (Screen.width == 1280 && Screen.height == 1024) { blockResolutionPlaying(); }

            if (Screen.width == 1280 && Screen.height == 720) { setNormalResPlaying(); }
            if (Screen.width == 1366 && Screen.height == 768) { setNormalResPlaying(); }
            if (Screen.width == 1600 && Screen.height == 900) { setNormalResPlaying(); }
            if (Screen.width == 1920 && Screen.height == 1080) { setNormalResPlaying(); }
            if (Screen.width == 2560 && Screen.height == 1440) { setNormalResPlaying(); }
            if (Screen.width == 3840 && Screen.height == 2160) { setNormalResPlaying(); }

            if (Screen.width == 1280 && Screen.height == 800) { sixtiinBy10ResPlaying(); }
            if (Screen.width == 1920 && Screen.height == 1200) { sixtiinBy10ResPlaying(); }
            if (Screen.width == 2560 && Screen.height == 1600) { sixtiinBy10ResPlaying(); }
            if (Screen.width == 3840 && Screen.height == 2400) { sixtiinBy10ResPlaying(); }

            if (Screen.width == 2560 && Screen.height == 1080) { wideScreen1Playing(); }
            if (Screen.width == 3840 && Screen.height == 1440) { wideScreen2Playing(); }

        }

    }

    public void setNormalRes()
    {
        isNormalRes = true;
        catBar.transform.localPosition = new Vector3(383, 333, 0); catBar.SetActive(true);
        posterBar.transform.localPosition = new Vector3(260, 333, 0); posterBar.SetActive(true);
        options.transform.localPosition = new Vector3(-430, 333, 0); options.SetActive(true);
        hints.transform.localPosition = new Vector3(-381, 333, 0); hints.SetActive(true);
    }

    public void blockResolution()
    {
        isNormalRes = false;
        catBar.transform.localPosition = new Vector3(319, 265, 0); catBar.SetActive(false);
        posterBar.transform.localPosition = new Vector3(191, 265, 0); posterBar.SetActive(false);
        options.transform.localPosition = new Vector3(-361, 265, 0); options.SetActive(false);
        hints.transform.localPosition = new Vector3(-312, 265, 0); hints.SetActive(false);
    }

    public void sixtiinBy10Res()
    {
        isNormalRes = false;
        catBar.transform.localPosition = new Vector3(361, 243, 0); catBar.SetActive(false);
        posterBar.transform.localPosition = new Vector3(238, 243, 0); posterBar.SetActive(false);
        options.transform.localPosition = new Vector3(-404, 243, 0); options.SetActive(false);
        hints.transform.localPosition = new Vector3(-355, 243, 0); hints.SetActive(false);
    }

    public void wideScreen1()
    {
        isNormalRes = false;
        catBar.transform.localPosition = new Vector3(458, 196, 0); catBar.SetActive(false);
        posterBar.transform.localPosition = new Vector3(335, 196, 0); posterBar.SetActive(false);
        options.transform.localPosition = new Vector3(-504, 196, 0); options.SetActive(false);
        hints.transform.localPosition = new Vector3(-455, 196, 0); hints.SetActive(false);
    }

    public void wideScreen2()
    {
        isNormalRes = false;
        catBar.transform.localPosition = new Vector3(493, 185, 0); catBar.SetActive(false);
        posterBar.transform.localPosition = new Vector3(370, 185, 0); posterBar.SetActive(false);
        options.transform.localPosition = new Vector3(-539, 185, 0); options.SetActive(false);
        hints.transform.localPosition = new Vector3(-491, 185, 0); hints.SetActive(false);
    }




    //oioi
    public void setNormalResPlaying()
    {
        isNormalRes = true;
        catBar.transform.localPosition = new Vector3(383, 333, 0); catBar.SetActive(true);
        posterBar.transform.localPosition = new Vector3(260, 333, 0); posterBar.SetActive(true);
        options.transform.localPosition = new Vector3(-430, 333, 0); options.SetActive(true);
        hints.transform.localPosition = new Vector3(-381, 333, 0); hints.SetActive(true);
    }

    public void blockResolutionPlaying()
    {
        isNormalRes = false;
        catBar.transform.localPosition = new Vector3(319, 265, 0); catBar.SetActive(true);
        posterBar.transform.localPosition = new Vector3(191, 265, 0); posterBar.SetActive(true);
        options.transform.localPosition = new Vector3(-361, 265, 0); options.SetActive(true);
        hints.transform.localPosition = new Vector3(-312, 265, 0); hints.SetActive(true);
    }

    public void sixtiinBy10ResPlaying()
    {
        isNormalRes = false;
        catBar.transform.localPosition = new Vector3(361, 243, 0); catBar.SetActive(true);
        posterBar.transform.localPosition = new Vector3(238, 243, 0); posterBar.SetActive(true);
        options.transform.localPosition = new Vector3(-404, 243, 0); options.SetActive(true);
        hints.transform.localPosition = new Vector3(-355, 243, 0); hints.SetActive(true);
    }

    public void wideScreen1Playing()
    {
        isNormalRes = false;
        catBar.transform.localPosition = new Vector3(458, 196, 0); catBar.SetActive(true);
        posterBar.transform.localPosition = new Vector3(335, 196, 0); posterBar.SetActive(true);
        options.transform.localPosition = new Vector3(-504, 196, 0); options.SetActive(true);
        hints.transform.localPosition = new Vector3(-455, 196, 0); hints.SetActive(true);
    }

    public void wideScreen2Playing()
    {
        isNormalRes = false;
        catBar.transform.localPosition = new Vector3(493, 185, 0); catBar.SetActive(true);
        posterBar.transform.localPosition = new Vector3(370, 185, 0); posterBar.SetActive(true);
        options.transform.localPosition = new Vector3(-539, 185, 0); options.SetActive(true);
        hints.transform.localPosition = new Vector3(-491, 185, 0); hints.SetActive(true);
    }*/

}
