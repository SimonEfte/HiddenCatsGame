using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickCats : MonoBehaviour
{
    public TextMeshProUGUI catsFoundCountText;
    public GameObject[] catFound = new GameObject[120];
    private int startIndex = 41;
    public GameObject poster1Found, poster2Found, poster3Found, poster4Found, poster5Found, poster6Found;
    public int[] savedCatsFound = new int[120];

    public int savedPoster1, savedPoster2, savedPoster3, savedPoster4, savedPoster5, savedPoster6;

    void Start()
    {
       

        #region savedCats1-10
        savedCatsFound[0] = PlayerPrefs.GetInt("savedCat1");
        if (savedCatsFound[0] == 1) { catFound[0].SetActive(true); }

        savedCatsFound[1] = PlayerPrefs.GetInt("savedCat2");
        if (savedCatsFound[1] == 1) { catFound[1].SetActive(true); }

        savedCatsFound[2] = PlayerPrefs.GetInt("savedCat3");
        if (savedCatsFound[2] == 1) { catFound[2].SetActive(true); }

        savedCatsFound[3] = PlayerPrefs.GetInt("savedCat4");
        if (savedCatsFound[3] == 1) { catFound[3].SetActive(true); }

        savedCatsFound[4] = PlayerPrefs.GetInt("savedCat5");
        if (savedCatsFound[4] == 1) { catFound[4].SetActive(true); }

        savedCatsFound[5] = PlayerPrefs.GetInt("savedCat6");
        if (savedCatsFound[5] == 1) { catFound[5].SetActive(true); }

        savedCatsFound[6] = PlayerPrefs.GetInt("savedCat7");
        if (savedCatsFound[6] == 1) { catFound[6].SetActive(true); }

        savedCatsFound[7] = PlayerPrefs.GetInt("savedCat8");
        if (savedCatsFound[7] == 1) { catFound[7].SetActive(true); }

        savedCatsFound[8] = PlayerPrefs.GetInt("savedCat9");
        if (savedCatsFound[8] == 1) { catFound[8].SetActive(true); }

        savedCatsFound[9] = PlayerPrefs.GetInt("savedCat10");
        if (savedCatsFound[9] == 1) { catFound[9].SetActive(true); }

        #endregion

        #region savedCats11-20

        savedCatsFound[10] = PlayerPrefs.GetInt("savedCat11");
        if (savedCatsFound[10] == 1) { catFound[10].SetActive(true); }

        savedCatsFound[11] = PlayerPrefs.GetInt("savedCat12");
        if (savedCatsFound[11] == 1) { catFound[11].SetActive(true); }

        savedCatsFound[12] = PlayerPrefs.GetInt("savedCat13");
        if (savedCatsFound[12] == 1) { catFound[12].SetActive(true); }

        savedCatsFound[13] = PlayerPrefs.GetInt("savedCat14");
        if (savedCatsFound[13] == 1) { catFound[13].SetActive(true); }

        savedCatsFound[14] = PlayerPrefs.GetInt("savedCat15");
        if (savedCatsFound[14] == 1) { catFound[14].SetActive(true); }

        savedCatsFound[15] = PlayerPrefs.GetInt("savedCat16");
        if (savedCatsFound[15] == 1) { catFound[15].SetActive(true); }

        savedCatsFound[16] = PlayerPrefs.GetInt("savedCat17");
        if (savedCatsFound[16] == 1) { catFound[16].SetActive(true); }

        savedCatsFound[17] = PlayerPrefs.GetInt("savedCat18");
        if (savedCatsFound[17] == 1) { catFound[17].SetActive(true); }

        savedCatsFound[18] = PlayerPrefs.GetInt("savedCat19");
        if (savedCatsFound[18] == 1) { catFound[18].SetActive(true); }

        savedCatsFound[19] = PlayerPrefs.GetInt("savedCat20");
        if (savedCatsFound[19] == 1) { catFound[19].SetActive(true); }

        #endregion

        #region savedCats21-30

        savedCatsFound[20] = PlayerPrefs.GetInt("savedCat21");
        if (savedCatsFound[20] == 1) { catFound[20].SetActive(true); }

        savedCatsFound[21] = PlayerPrefs.GetInt("savedCat22");
        if (savedCatsFound[21] == 1) { catFound[21].SetActive(true); }

        savedCatsFound[22] = PlayerPrefs.GetInt("savedCat23");
        if (savedCatsFound[22] == 1) { catFound[22].SetActive(true); }

        savedCatsFound[23] = PlayerPrefs.GetInt("savedCat24");
        if (savedCatsFound[23] == 1) { catFound[23].SetActive(true); }

        savedCatsFound[24] = PlayerPrefs.GetInt("savedCat25");
        if (savedCatsFound[24] == 1) { catFound[24].SetActive(true); }

        savedCatsFound[25] = PlayerPrefs.GetInt("savedCat26");
        if (savedCatsFound[25] == 1) { catFound[25].SetActive(true); }

        savedCatsFound[26] = PlayerPrefs.GetInt("savedCat27");
        if (savedCatsFound[26] == 1) { catFound[26].SetActive(true); }

        savedCatsFound[27] = PlayerPrefs.GetInt("savedCat28");
        if (savedCatsFound[27] == 1) { catFound[27].SetActive(true); }

        savedCatsFound[28] = PlayerPrefs.GetInt("savedCat29");
        if (savedCatsFound[28] == 1) { catFound[28].SetActive(true); }

        savedCatsFound[29] = PlayerPrefs.GetInt("savedCat30");
        if (savedCatsFound[29] == 1) { catFound[29].SetActive(true); }

        #endregion

        #region savedCats31-40
        savedCatsFound[30] = PlayerPrefs.GetInt("savedCat31");
        if (savedCatsFound[30] == 1) { catFound[30].SetActive(true); }

        savedCatsFound[31] = PlayerPrefs.GetInt("savedCat32");
        if (savedCatsFound[31] == 1) { catFound[31].SetActive(true); }

        savedCatsFound[32] = PlayerPrefs.GetInt("savedCat33");
        if (savedCatsFound[32] == 1) { catFound[32].SetActive(true); }

        savedCatsFound[33] = PlayerPrefs.GetInt("savedCat34");
        if (savedCatsFound[33] == 1) { catFound[33].SetActive(true); }

        savedCatsFound[34] = PlayerPrefs.GetInt("savedCat35");
        if (savedCatsFound[34] == 1) { catFound[34].SetActive(true); }

        savedCatsFound[35] = PlayerPrefs.GetInt("savedCat36");
        if (savedCatsFound[35] == 1) { catFound[35].SetActive(true); }

        savedCatsFound[36] = PlayerPrefs.GetInt("savedCat37");
        if (savedCatsFound[36] == 1) { catFound[36].SetActive(true); }

        savedCatsFound[37] = PlayerPrefs.GetInt("savedCat38");
        if (savedCatsFound[37] == 1) { catFound[37].SetActive(true); }

        savedCatsFound[38] = PlayerPrefs.GetInt("savedCat39");
        if (savedCatsFound[38] == 1) { catFound[38].SetActive(true); }

        savedCatsFound[39] = PlayerPrefs.GetInt("savedCat40");
        if (savedCatsFound[39] == 1) { catFound[39].SetActive(true); }
        #endregion

        #region savedCats41-50
        savedCatsFound[40] = PlayerPrefs.GetInt("savedCat41");
        if (savedCatsFound[40] == 1) { catFound[40].SetActive(true); }

        savedCatsFound[41] = PlayerPrefs.GetInt("savedCat42");
        if (savedCatsFound[41] == 1) { catFound[41].SetActive(true); }

        savedCatsFound[42] = PlayerPrefs.GetInt("savedCat43");
        if (savedCatsFound[42] == 1) { catFound[42].SetActive(true); }

        savedCatsFound[43] = PlayerPrefs.GetInt("savedCat44");
        if (savedCatsFound[43] == 1) { catFound[43].SetActive(true); }

        savedCatsFound[44] = PlayerPrefs.GetInt("savedCat45");
        if (savedCatsFound[44] == 1) { catFound[44].SetActive(true); }

        savedCatsFound[45] = PlayerPrefs.GetInt("savedCat46");
        if (savedCatsFound[45] == 1) { catFound[45].SetActive(true); }

        savedCatsFound[46] = PlayerPrefs.GetInt("savedCat47");
        if (savedCatsFound[46] == 1) { catFound[46].SetActive(true); }

        savedCatsFound[47] = PlayerPrefs.GetInt("savedCat48");
        if (savedCatsFound[47] == 1) { catFound[47].SetActive(true); }

        savedCatsFound[48] = PlayerPrefs.GetInt("savedCat49");
        if (savedCatsFound[48] == 1) { catFound[48].SetActive(true); }

        savedCatsFound[49] = PlayerPrefs.GetInt("savedCat50");
        if (savedCatsFound[49] == 1) { catFound[49].SetActive(true); }
        #endregion

        #region savedCats51-60
        savedCatsFound[50] = PlayerPrefs.GetInt("savedCat51");
        if (savedCatsFound[50] == 1) { catFound[50].SetActive(true); }

        savedCatsFound[51] = PlayerPrefs.GetInt("savedCat52");
        if (savedCatsFound[51] == 1) { catFound[51].SetActive(true); }

        savedCatsFound[52] = PlayerPrefs.GetInt("savedCat53");
        if (savedCatsFound[52] == 1) { catFound[52].SetActive(true); }

        savedCatsFound[53] = PlayerPrefs.GetInt("savedCat54");
        if (savedCatsFound[53] == 1) { catFound[53].SetActive(true); }

        savedCatsFound[54] = PlayerPrefs.GetInt("savedCat55");
        if (savedCatsFound[54] == 1) { catFound[54].SetActive(true); }

        savedCatsFound[55] = PlayerPrefs.GetInt("savedCat56");
        if (savedCatsFound[55] == 1) { catFound[55].SetActive(true); }

        savedCatsFound[56] = PlayerPrefs.GetInt("savedCat57");
        if (savedCatsFound[56] == 1) { catFound[56].SetActive(true); }

        savedCatsFound[57] = PlayerPrefs.GetInt("savedCat58");
        if (savedCatsFound[57] == 1) { catFound[57].SetActive(true); }

        savedCatsFound[58] = PlayerPrefs.GetInt("savedCat59");
        if (savedCatsFound[58] == 1) { catFound[58].SetActive(true); }

        savedCatsFound[59] = PlayerPrefs.GetInt("savedCat60");
        if (savedCatsFound[59] == 1) { catFound[59].SetActive(true); }
        #endregion

        #region savedCats61-70
        savedCatsFound[60] = PlayerPrefs.GetInt("savedCat61");
        if (savedCatsFound[60] == 1) { catFound[60].SetActive(true); }

        savedCatsFound[61] = PlayerPrefs.GetInt("savedCat62");
        if (savedCatsFound[61] == 1) { catFound[61].SetActive(true); }

        savedCatsFound[62] = PlayerPrefs.GetInt("savedCat63");
        if (savedCatsFound[62] == 1) { catFound[62].SetActive(true); }

        savedCatsFound[63] = PlayerPrefs.GetInt("savedCat64");
        if (savedCatsFound[63] == 1) { catFound[63].SetActive(true); }

        savedCatsFound[64] = PlayerPrefs.GetInt("savedCat65");
        if (savedCatsFound[64] == 1) { catFound[64].SetActive(true); }

        savedCatsFound[65] = PlayerPrefs.GetInt("savedCat66");
        if (savedCatsFound[65] == 1) { catFound[65].SetActive(true); }

        savedCatsFound[66] = PlayerPrefs.GetInt("savedCat67");
        if (savedCatsFound[66] == 1) { catFound[66].SetActive(true); }

        savedCatsFound[67] = PlayerPrefs.GetInt("savedCat68");
        if (savedCatsFound[67] == 1) { catFound[67].SetActive(true); }

        savedCatsFound[68] = PlayerPrefs.GetInt("savedCat69");
        if (savedCatsFound[68] == 1) { catFound[68].SetActive(true); }

        savedCatsFound[69] = PlayerPrefs.GetInt("savedCat70");
        if (savedCatsFound[69] == 1) { catFound[69].SetActive(true); }
        #endregion

        #region savedCats71-80
        savedCatsFound[70] = PlayerPrefs.GetInt("savedCat71");
        if (savedCatsFound[70] == 1) { catFound[70].SetActive(true); }

        savedCatsFound[71] = PlayerPrefs.GetInt("savedCat72");
        if (savedCatsFound[71] == 1) { catFound[71].SetActive(true); }

        savedCatsFound[72] = PlayerPrefs.GetInt("savedCat73");
        if (savedCatsFound[72] == 1) { catFound[72].SetActive(true); }

        savedCatsFound[73] = PlayerPrefs.GetInt("savedCat74");
        if (savedCatsFound[73] == 1) { catFound[73].SetActive(true); }

        savedCatsFound[74] = PlayerPrefs.GetInt("savedCat75");
        if (savedCatsFound[74] == 1) { catFound[74].SetActive(true); }

        savedCatsFound[75] = PlayerPrefs.GetInt("savedCat76");
        if (savedCatsFound[75] == 1) { catFound[75].SetActive(true); }

        savedCatsFound[76] = PlayerPrefs.GetInt("savedCat77");
        if (savedCatsFound[76] == 1) { catFound[76].SetActive(true); }

        savedCatsFound[77] = PlayerPrefs.GetInt("savedCat78");
        if (savedCatsFound[77] == 1) { catFound[77].SetActive(true); }

        savedCatsFound[78] = PlayerPrefs.GetInt("savedCat79");
        if (savedCatsFound[78] == 1) { catFound[78].SetActive(true); }

        savedCatsFound[79] = PlayerPrefs.GetInt("savedCat80");
        if (savedCatsFound[79] == 1) { catFound[79].SetActive(true); }
        #endregion

        #region savedCats81-90
        savedCatsFound[80] = PlayerPrefs.GetInt("savedCat81");
        if (savedCatsFound[80] == 1) { catFound[80].SetActive(true); }

        savedCatsFound[81] = PlayerPrefs.GetInt("savedCat82");
        if (savedCatsFound[81] == 1) { catFound[81].SetActive(true); }

        savedCatsFound[82] = PlayerPrefs.GetInt("savedCat83");
        if (savedCatsFound[82] == 1) { catFound[82].SetActive(true); }

        savedCatsFound[83] = PlayerPrefs.GetInt("savedCat84");
        if (savedCatsFound[83] == 1) { catFound[83].SetActive(true); }

        savedCatsFound[84] = PlayerPrefs.GetInt("savedCat85");
        if (savedCatsFound[84] == 1) { catFound[84].SetActive(true); }

        savedCatsFound[85] = PlayerPrefs.GetInt("savedCat86");
        if (savedCatsFound[85] == 1) { catFound[85].SetActive(true); }

        savedCatsFound[86] = PlayerPrefs.GetInt("savedCat87");
        if (savedCatsFound[86] == 1) { catFound[86].SetActive(true); }

        savedCatsFound[87] = PlayerPrefs.GetInt("savedCat88");
        if (savedCatsFound[87] == 1) { catFound[87].SetActive(true); }

        savedCatsFound[88] = PlayerPrefs.GetInt("savedCat89");
        if (savedCatsFound[88] == 1) { catFound[88].SetActive(true); }

        savedCatsFound[89] = PlayerPrefs.GetInt("savedCat90");
        if (savedCatsFound[89] == 1) { catFound[89].SetActive(true); }
        #endregion

        #region savedCats91-100
        savedCatsFound[90] = PlayerPrefs.GetInt("savedCat91");
        if (savedCatsFound[90] == 1) { catFound[90].SetActive(true); }

        savedCatsFound[91] = PlayerPrefs.GetInt("savedCat92");
        if (savedCatsFound[91] == 1) { catFound[91].SetActive(true); }

        savedCatsFound[92] = PlayerPrefs.GetInt("savedCat93");
        if (savedCatsFound[92] == 1) { catFound[92].SetActive(true); }

        savedCatsFound[93] = PlayerPrefs.GetInt("savedCat94");
        if (savedCatsFound[93] == 1) { catFound[93].SetActive(true); }

        savedCatsFound[94] = PlayerPrefs.GetInt("savedCat95");
        if (savedCatsFound[94] == 1) { catFound[94].SetActive(true); }

        savedCatsFound[95] = PlayerPrefs.GetInt("savedCat96");
        if (savedCatsFound[95] == 1) { catFound[95].SetActive(true); }

        savedCatsFound[96] = PlayerPrefs.GetInt("savedCat97");
        if (savedCatsFound[96] == 1) { catFound[96].SetActive(true); }

        savedCatsFound[97] = PlayerPrefs.GetInt("savedCat98");
        if (savedCatsFound[97] == 1) { catFound[97].SetActive(true); }

        savedCatsFound[98] = PlayerPrefs.GetInt("savedCat99");
        if (savedCatsFound[98] == 1) { catFound[98].SetActive(true); }

        savedCatsFound[99] = PlayerPrefs.GetInt("savedCat100");
        if (savedCatsFound[99] == 1) { catFound[99].SetActive(true); }
        #endregion

        #region savedCats101-110
        savedCatsFound[100] = PlayerPrefs.GetInt("savedCat101");
        if (savedCatsFound[100] == 1) { catFound[100].SetActive(true); }

        savedCatsFound[101] = PlayerPrefs.GetInt("savedCat102");
        if (savedCatsFound[101] == 1) { catFound[101].SetActive(true); }

        savedCatsFound[102] = PlayerPrefs.GetInt("savedCat103");
        if (savedCatsFound[102] == 1) { catFound[102].SetActive(true); }

        savedCatsFound[103] = PlayerPrefs.GetInt("savedCat104");
        if (savedCatsFound[103] == 1) { catFound[103].SetActive(true); }

        savedCatsFound[104] = PlayerPrefs.GetInt("savedCat105");
        if (savedCatsFound[104] == 1) { catFound[104].SetActive(true); }

        savedCatsFound[105] = PlayerPrefs.GetInt("savedCat106");
        if (savedCatsFound[105] == 1) { catFound[105].SetActive(true); }

        savedCatsFound[106] = PlayerPrefs.GetInt("savedCat107");
        if (savedCatsFound[106] == 1) { catFound[106].SetActive(true); }

        savedCatsFound[107] = PlayerPrefs.GetInt("savedCat108");
        if (savedCatsFound[107] == 1) { catFound[107].SetActive(true); }

        savedCatsFound[108] = PlayerPrefs.GetInt("savedCat109");
        if (savedCatsFound[108] == 1) { catFound[108].SetActive(true); }

        savedCatsFound[109] = PlayerPrefs.GetInt("savedCat110");
        if (savedCatsFound[109] == 1) { catFound[109].SetActive(true); }
        #endregion

        #region savedCats111-120
        savedCatsFound[110] = PlayerPrefs.GetInt("savedCat111");
        if (savedCatsFound[110] == 1) { catFound[110].SetActive(true); }

        savedCatsFound[111] = PlayerPrefs.GetInt("savedCat112");
        if (savedCatsFound[111] == 1) { catFound[111].SetActive(true); }

        savedCatsFound[112] = PlayerPrefs.GetInt("savedCat113");
        if (savedCatsFound[112] == 1) { catFound[112].SetActive(true); }

        savedCatsFound[113] = PlayerPrefs.GetInt("savedCat114");
        if (savedCatsFound[113] == 1) { catFound[113].SetActive(true); }

        savedCatsFound[114] = PlayerPrefs.GetInt("savedCat115");
        if (savedCatsFound[114] == 1) { catFound[114].SetActive(true); }

        savedCatsFound[115] = PlayerPrefs.GetInt("savedCat116");
        if (savedCatsFound[115] == 1) { catFound[115].SetActive(true); }

        savedCatsFound[116] = PlayerPrefs.GetInt("savedCat117");
        if (savedCatsFound[116] == 1) { catFound[116].SetActive(true); }

        savedCatsFound[117] = PlayerPrefs.GetInt("savedCat118");
        if (savedCatsFound[117] == 1) { catFound[117].SetActive(true); }

        savedCatsFound[118] = PlayerPrefs.GetInt("savedCat119");
        if (savedCatsFound[118] == 1) { catFound[118].SetActive(true); }

        savedCatsFound[119] = PlayerPrefs.GetInt("savedCat120");
        if (savedCatsFound[119] == 1) { catFound[119].SetActive(true); }
        #endregion

        #region savedPosters

        savedPoster1 = PlayerPrefs.GetInt("savedPoster1");
        if (savedPoster1 == 1) { poster1Found.SetActive(true); }

        savedPoster2 = PlayerPrefs.GetInt("savedPoster2");
        if (savedPoster2 == 1) { poster2Found.SetActive(true); }

        savedPoster3 = PlayerPrefs.GetInt("savedPoster3");
        if (savedPoster3 == 1) { poster3Found.SetActive(true); }

        savedPoster4 = PlayerPrefs.GetInt("savedPoster4");
        if (savedPoster4 == 1) { poster4Found.SetActive(true); }

        savedPoster5 = PlayerPrefs.GetInt("savedPoster5");
        if (savedPoster5 == 1) { poster5Found.SetActive(true); }

        savedPoster6 = PlayerPrefs.GetInt("savedPoster6");
        if (savedPoster6 == 1) { poster6Found.SetActive(true); }

        #endregion

        for (int i = 0; i < savedCatsFound.Length; i++)
        {
            savedCatsFound[i] = PlayerPrefs.GetInt("savedArrayCats" + i);
            if(savedCatsFound[i] == 0)
            {
                foreach (GameObject cat in catFound)
                {
                    cat.SetActive(false);
                }
            }
        }

        hintsUsed = PlayerPrefs.GetInt("savedHintsUsed", hintsUsed);
        hintsAmount = PlayerPrefs.GetInt("savedHints", hintsAmount);
        catsFoundCount = PlayerPrefs.GetInt("savedCats");
        postersFound = PlayerPrefs.GetInt("savedPosters");


        if (!PlayerPrefs.HasKey("savedCats"))
        {
            catsFoundCount = 0;
            postersFound = 0;
            hintsUsed = 0;
            hintsAmount = 0;
        }

        FindObjectOfType<AudioManager>().Play("VictoryMusic");

        catsFoundCountText.text = catsFoundCount + "/120";
        hintsText.text = "" + hintsAmount;
        postersFoundText.text = postersFound + "/6";

        for (int i = 0; i < catFound.Length; i++)
        {
            string catName = "cat" + (startIndex + i) + "found";
        }
    }

    public static int catsFoundCount;
    public static int postersFound;
    public static int hintsUsed;
    public static int hintsAmount;


    public void ResetCats()
    {
        hintsAmount = 0;
        PlayerPrefs.SetInt("savedHints", hintsAmount);
        hintsUsed = 0;
        PlayerPrefs.SetInt("savedHintsUsed", hintsUsed);

        savedPoster1 = 0;
        PlayerPrefs.SetInt("savedPoster1", savedPoster1);
        savedPoster2 = 0;
        PlayerPrefs.SetInt("savedPoster2", savedPoster2);
        savedPoster3 = 0;
        PlayerPrefs.SetInt("savedPoster3", savedPoster3);
        savedPoster4 = 0;
        PlayerPrefs.SetInt("savedPoster4", savedPoster4);
        savedPoster5 = 0;
        PlayerPrefs.SetInt("savedPoster5", savedPoster5);
        savedPoster6 = 0;
        PlayerPrefs.SetInt("savedPoster6", savedPoster6);

        foreach (GameObject cat in catFound)
        {
            cat.SetActive(false);
        }

        for (int i = 0; i < savedCatsFound.Length; i++)
        {
            savedCatsFound[i] = 0;
            //PlayerPrefs.SetInt("savedCat1", savedCatsFound[0]);
            //PlayerPrefs.SetInt("savedArrayCats" + i, savedCatsFound[i]);
        }

        #region resetCatsPlayerPrefs
        PlayerPrefs.SetInt("savedCat1", savedCatsFound[0]);
        PlayerPrefs.SetInt("savedCat2", savedCatsFound[1]);
        PlayerPrefs.SetInt("savedCat3", savedCatsFound[2]);
        PlayerPrefs.SetInt("savedCat4", savedCatsFound[3]);
        PlayerPrefs.SetInt("savedCat5", savedCatsFound[4]);
        PlayerPrefs.SetInt("savedCat6", savedCatsFound[5]);
        PlayerPrefs.SetInt("savedCat7", savedCatsFound[6]);
        PlayerPrefs.SetInt("savedCat8", savedCatsFound[7]);
        PlayerPrefs.SetInt("savedCat9", savedCatsFound[8]);
        PlayerPrefs.SetInt("savedCat10", savedCatsFound[9]);
        PlayerPrefs.SetInt("savedCat11", savedCatsFound[10]);
        PlayerPrefs.SetInt("savedCat12", savedCatsFound[11]);
        PlayerPrefs.SetInt("savedCat13", savedCatsFound[12]);
        PlayerPrefs.SetInt("savedCat14", savedCatsFound[13]);
        PlayerPrefs.SetInt("savedCat15", savedCatsFound[14]);
        PlayerPrefs.SetInt("savedCat16", savedCatsFound[15]);
        PlayerPrefs.SetInt("savedCat17", savedCatsFound[16]);
        PlayerPrefs.SetInt("savedCat18", savedCatsFound[17]);
        PlayerPrefs.SetInt("savedCat19", savedCatsFound[18]);
        PlayerPrefs.SetInt("savedCat20", savedCatsFound[19]);
        PlayerPrefs.SetInt("savedCat21", savedCatsFound[20]);
        PlayerPrefs.SetInt("savedCat22", savedCatsFound[21]);
        PlayerPrefs.SetInt("savedCat23", savedCatsFound[22]);
        PlayerPrefs.SetInt("savedCat24", savedCatsFound[23]);
        PlayerPrefs.SetInt("savedCat25", savedCatsFound[24]);
        PlayerPrefs.SetInt("savedCat26", savedCatsFound[25]);
        PlayerPrefs.SetInt("savedCat27", savedCatsFound[26]);
        PlayerPrefs.SetInt("savedCat28", savedCatsFound[27]);
        PlayerPrefs.SetInt("savedCat29", savedCatsFound[28]);
        PlayerPrefs.SetInt("savedCat30", savedCatsFound[29]);
        PlayerPrefs.SetInt("savedCat31", savedCatsFound[30]);
        PlayerPrefs.SetInt("savedCat32", savedCatsFound[31]);
        PlayerPrefs.SetInt("savedCat33", savedCatsFound[32]);
        PlayerPrefs.SetInt("savedCat34", savedCatsFound[33]);
        PlayerPrefs.SetInt("savedCat35", savedCatsFound[34]);
        PlayerPrefs.SetInt("savedCat36", savedCatsFound[35]);
        PlayerPrefs.SetInt("savedCat37", savedCatsFound[36]);
        PlayerPrefs.SetInt("savedCat38", savedCatsFound[37]);
        PlayerPrefs.SetInt("savedCat39", savedCatsFound[38]);
        PlayerPrefs.SetInt("savedCat40", savedCatsFound[39]);
        PlayerPrefs.SetInt("savedCat41", savedCatsFound[40]);
        PlayerPrefs.SetInt("savedCat42", savedCatsFound[41]);
        PlayerPrefs.SetInt("savedCat43", savedCatsFound[42]);
        PlayerPrefs.SetInt("savedCat44", savedCatsFound[43]);
        PlayerPrefs.SetInt("savedCat45", savedCatsFound[44]);
        PlayerPrefs.SetInt("savedCat46", savedCatsFound[45]);
        PlayerPrefs.SetInt("savedCat47", savedCatsFound[46]);
        PlayerPrefs.SetInt("savedCat48", savedCatsFound[47]);
        PlayerPrefs.SetInt("savedCat49", savedCatsFound[48]);
        PlayerPrefs.SetInt("savedCat50", savedCatsFound[49]);
        PlayerPrefs.SetInt("savedCat51", savedCatsFound[50]);
        PlayerPrefs.SetInt("savedCat52", savedCatsFound[51]);
        PlayerPrefs.SetInt("savedCat53", savedCatsFound[52]);
        PlayerPrefs.SetInt("savedCat54", savedCatsFound[53]);
        PlayerPrefs.SetInt("savedCat55", savedCatsFound[54]);
        PlayerPrefs.SetInt("savedCat56", savedCatsFound[55]);
        PlayerPrefs.SetInt("savedCat57", savedCatsFound[56]);
        PlayerPrefs.SetInt("savedCat58", savedCatsFound[57]);
        PlayerPrefs.SetInt("savedCat59", savedCatsFound[58]);
        PlayerPrefs.SetInt("savedCat60", savedCatsFound[59]);
        PlayerPrefs.SetInt("savedCat61", savedCatsFound[60]);
        PlayerPrefs.SetInt("savedCat62", savedCatsFound[61]);
        PlayerPrefs.SetInt("savedCat63", savedCatsFound[62]);
        PlayerPrefs.SetInt("savedCat64", savedCatsFound[63]);
        PlayerPrefs.SetInt("savedCat65", savedCatsFound[64]);
        PlayerPrefs.SetInt("savedCat66", savedCatsFound[65]);
        PlayerPrefs.SetInt("savedCat67", savedCatsFound[66]);
        PlayerPrefs.SetInt("savedCat68", savedCatsFound[67]);
        PlayerPrefs.SetInt("savedCat69", savedCatsFound[68]);
        PlayerPrefs.SetInt("savedCat70", savedCatsFound[69]);
        PlayerPrefs.SetInt("savedCat71", savedCatsFound[70]);
        PlayerPrefs.SetInt("savedCat72", savedCatsFound[71]);
        PlayerPrefs.SetInt("savedCat73", savedCatsFound[72]);
        PlayerPrefs.SetInt("savedCat74", savedCatsFound[73]);
        PlayerPrefs.SetInt("savedCat75", savedCatsFound[74]);
        PlayerPrefs.SetInt("savedCat76", savedCatsFound[75]);
        PlayerPrefs.SetInt("savedCat77", savedCatsFound[76]);
        PlayerPrefs.SetInt("savedCat78", savedCatsFound[77]);
        PlayerPrefs.SetInt("savedCat79", savedCatsFound[78]);
        PlayerPrefs.SetInt("savedCat80", savedCatsFound[79]);
        PlayerPrefs.SetInt("savedCat81", savedCatsFound[80]);
        PlayerPrefs.SetInt("savedCat82", savedCatsFound[81]);
        PlayerPrefs.SetInt("savedCat83", savedCatsFound[82]);
        PlayerPrefs.SetInt("savedCat84", savedCatsFound[83]);
        PlayerPrefs.SetInt("savedCat85", savedCatsFound[84]);
        PlayerPrefs.SetInt("savedCat86", savedCatsFound[85]);
        PlayerPrefs.SetInt("savedCat87", savedCatsFound[86]);
        PlayerPrefs.SetInt("savedCat88", savedCatsFound[87]);
        PlayerPrefs.SetInt("savedCat89", savedCatsFound[88]);
        PlayerPrefs.SetInt("savedCat90", savedCatsFound[89]);
        PlayerPrefs.SetInt("savedCat91", savedCatsFound[90]);
        PlayerPrefs.SetInt("savedCat92", savedCatsFound[91]);
        PlayerPrefs.SetInt("savedCat93", savedCatsFound[92]);
        PlayerPrefs.SetInt("savedCat94", savedCatsFound[93]);
        PlayerPrefs.SetInt("savedCat95", savedCatsFound[94]);
        PlayerPrefs.SetInt("savedCat96", savedCatsFound[95]);
        PlayerPrefs.SetInt("savedCat97", savedCatsFound[96]);
        PlayerPrefs.SetInt("savedCat98", savedCatsFound[97]);
        PlayerPrefs.SetInt("savedCat99", savedCatsFound[98]);
        PlayerPrefs.SetInt("savedCat100", savedCatsFound[99]);
        PlayerPrefs.SetInt("savedCat101", savedCatsFound[100]);
        PlayerPrefs.SetInt("savedCat102", savedCatsFound[101]);
        PlayerPrefs.SetInt("savedCat103", savedCatsFound[102]);
        PlayerPrefs.SetInt("savedCat104", savedCatsFound[103]);
        PlayerPrefs.SetInt("savedCat105", savedCatsFound[104]);
        PlayerPrefs.SetInt("savedCat106", savedCatsFound[105]);
        PlayerPrefs.SetInt("savedCat107", savedCatsFound[106]);
        PlayerPrefs.SetInt("savedCat108", savedCatsFound[107]);
        PlayerPrefs.SetInt("savedCat109", savedCatsFound[108]);
        PlayerPrefs.SetInt("savedCat110", savedCatsFound[109]);
        PlayerPrefs.SetInt("savedCat111", savedCatsFound[110]);
        PlayerPrefs.SetInt("savedCat112", savedCatsFound[111]);
        PlayerPrefs.SetInt("savedCat113", savedCatsFound[112]);
        PlayerPrefs.SetInt("savedCat114", savedCatsFound[113]);
        PlayerPrefs.SetInt("savedCat115", savedCatsFound[114]);
        PlayerPrefs.SetInt("savedCat116", savedCatsFound[115]);
        PlayerPrefs.SetInt("savedCat117", savedCatsFound[116]);
        PlayerPrefs.SetInt("savedCat118", savedCatsFound[117]);
        PlayerPrefs.SetInt("savedCat119", savedCatsFound[118]);
        PlayerPrefs.SetInt("savedCat120", savedCatsFound[119]);
        #endregion

        catsFoundCountText.text = "0/120";
        hintsText.text = "0";
        postersFoundText.text = "0/6";

        poster1Found.SetActive(false);
        poster2Found.SetActive(false);
        poster3Found.SetActive(false);
        poster4Found.SetActive(false);
        poster5Found.SetActive(false);
        poster6Found.SetActive(false);

    }

    #region first10
    public void cat1() {

        setArrayTo1();
        savedCatsFound[0] = 1;
        PlayerPrefs.SetInt("savedCat1", savedCatsFound[0]);
        SetText();
        clickCatSound();
        catFound[0].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat2()
    {
        setArrayTo1();
        savedCatsFound[1] = 1;
        PlayerPrefs.SetInt("savedCat2", savedCatsFound[1]);
        clickCatSound();
        SetText();
        catFound[1].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat3()
    {
        setArrayTo1();
        savedCatsFound[2] = 1;
        PlayerPrefs.SetInt("savedCat3", savedCatsFound[2]);
        clickCatSound();
        SetText();
        catFound[2].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat4()
    {
        savedCatsFound[3] = 1;
        PlayerPrefs.SetInt("savedCat4", savedCatsFound[3]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[3].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat5()
    {
        savedCatsFound[4] = 1;
        PlayerPrefs.SetInt("savedCat5", savedCatsFound[4]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[4].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat6()
    {
        savedCatsFound[5] = 1;
        PlayerPrefs.SetInt("savedCat6", savedCatsFound[5]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[5].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat7()
    {
        savedCatsFound[6] = 1;
        PlayerPrefs.SetInt("savedCat7", savedCatsFound[6]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[6].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat8()
    {
        savedCatsFound[7] = 1;
        PlayerPrefs.SetInt("savedCat8", savedCatsFound[7]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[7].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat9()
    {
        savedCatsFound[8] = 1;
        PlayerPrefs.SetInt("savedCat9", savedCatsFound[8]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[8].SetActive(true);
        StartCoroutine(waitForSound());
    }


    public void cat10()
    {
        savedCatsFound[9] = 1;
        PlayerPrefs.SetInt("savedCat10", savedCatsFound[9]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[9].SetActive(true);
        StartCoroutine(waitForSound());
    }
    #endregion

    #region 11-20

    public void cat11()
    {
        savedCatsFound[10] = 1;
        PlayerPrefs.SetInt("savedCat11", savedCatsFound[10]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[10].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat12()
    {
        savedCatsFound[11] = 1;
        PlayerPrefs.SetInt("savedCat12", savedCatsFound[11]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[11].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat13()
    {
        savedCatsFound[12] = 1;
        PlayerPrefs.SetInt("savedCat13", savedCatsFound[12]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[12].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat14()
    {
        savedCatsFound[13] = 1;
        PlayerPrefs.SetInt("savedCat14", savedCatsFound[13]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[13].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat15()
    {
        savedCatsFound[14] = 1;
        PlayerPrefs.SetInt("savedCat15", savedCatsFound[14]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[14].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat16()
    {
        savedCatsFound[15] = 1;
        PlayerPrefs.SetInt("savedCat16", savedCatsFound[15]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[15].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat17()
    {
        savedCatsFound[16] = 1;
        PlayerPrefs.SetInt("savedCat17", savedCatsFound[16]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[16].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat18()
    {
        savedCatsFound[17] = 1;
        PlayerPrefs.SetInt("savedCat18", savedCatsFound[17]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[17].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat19()
    {
        savedCatsFound[18] = 1;
        PlayerPrefs.SetInt("savedCat19", savedCatsFound[18]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[18].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat20()
    {
        savedCatsFound[19] = 1;
        PlayerPrefs.SetInt("savedCat20", savedCatsFound[19]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[19].SetActive(true);
        StartCoroutine(waitForSound());
    }

    #endregion

    #region 21-30

    public void cat21()
    {
        savedCatsFound[20] = 1;
        PlayerPrefs.SetInt("savedCat21", savedCatsFound[20]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[20].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat22()
    {
        savedCatsFound[21] = 1;
        PlayerPrefs.SetInt("savedCat22", savedCatsFound[21]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[21].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat23()
    {
        savedCatsFound[22] = 1;
        PlayerPrefs.SetInt("savedCat23", savedCatsFound[22]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[22].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat24()
    {
        savedCatsFound[23] = 1;
        PlayerPrefs.SetInt("savedCat24", savedCatsFound[23]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[23].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat25()
    {
        savedCatsFound[24] = 1;
        PlayerPrefs.SetInt("savedCat25", savedCatsFound[24]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[24].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat26()
    {
        savedCatsFound[25] = 1;
        PlayerPrefs.SetInt("savedCat26", savedCatsFound[25]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[25].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat27()
    {
        savedCatsFound[26] = 1;
        PlayerPrefs.SetInt("savedCat27", savedCatsFound[26]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[26].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat28()
    {
        savedCatsFound[27] = 1;
        PlayerPrefs.SetInt("savedCat28", savedCatsFound[27]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[27].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat29()
    {
        savedCatsFound[28] = 1;
        PlayerPrefs.SetInt("savedCat29", savedCatsFound[28]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[28].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat30()
    {
        savedCatsFound[29] = 1;
        PlayerPrefs.SetInt("savedCat30", savedCatsFound[29]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[29].SetActive(true);
        StartCoroutine(waitForSound());
    }

    #endregion

    #region 31-40

    public void cat31()
    {
        savedCatsFound[30] = 1;
        PlayerPrefs.SetInt("savedCat31", savedCatsFound[30]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[30].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat32()
    {
        savedCatsFound[31] = 1;
        PlayerPrefs.SetInt("savedCat32", savedCatsFound[31]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[31].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat33()
    {
        savedCatsFound[32] = 1;
        PlayerPrefs.SetInt("savedCat33", savedCatsFound[32]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[32].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat34()
    {
        savedCatsFound[33] = 1;
        PlayerPrefs.SetInt("savedCat34", savedCatsFound[33]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[33].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat35()
    {
        savedCatsFound[34] = 1;
        PlayerPrefs.SetInt("savedCat35", savedCatsFound[34]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[34].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat36()
    {
        savedCatsFound[35] = 1;
        PlayerPrefs.SetInt("savedCat36", savedCatsFound[35]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[35].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat37()
    {
        savedCatsFound[36] = 1;
        PlayerPrefs.SetInt("savedCat37", savedCatsFound[36]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[36].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat38()
    {
        savedCatsFound[37] = 1;
        PlayerPrefs.SetInt("savedCat38", savedCatsFound[37]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[37].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat39()
    {
        savedCatsFound[38] = 1;
        PlayerPrefs.SetInt("savedCat39", savedCatsFound[38]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[38].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat40()
    {
        savedCatsFound[39] = 1;
        PlayerPrefs.SetInt("savedCat40", savedCatsFound[39]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[39].SetActive(true);
        StartCoroutine(waitForSound());
    }

    #endregion

    #region 41-50

    public void cat41()
    {
        savedCatsFound[40] = 1;
        PlayerPrefs.SetInt("savedCat41", savedCatsFound[40]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[40].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat42()
    {
        savedCatsFound[41] = 1;
        PlayerPrefs.SetInt("savedCat42", savedCatsFound[41]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[41].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat43()
    {
        savedCatsFound[42] = 1;
        PlayerPrefs.SetInt("savedCat43", savedCatsFound[42]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[42].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat44()
    {
        savedCatsFound[43] = 1;
        PlayerPrefs.SetInt("savedCat44", savedCatsFound[43]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[43].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat45()
    {
        savedCatsFound[44] = 1;
        PlayerPrefs.SetInt("savedCat45", savedCatsFound[44]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[44].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat46()
    {
        savedCatsFound[45] = 1;
        PlayerPrefs.SetInt("savedCat46", savedCatsFound[45]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[45].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat47()
    {
        savedCatsFound[46] = 1;
        PlayerPrefs.SetInt("savedCat47", savedCatsFound[46]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[46].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat48()
    {
        savedCatsFound[47] = 1;
        PlayerPrefs.SetInt("savedCat48", savedCatsFound[47]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[47].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat49()
    {
        savedCatsFound[48] = 1;
        PlayerPrefs.SetInt("savedCat49", savedCatsFound[48]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[48].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat50()
    {
        savedCatsFound[49] = 1;
        PlayerPrefs.SetInt("savedCat50", savedCatsFound[49]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[49].SetActive(true);
        StartCoroutine(waitForSound());
    }

    #endregion

    #region 51-60

    public void cat51()
    {
        savedCatsFound[50] = 1;
        PlayerPrefs.SetInt("savedCat51", savedCatsFound[50]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[50].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat52()
    {
        savedCatsFound[51] = 1;
        PlayerPrefs.SetInt("savedCat52", savedCatsFound[51]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[51].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat53()
    {
        savedCatsFound[52] = 1;
        PlayerPrefs.SetInt("savedCat53", savedCatsFound[52]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[52].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat54()
    {
        savedCatsFound[53] = 1;
        PlayerPrefs.SetInt("savedCat54", savedCatsFound[53]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[53].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat55()
    {
        savedCatsFound[54] = 1;
        PlayerPrefs.SetInt("savedCat55", savedCatsFound[54]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[54].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat56()
    {
        savedCatsFound[55] = 1;
        PlayerPrefs.SetInt("savedCat56", savedCatsFound[55]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[55].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat57()
    {
        savedCatsFound[56] = 1;
        PlayerPrefs.SetInt("savedCat57", savedCatsFound[56]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[56].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat58()
    {
        savedCatsFound[57] = 1;
        PlayerPrefs.SetInt("savedCat58", savedCatsFound[57]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[57].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat59()
    {
        savedCatsFound[58] = 1;
        PlayerPrefs.SetInt("savedCat59", savedCatsFound[58]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[58].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat60()
    {
        savedCatsFound[59] = 1;
        PlayerPrefs.SetInt("savedCat60", savedCatsFound[59]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[59].SetActive(true);
        StartCoroutine(waitForSound());
    }

    #endregion

    #region 61-70

    public void cat61()
    {
        savedCatsFound[60] = 1;
        PlayerPrefs.SetInt("savedCat61", savedCatsFound[60]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[60].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat62()
    {
        savedCatsFound[61] = 1;
        PlayerPrefs.SetInt("savedCat62", savedCatsFound[61]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[61].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat63()
    {
        savedCatsFound[62] = 1;
        PlayerPrefs.SetInt("savedCat63", savedCatsFound[62]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[62].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat64()
    {
        savedCatsFound[63] = 1;
        PlayerPrefs.SetInt("savedCat64", savedCatsFound[63]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[63].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat65()
    {
        savedCatsFound[64] = 1;
        PlayerPrefs.SetInt("savedCat65", savedCatsFound[64]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[64].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat66()
    {
        savedCatsFound[65] = 1;
        PlayerPrefs.SetInt("savedCat66", savedCatsFound[65]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[65].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat67()
    {
        savedCatsFound[66] = 1;
        PlayerPrefs.SetInt("savedCat67", savedCatsFound[66]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[66].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat68()
    {
        savedCatsFound[67] = 1;
        PlayerPrefs.SetInt("savedCat68", savedCatsFound[67]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[67].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat69()
    {
        savedCatsFound[68] = 1;
        PlayerPrefs.SetInt("savedCat69", savedCatsFound[68]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[68].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat70()
    {
        savedCatsFound[69] = 1;
        PlayerPrefs.SetInt("savedCat70", savedCatsFound[69]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[69].SetActive(true);
        StartCoroutine(waitForSound());
    }

    #endregion

    #region 71-80

    public void cat71()
    {
        savedCatsFound[70] = 1;
        PlayerPrefs.SetInt("savedCat71", savedCatsFound[70]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[70].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat72()
    {
        savedCatsFound[71] = 1;
        PlayerPrefs.SetInt("savedCat72", savedCatsFound[71]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[71].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat73()
    {
        savedCatsFound[72] = 1;
        PlayerPrefs.SetInt("savedCat73", savedCatsFound[72]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[72].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat74()
    {
        savedCatsFound[73] = 1;
        PlayerPrefs.SetInt("savedCat74", savedCatsFound[73]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[73].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat75()
    {
        savedCatsFound[74] = 1;
        PlayerPrefs.SetInt("savedCat75", savedCatsFound[74]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[74].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat76()
    {
        savedCatsFound[75] = 1;
        PlayerPrefs.SetInt("savedCat76", savedCatsFound[75]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[75].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat77()
    {
        savedCatsFound[76] = 1;
        PlayerPrefs.SetInt("savedCat77", savedCatsFound[76]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[76].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat78()
    {
        savedCatsFound[77] = 1;
        PlayerPrefs.SetInt("savedCat78", savedCatsFound[77]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[77].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat79()
    {
        savedCatsFound[78] = 1;
        PlayerPrefs.SetInt("savedCat79", savedCatsFound[78]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[78].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat80()
    {
        savedCatsFound[79] = 1;
        PlayerPrefs.SetInt("savedCat80", savedCatsFound[79]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[79].SetActive(true);
        StartCoroutine(waitForSound());
    }

    #endregion

    #region 81-90

    public void cat81()
    {
        savedCatsFound[80] = 1;
        PlayerPrefs.SetInt("savedCat81", savedCatsFound[80]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[80].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat82()
    {
        savedCatsFound[81] = 1;
        PlayerPrefs.SetInt("savedCat82", savedCatsFound[81]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[81].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat83()
    {
        savedCatsFound[82] = 1;
        PlayerPrefs.SetInt("savedCat83", savedCatsFound[82]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[82].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat84()
    {
        savedCatsFound[83] = 1;
        PlayerPrefs.SetInt("savedCat84", savedCatsFound[83]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[83].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat85()
    {
        savedCatsFound[84] = 1;
        PlayerPrefs.SetInt("savedCat85", savedCatsFound[84]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[84].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat86()
    {
        savedCatsFound[85] = 1;
        PlayerPrefs.SetInt("savedCat86", savedCatsFound[85]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[85].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat87()
    {
        savedCatsFound[86] = 1;
        PlayerPrefs.SetInt("savedCat87", savedCatsFound[86]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[86].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat88()
    {
        savedCatsFound[87] = 1;
        PlayerPrefs.SetInt("savedCat88", savedCatsFound[87]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[87].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat89()
    {
        savedCatsFound[88] = 1;
        PlayerPrefs.SetInt("savedCat89", savedCatsFound[88]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[88].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat90()
    {
        savedCatsFound[89] = 1;
        PlayerPrefs.SetInt("savedCat90", savedCatsFound[89]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[89].SetActive(true);
        StartCoroutine(waitForSound());
    }

    #endregion

    #region 91-100

    public void cat91()
    {
        savedCatsFound[90] = 1;
        PlayerPrefs.SetInt("savedCat91", savedCatsFound[90]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[90].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat92()
    {
        savedCatsFound[91] = 1;
        PlayerPrefs.SetInt("savedCat92", savedCatsFound[91]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[91].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat93()
    {
        savedCatsFound[92] = 1;
        PlayerPrefs.SetInt("savedCat93", savedCatsFound[92]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[92].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat94()
    {
        savedCatsFound[93] = 1;
        PlayerPrefs.SetInt("savedCat94", savedCatsFound[93]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[93].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat95()
    {
        savedCatsFound[94] = 1;
        PlayerPrefs.SetInt("savedCat95", savedCatsFound[94]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[94].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat96()
    {
        savedCatsFound[95] = 1;
        PlayerPrefs.SetInt("savedCat96", savedCatsFound[95]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[95].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat97()
    {
        savedCatsFound[96] = 1;
        PlayerPrefs.SetInt("savedCat97", savedCatsFound[96]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[96].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat98()
    {
        savedCatsFound[97] = 1;
        PlayerPrefs.SetInt("savedCat98", savedCatsFound[97]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[97].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat99()
    {
        savedCatsFound[98] = 1;
        PlayerPrefs.SetInt("savedCat99", savedCatsFound[98]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[98].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat100()
    {
        savedCatsFound[99] = 1;
        PlayerPrefs.SetInt("savedCat100", savedCatsFound[99]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[99].SetActive(true);
        StartCoroutine(waitForSound());
    }

    #endregion

    #region 101-110

    public void cat101()
    {
        savedCatsFound[100] = 1;
        PlayerPrefs.SetInt("savedCat101", savedCatsFound[100]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[100].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat102()
    {
        savedCatsFound[101] = 1;
        PlayerPrefs.SetInt("savedCat102", savedCatsFound[101]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[101].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat103()
    {
        savedCatsFound[102] = 1;
        PlayerPrefs.SetInt("savedCat103", savedCatsFound[102]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[102].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat104()
    {
        savedCatsFound[103] = 1;
        PlayerPrefs.SetInt("savedCat104", savedCatsFound[103]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[103].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat105()
    {
        savedCatsFound[104] = 1;
        PlayerPrefs.SetInt("savedCat105", savedCatsFound[104]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[104].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat106()
    {
        savedCatsFound[105] = 1;
        PlayerPrefs.SetInt("savedCat106", savedCatsFound[105]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[105].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat107()
    {
        savedCatsFound[106] = 1;
        PlayerPrefs.SetInt("savedCat107", savedCatsFound[106]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[106].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat108()
    {
        savedCatsFound[107] = 1;
        PlayerPrefs.SetInt("savedCat108", savedCatsFound[107]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[107].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat109()
    {
        savedCatsFound[108] = 1;
        PlayerPrefs.SetInt("savedCat109", savedCatsFound[108]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[108].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat110()
    {
        savedCatsFound[109] = 1;
        PlayerPrefs.SetInt("savedCat110", savedCatsFound[109]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[109].SetActive(true);
        StartCoroutine(waitForSound());
    }

    #endregion

    #region 111-120

    public void cat111()
    {
        savedCatsFound[110] = 1;
        PlayerPrefs.SetInt("savedCat111", savedCatsFound[110]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[110].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat112()
    {
        savedCatsFound[111] = 1;
        PlayerPrefs.SetInt("savedCat112", savedCatsFound[111]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[111].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat113()
    {
        savedCatsFound[112] = 1;
        PlayerPrefs.SetInt("savedCat113", savedCatsFound[112]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[112].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat114()
    {
        savedCatsFound[113] = 1;
        PlayerPrefs.SetInt("savedCat114", savedCatsFound[113]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[113].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat115()
    {
        savedCatsFound[114] = 1;
        PlayerPrefs.SetInt("savedCat115", savedCatsFound[114]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[114].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat116()
    {
        savedCatsFound[115] = 1;
        PlayerPrefs.SetInt("savedCat116", savedCatsFound[115]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[115].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat117()
    {
        savedCatsFound[116] = 1;
        PlayerPrefs.SetInt("savedCat117", savedCatsFound[116]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[116].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat118()
    {
        savedCatsFound[117] = 1;
        PlayerPrefs.SetInt("savedCat118", savedCatsFound[117]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[117].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat119()
    {
        savedCatsFound[118] = 1;
        PlayerPrefs.SetInt("savedCat119", savedCatsFound[118]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[118].SetActive(true);
        StartCoroutine(waitForSound());
    }

    public void cat120()
    {
        savedCatsFound[119] = 1;
        PlayerPrefs.SetInt("savedCat120", savedCatsFound[119]);
        setArrayTo1();
        clickCatSound();
        SetText();
        catFound[119].SetActive(true);
        StartCoroutine(waitForSound());
    }

    #endregion

    #region posters
    public void poster1()
    {
        hintsAmount += 1;
        PlayerPrefs.SetInt("savedHints", hintsAmount);
        savedPoster1 = 1;
        PlayerPrefs.SetInt("savedPoster1", savedPoster1);
        posterClickSound();
        postersFound += 1;
        poster1Found.SetActive(true);
        SetPosterText();
    }

    public void poster2()
    {
        hintsAmount += 1;
        PlayerPrefs.SetInt("savedHints", hintsAmount);
        savedPoster2 = 1;
        PlayerPrefs.SetInt("savedPoster2", savedPoster2);
        posterClickSound();
        postersFound += 1;
        poster2Found.SetActive(true);
        SetPosterText();
    }

    public void poster3()
    {
        hintsAmount += 1;
        PlayerPrefs.SetInt("savedHints", hintsAmount);
        savedPoster3 = 1;
        PlayerPrefs.SetInt("savedPoster3", savedPoster3);
        posterClickSound();
        postersFound += 1;
        poster3Found.SetActive(true);
        SetPosterText();
    }

    public void poster4()
    {
        hintsAmount += 1;
        PlayerPrefs.SetInt("savedHints", hintsAmount);
        savedPoster4 = 1;
        PlayerPrefs.SetInt("savedPoster4", savedPoster4);
        posterClickSound();
        postersFound += 1;
        poster4Found.SetActive(true);
        SetPosterText();
    }

    public void poster5()
    {
        hintsAmount += 1;
        PlayerPrefs.SetInt("savedHints", hintsAmount);
        savedPoster5 = 1;
        PlayerPrefs.SetInt("savedPoster5", savedPoster5);
        posterClickSound();
        postersFound += 1;
        poster5Found.SetActive(true);
        SetPosterText();
    }

    public void poster6()
    {
        hintsAmount += 1;
        PlayerPrefs.SetInt("savedHints", hintsAmount);
        savedPoster6 = 1;
        PlayerPrefs.SetInt("savedPoster6", savedPoster6);
        posterClickSound();
        postersFound += 1;
        poster6Found.SetActive(true);
        SetPosterText();
    }

    #endregion

    public void posterClickSound()
    {
        FindObjectOfType<AudioManager>().Play("PosterClick");
        StartCoroutine(checkIfAllCats());
    }

    public TextMeshProUGUI hintsText;
    public TextMeshProUGUI postersFoundText;

    public void SetPosterText()
    {
        PlayerPrefs.SetInt("savedPosters", postersFound);
        hintsText.text = "" + postersFound;
        postersFoundText.text = postersFound + "/6";
        hintsText.text = "" + hintsAmount;
    }

    public void clickCatSound()
    {
        FindObjectOfType<AudioManager>().Play("ClickSound1");
    }

    public void SetText()
    {
        catsFoundCount += 1; 
        catsFoundCountText.text = catsFoundCount + "/120";
        PlayerPrefs.SetInt("savedCats", catsFoundCount);
        arrow.SetActive(false);
        hintCircle.SetActive(false);
        blockHints.SetActive(false);
        StopAllCoroutines();
    }

    public GameObject congrats;
    public GameObject banner;
    public GameObject eveythingElse;

    IEnumerator waitForSound()
    {
        yield return new WaitForSeconds(0.01f);
        int random = Random.Range(1, 5);
        if(random == 1) { FindObjectOfType<AudioManager>().Play("CatSound1"); }
        if (random == 2) { FindObjectOfType<AudioManager>().Play("CatSound2"); }
        if (random == 3) { FindObjectOfType<AudioManager>().Play("CatSound3"); }
        if (random == 4) { FindObjectOfType<AudioManager>().Play("CatSound4"); }
        if (random == 5) { FindObjectOfType<AudioManager>().Play("CatSound5"); }
        StartCoroutine(checkIfAllCats());
           
    }

    IEnumerator checkIfAllCats()
    {
        yield return new WaitForSeconds(0.05f);
        if (catsFoundCount == 120 && postersFound == 6)
        {
            FindObjectOfType<AudioManager>().Play("AllCatsSound");
            yield return new WaitForSeconds(1.2f);
            congrats.SetActive(true);
            FindObjectOfType<AudioManager>().Play("Swoosh");
            banner.GetComponent<Animation>().Play("CongratsBanner");
            yield return new WaitForSeconds(0.17f);
            FindObjectOfType<AudioManager>().Play("Pling");
            eveythingElse.SetActive(true);
            //FindObjectOfType<AudioManager>().Play("VictoryMusic");
            //FindObjectOfType<AudioManager>().Stop("MainMusic");
            yield return new WaitForSeconds(3);
            banner.GetComponent<Animation>().Play("BannerIdle");
        }
    }

    public void setArrayTo1()
    {
        for (int i = 0; i < savedCatsFound.Length; i++)
        {
            savedCatsFound[i] = 1;
            //PlayerPrefs.SetInt("savedCat1", savedCatsFound[0]);
            PlayerPrefs.SetInt("savedArrayCats" + i, savedCatsFound[i]);
        }
    }

    public GameObject hintCircle;
    public GameObject blockHints;
    public GameObject arrow;
    public float arrowSpeed = 2f;
    public Transform arrowSpawnPoint;
    public float randomRange = 50f;
    public bool usedHint;

    public void useHint()
    {
        if(hintsAmount == 0) { FindObjectOfType<AudioManager>().Play("NoHints"); }
        if (hintsAmount == 0)
        {
            FindObjectOfType<AudioManager>().Play("NoHints");
        }
        if (hintsAmount > 0)
        {
            hintsUsed += 1;
            PlayerPrefs.SetInt("savedHintsUsed", hintsUsed);
            FindObjectOfType<AudioManager>().Play("UIClickSound");
            hintsAmount -= 1;
            hintsText.text = "" + hintsAmount;
            PlayerPrefs.SetInt("savedHints", hintsAmount);
            blockHints.SetActive(true);
            List<int> inactiveIndices = new List<int>();

            for (int i = 0; i < catFound.Length; i++)
            {
                if (!catFound[i].activeInHierarchy)
                {
                    inactiveIndices.Add(i);
                }
            }

            if (inactiveIndices.Count == 0)
            {
                // Debug.Log("No inactive objects found.");
                return;
            }

            int randomIndex = inactiveIndices[Random.Range(0, inactiveIndices.Count)];
            Vector3 position = catFound[randomIndex].transform.position;

            position.x += Random.Range(-randomRange, randomRange);
            position.y += Random.Range(-randomRange, randomRange);

            hintCircle.transform.position = position;
            hintCircle.SetActive(true);

            // Set arrow active and move it towards hintCircle
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(4f, -4f, 0f);
            mousePos.z = 0f;
            arrow.transform.position = mousePos;

            Vector3 direction = hintCircle.transform.position - arrow.transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            arrow.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

            arrow.SetActive(true);
            StartCoroutine(MoveArrow(arrow, hintCircle.transform.position));

            StartCoroutine(waitCircle());

            //Debug.Log("Activated object at index " + randomIndex);
        }

    }

    IEnumerator waitCircle()
    {
        yield return new WaitForSeconds(12);
        blockHints.SetActive(false);
        hintCircle.SetActive(false);
    }

    public GameObject winBlock;
    public bool won;

    

    IEnumerator MoveArrow(GameObject arrow, Vector3 targetPos)
    {
        while (Vector3.Distance(arrow.transform.position, targetPos) > 0.1f)
        {
            arrow.transform.position = Vector3.MoveTowards(arrow.transform.position, targetPos, arrowSpeed * Time.deltaTime);
            yield return null;
        }

        // Set arrow inactive when it reaches the hintCircle
        arrow.SetActive(false);
    }

    public void munis1Cat()
    {
        //catsFoundCount -= 1;
    }

}

