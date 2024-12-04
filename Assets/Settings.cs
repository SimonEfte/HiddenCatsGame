using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public GameObject settingBar;
    public TMP_Dropdown resolutionDropdown;
    public GameObject StartBlockScreen;
    public GameObject ButtonsAnim;
    public GameObject catsFoundBar;
    public GameObject wantedPostersFoundBar;
    public GameObject optionsBar;
    public GameObject hintsBar;
    public GameObject logo;
    public GameObject congrats;

    public static bool isInSetting;
    public static bool isInMainScreen;

    private void Awake()
    {
        isInMainScreen = true;
        isInSetting = false;
        QualitySettings.vSyncCount = 1;
    }

    public void StartGame()
    {
        FindObjectOfType<AudioManager>().Play("UIClickSound");
        isInMainScreen = false;
        isInSetting = false;

        logo.GetComponent<Animation>().Play("LogoAnim");
        ButtonsAnim.GetComponent<Animation>().Play("ButtonsAnim");

        /*if(SettingsOptions.isNormalRes == true)
        {
            catsFoundBar.GetComponent<Animation>().Play("CatsFoundInAnim");
            wantedPostersFoundBar.GetComponent<Animation>().Play("PostersFoundInAnim");
            optionsBar.GetComponent<Animation>().Play("OptionsInAnim");
            hintsBar.GetComponent<Animation>().Play("HintsInAnim");
        }*/
        
            catsFoundBar.SetActive(true);
            wantedPostersFoundBar.SetActive(true);
            optionsBar.SetActive(true);
            hintsBar.SetActive(true);
    }

    public void backButton()
    {
        if (ClickCats.catsFoundCount == 120 && ClickCats.postersFound == 6) {
            //FindObjectOfType<AudioManager>().Stop("VictoryMusic");
            //FindObjectOfType<AudioManager>().Play("MainMusic");
        }

        isInSetting = true;
        eveythingElse.SetActive(false);
        congrats.SetActive(false);
        FindObjectOfType<AudioManager>().Play("UIClickSound");
        logo.GetComponent<Animation>().Play("LogoAnimBack");
        ButtonsAnim.GetComponent<Animation>().Play("ButtonsAnimBack");
        settingBar.SetActive(false);
        catsFoundBar.SetActive(false);
        wantedPostersFoundBar.SetActive(false);
        optionsBar.SetActive(false);
        hintsBar.SetActive(false);
    }

    public GameObject fullscreenOffBlock;
    public GameObject fullscreenOnBlock;

    public void SetFullSCreen()
    {
        FindObjectOfType<AudioManager>().Play("UIClickSound");
        fullscreenOffBlock.SetActive(false);
        fullscreenOnBlock.SetActive(true);
        Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
    }

    public void SetWindowed()
    {
        FindObjectOfType<AudioManager>().Play("UIClickSound");
        fullscreenOffBlock.SetActive(true);
        fullscreenOnBlock.SetActive(false);
        Screen.fullScreenMode = FullScreenMode.Windowed;
    }


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            FindObjectOfType<AudioManager>().Play("UIClickSound");
            if (settingBar.activeInHierarchy) { settingBar.SetActive(false);  isInSetting = false; }
            else if (!settingBar.activeInHierarchy) { settingBar.SetActive(true);  isInSetting = true;  }
        }
    }

    public void SettingsOpen()
    {
        FindObjectOfType<AudioManager>().Play("UIClickSound");
        isInSetting = true;
        settingBar.SetActive(true);
    }
    public void SettingsExti()
    {
        FindObjectOfType<AudioManager>().Play("UIClickSound");
        youWishToReset.SetActive(false);
        isInSetting = false;
        settingBar.SetActive(false);
    }

    public void ExitGame()
    {
        eveythingElse.SetActive(false);
        congrats.SetActive(false);
        FindObjectOfType<AudioManager>().Play("UIClickSound");
        Application.Quit();
    }

    public void closeWonScreen()
    {
        FindObjectOfType<AudioManager>().Play("UIClickSound");
        eveythingElse.SetActive(false);
        congrats.SetActive(false);
    }

    public GameObject youWishToReset;
    public GameObject eveythingElse;

    public void ResetButton()
    {
        FindObjectOfType<AudioManager>().Play("UIClickSound");
        youWishToReset.SetActive(true);
    }

    public void ActuallyResetYES()
    {
        if (ClickCats.catsFoundCount == 120 && ClickCats.postersFound == 6)
        {
            //FindObjectOfType<AudioManager>().Stop("VictoryMusic");
            //FindObjectOfType<AudioManager>().Play("MainMusic");
        }
        eveythingElse.SetActive(false);
        congrats.SetActive(false);
        FindObjectOfType<AudioManager>().Play("UIClickSound");
        ClickCats.catsFoundCount = 0;
        ClickCats.postersFound = 0;
        ClickCats.hintsUsed = 0;
        youWishToReset.SetActive(false);

        PlayerPrefs.SetInt("savedPosters", ClickCats.postersFound);
        PlayerPrefs.SetInt("savedCats",ClickCats.catsFoundCount);
    }

    public void ActuallyResetNO()
    {
        FindObjectOfType<AudioManager>().Play("UIClickSound");
        youWishToReset.SetActive(false);
    }

    public GameObject onBlockUi;
    public GameObject offBlockUi;
    public void UIOn()
    {
        FindObjectOfType<AudioManager>().Play("UIClickSound");
        onBlockUi.SetActive(true);
        offBlockUi.SetActive(false);

        catsFoundBar.SetActive(true);
        wantedPostersFoundBar.SetActive(true);
        optionsBar.SetActive(true);
        hintsBar.SetActive(true);
    }

    public void UIOff()
    {
        FindObjectOfType<AudioManager>().Play("UIClickSound");
        onBlockUi.SetActive(false);
        offBlockUi.SetActive(true);

        catsFoundBar.SetActive(false);
        wantedPostersFoundBar.SetActive(false);
        optionsBar.SetActive(false);
        hintsBar.SetActive(false);
    }
}
