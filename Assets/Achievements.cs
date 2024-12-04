using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievements : MonoBehaviour
{
    public bool is5CatUnlocked;
    public bool is10CatUnlocked;
    public bool is20CatUnlocked;
    public bool is40CatUnlocked;
    public bool is75CatUnlocked;
    public bool is100CatUnlocked;
    public bool is120CatUnlocked;

    public bool is1posterUnlocked;
    public bool is3posterUnlocked;
    public bool is6posterUnlocked;
    public bool noHintsUsedUnlocked;

    public GameObject button;

    public void Unlock5Cats(string id)
    {
        if (ClickCats.catsFoundCount >= 5) { var ach = new Steamworks.Data.Achievement(id); ach.Trigger(); }
    }

    public void Unlock10Cats(string id)
    {
        if (ClickCats.catsFoundCount >= 10) { var ach = new Steamworks.Data.Achievement(id); ach.Trigger(); }
    }

    public void Unlock20Cats(string id)
    {
        if (ClickCats.catsFoundCount >= 20) { var ach = new Steamworks.Data.Achievement(id); ach.Trigger(); }
    }

    public void Unlock40Cats(string id)
    {
        if (ClickCats.catsFoundCount >= 40) { var ach = new Steamworks.Data.Achievement(id); ach.Trigger(); }
    }

    public void Unlock75Cats(string id)
    {
        if (ClickCats.catsFoundCount >= 75) { var ach = new Steamworks.Data.Achievement(id); ach.Trigger(); }
    }

    public void Unlock100Cats(string id)
    {
        if (ClickCats.catsFoundCount >= 100) { var ach = new Steamworks.Data.Achievement(id); ach.Trigger(); }
    }

    public void Unlock120Cats(string id)
    {
        if (ClickCats.catsFoundCount >= 120) { var ach = new Steamworks.Data.Achievement(id); ach.Trigger(); }
    }

    public void UnlockNoHints(string id)
    {
        if (ClickCats.catsFoundCount >= 120 && ClickCats.hintsUsed == 0) { var ach = new Steamworks.Data.Achievement(id); ach.Trigger(); }
    }

    public void Unlock1Poster(string id)
    {
        if (ClickCats.postersFound == 1) { var ach = new Steamworks.Data.Achievement(id); ach.Trigger(); }
    }
    public void Unlock3Poster(string id)
    {
        if (ClickCats.postersFound == 3) { var ach = new Steamworks.Data.Achievement(id); ach.Trigger(); }
    }
    public void Unlock6Poster(string id)
    {
        if (ClickCats.postersFound == 6) { var ach = new Steamworks.Data.Achievement(id); ach.Trigger(); }
    }



    public void Update()
    {
        if (ClickCats.catsFoundCount >= 5 && is5CatUnlocked == false) { is5CatUnlocked = true; button.GetComponent<Button>().onClick.Invoke(); }
        if (ClickCats.catsFoundCount >= 10 && is10CatUnlocked == false) { is10CatUnlocked = true; button.GetComponent<Button>().onClick.Invoke(); }
        if (ClickCats.catsFoundCount >= 20 && is20CatUnlocked == false) { is20CatUnlocked = true; button.GetComponent<Button>().onClick.Invoke(); }
        if (ClickCats.catsFoundCount >= 40 && is40CatUnlocked == false) { is40CatUnlocked = true; button.GetComponent<Button>().onClick.Invoke(); }
        if (ClickCats.catsFoundCount >= 75 && is75CatUnlocked == false) { is75CatUnlocked = true; button.GetComponent<Button>().onClick.Invoke(); }
        if (ClickCats.catsFoundCount >= 100 && is100CatUnlocked == false) { is100CatUnlocked = true; button.GetComponent<Button>().onClick.Invoke(); }
        if (ClickCats.catsFoundCount == 120 && is120CatUnlocked == false) { is120CatUnlocked = true; button.GetComponent<Button>().onClick.Invoke(); }
        if (ClickCats.catsFoundCount == 120 && ClickCats.hintsUsed == 0 && noHintsUsedUnlocked == false) { noHintsUsedUnlocked = true; button.GetComponent<Button>().onClick.Invoke(); }

        if (ClickCats.postersFound >= 1 && is1posterUnlocked == false) { is1posterUnlocked = true; button.GetComponent<Button>().onClick.Invoke(); }
        if (ClickCats.postersFound >= 3 && is3posterUnlocked == false) { is3posterUnlocked = true; button.GetComponent<Button>().onClick.Invoke(); }
        if (ClickCats.postersFound >= 6 && is6posterUnlocked == false) { is6posterUnlocked = true; button.GetComponent<Button>().onClick.Invoke(); }

    }


}
