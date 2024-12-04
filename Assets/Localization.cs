using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Localization : MonoBehaviour
{
    public TextMeshProUGUI UI_START, UI_RESET, UI_RESET_SETTINGS, UI_WISHTORESET, UI_OPTIONS, UI_OPTIONSETTINGS, UI_EXIT, UI_EXITOPTIONS, UI_FULLSCREEN, UI_ON, UI_OFF, UI_F_ON, UI_F_OFF, UI_RESET_NO, UI_RESET_YES, UI_UI, UI_CONGRATS, UI_COMPLETION;
    public TextMeshProUGUI UI_THANKSOFRPLAYING;

    public TMP_FontAsset englishFontChangaOutline, englishFontChanga, japaneseFont, koreanFont, chineseFont;

    public int language;
    public GameObject languageSelectBar;

    public void Start()
    {
        if (PlayerPrefs.HasKey("languageSelect"))
        {
            language = PlayerPrefs.GetInt("languageSelect");
        }

        if(language == 1) { EnglishLanguage(); }
        if (language == 2) { RussianLanguage(); }
        if (language == 3) { JapaneseLanguage(); }
        if (language == 4) { KoreanLanguage(); }
        if (language == 5) { SimplifiedChineseLanguage(); }
        if (language == 6) { GermanLanguage(); }
        if (language == 7) { FrenchLanguage(); }
        if (language == 8) { SpanishLanguage(); }
        if (language == 9) { PortugueseLanguage(); }
        if (language == 10) { PolishLanguage(); }
        if (language == 11) { ItalianLanguage(); }
        if (language == 12) { TurkishLanguage(); }


        if (!PlayerPrefs.HasKey("languageSelect"))
        {
            languageSelectBar.SetActive(true);
            Debug.Log("English");
            language = 1;
        }
    }

    //1
    #region english
    public void EnglishLanguage()
    {
        language = 1;
        PlayerPrefs.SetInt("languageSelect", language);

        //Start screen
        UI_START.text = "START"; UI_START.fontSize = 28; UI_START.font = englishFontChangaOutline;
        UI_RESET.text = "RESET"; UI_RESET.fontSize = 28; UI_RESET.font = englishFontChangaOutline;
        UI_OPTIONS.text = "OPTIONS"; UI_OPTIONS.fontSize = 28; UI_OPTIONS.font = englishFontChangaOutline;
        UI_EXIT.text = "EXIT"; UI_EXIT.fontSize = 28; UI_EXIT.font = englishFontChangaOutline;

        //Inside Options
        UI_OPTIONSETTINGS.text = "OPTIONS"; UI_OPTIONSETTINGS.fontSize = 36; UI_OPTIONSETTINGS.font = englishFontChanga;
        UI_FULLSCREEN.text = "FULLSCREEN"; UI_FULLSCREEN.fontSize = 24; UI_FULLSCREEN.font = englishFontChanga;
        UI_RESET_SETTINGS.text = "RESET"; UI_RESET_SETTINGS.fontSize = 40; UI_RESET_SETTINGS.font = englishFontChanga;
        UI_EXITOPTIONS.text = "QUIT"; UI_EXITOPTIONS.fontSize = 45; UI_EXITOPTIONS.font = englishFontChanga;
        UI_UI.text = "UI"; UI_UI.fontSize = 45; UI_UI.font = englishFontChanga;
        UI_ON.text = "ON"; UI_ON.fontSize = 32; UI_ON.font = englishFontChanga;
        UI_OFF.text = "OFF"; UI_OFF.fontSize = 32; UI_OFF.font = englishFontChanga;
        UI_F_ON.text = "ON"; UI_F_ON.fontSize = 32; UI_F_ON.font = englishFontChanga;
        UI_F_OFF.text = "OFF"; UI_F_OFF.fontSize = 32; UI_F_OFF.font = englishFontChanga;

        //WishToReset?
        UI_WISHTORESET.text = "RESET?"; UI_WISHTORESET.fontSize = 45; UI_WISHTORESET.font = englishFontChanga;
        UI_RESET_NO.text = "NO"; UI_RESET_NO.fontSize = 35; UI_RESET_NO.font = englishFontChanga;
        UI_RESET_YES.text = "YES"; UI_RESET_YES.fontSize = 35; UI_RESET_YES.font = englishFontChanga;

        //100%Completion
        UI_CONGRATS.text = "CONGRATS"; UI_CONGRATS.fontSize = 35; UI_CONGRATS.font = englishFontChanga;
        UI_COMPLETION.text = "100% COMPLETION"; UI_COMPLETION.fontSize = 16; UI_COMPLETION.font = englishFontChanga;
        UI_THANKSOFRPLAYING.text = "THANKS FOR PLAYING!"; UI_THANKSOFRPLAYING.fontSize = 15; UI_THANKSOFRPLAYING.font = englishFontChanga;

        languageSelectBar.SetActive(false); FindObjectOfType<AudioManager>().Play("UIClickSound");
    }
    #endregion

    //2
    #region russian
    public void RussianLanguage()
    {
        language = 2;
        PlayerPrefs.SetInt("languageSelect", language);

        //Start screen
        UI_START.text = "СТАРТ"; UI_START.fontSize = 28; UI_START.font = englishFontChangaOutline;
        UI_RESET.text = "СБРОС"; UI_RESET.fontSize = 28; UI_RESET.font = englishFontChangaOutline;
        UI_OPTIONS.text = "ОПЦИИ"; UI_OPTIONS.fontSize = 28; UI_OPTIONS.font = englishFontChangaOutline;
        UI_EXIT.text = "ВЫХОД"; UI_EXIT.fontSize = 28; UI_EXIT.font = englishFontChangaOutline;

        //Inside Options
        UI_OPTIONSETTINGS.text = "ОПЦИИ"; UI_OPTIONSETTINGS.fontSize = 36; UI_OPTIONSETTINGS.font = englishFontChanga;
        UI_FULLSCREEN.text = "ПОЛНЫЙ ЭКРАН"; UI_FULLSCREEN.fontSize = 15; UI_FULLSCREEN.font = englishFontChanga;
        UI_RESET_SETTINGS.text = "СБРОС"; UI_RESET_SETTINGS.fontSize = 40; UI_RESET_SETTINGS.font = englishFontChanga;
        UI_EXITOPTIONS.text = "ВЫХОД"; UI_EXITOPTIONS.fontSize = 45; UI_EXITOPTIONS.font = englishFontChanga;
        UI_UI.text = "ИНТЕРФЕЙС"; UI_UI.fontSize = 22; UI_UI.font = englishFontChanga;
        UI_ON.text = "ВКЛ"; UI_ON.fontSize = 32; UI_ON.font = englishFontChanga;
        UI_OFF.text = "ВЫКЛ"; UI_OFF.fontSize = 22; UI_OFF.font = englishFontChanga;
        UI_F_ON.text = "ВКЛ"; UI_F_ON.fontSize = 32; UI_F_ON.font = englishFontChanga;
        UI_F_OFF.text = "ВЫКЛ"; UI_F_OFF.fontSize = 22; UI_F_OFF.font = englishFontChanga;

        //WishToReset?
        UI_WISHTORESET.text = "СБРОСИТЬ?"; UI_WISHTORESET.fontSize = 35; UI_WISHTORESET.font = englishFontChanga;
        UI_RESET_NO.text = "НЕТ"; UI_RESET_NO.fontSize = 35; UI_RESET_NO.font = englishFontChanga;
        UI_RESET_YES.text = "ДА"; UI_RESET_YES.fontSize = 35; UI_RESET_YES.font = englishFontChanga;

        //100%Completion
        UI_CONGRATS.text = "ПОЗДРАВЛЯЕМ"; UI_CONGRATS.fontSize = 25; UI_CONGRATS.font = englishFontChanga;
        UI_COMPLETION.text = "100% ЗАВЕРШЕНИЕ"; UI_COMPLETION.fontSize = 16; UI_COMPLETION.font = englishFontChanga;
        UI_THANKSOFRPLAYING.text = "СПАСИБО ЗА ИГРУ!"; UI_THANKSOFRPLAYING.fontSize = 15; UI_THANKSOFRPLAYING.font = englishFontChanga;

        languageSelectBar.SetActive(false); FindObjectOfType<AudioManager>().Play("UIClickSound");
    }
    #endregion

    //3
    #region japanese
    public void JapaneseLanguage()
    {
        language = 3;
        PlayerPrefs.SetInt("languageSelect", language);
        //Start screen
        UI_START.text = "スタート"; UI_START.fontSize = 28; UI_START.font = japaneseFont;
        UI_RESET.text = "リセット"; UI_RESET.fontSize = 28; UI_RESET.font = japaneseFont;
        UI_OPTIONS.text = "オプション"; UI_OPTIONS.fontSize = 28; UI_OPTIONS.font = japaneseFont;
        UI_EXIT.text = "終了"; UI_EXIT.fontSize = 28; UI_EXIT.font = japaneseFont;

        //Inside Options
        UI_OPTIONSETTINGS.text = "オプション"; UI_OPTIONSETTINGS.fontSize = 36; UI_OPTIONSETTINGS.font = japaneseFont;
        UI_FULLSCREEN.text = "フルスクリーン"; UI_FULLSCREEN.fontSize = 19; UI_FULLSCREEN.font = japaneseFont;
        UI_RESET_SETTINGS.text = "リセット"; UI_RESET_SETTINGS.fontSize = 40; UI_RESET_SETTINGS.font = japaneseFont;
        UI_EXITOPTIONS.text = "終了"; UI_EXITOPTIONS.fontSize = 45; UI_EXITOPTIONS.font = japaneseFont;
        UI_UI.text = "UI"; UI_UI.fontSize = 45; UI_UI.font = japaneseFont;
        UI_ON.text = "オン"; UI_ON.fontSize = 28; UI_ON.font = japaneseFont;
        UI_OFF.text = "オフ"; UI_OFF.fontSize = 28; UI_OFF.font = japaneseFont;
        UI_F_ON.text = "オン"; UI_F_ON.fontSize = 28; UI_F_ON.font = japaneseFont;
        UI_F_OFF.text = "オフ"; UI_F_OFF.fontSize = 28; UI_F_OFF.font = japaneseFont;

        //WishToReset?
        UI_WISHTORESET.text = "リセットしますか？"; UI_WISHTORESET.fontSize = 25; UI_WISHTORESET.font = japaneseFont;
        UI_RESET_NO.text = "いいえ"; UI_RESET_NO.fontSize = 28; UI_RESET_NO.font = japaneseFont;
        UI_RESET_YES.text = "はい"; UI_RESET_YES.fontSize = 35; UI_RESET_YES.font = japaneseFont;

        //100%Completion
        UI_CONGRATS.text = "おめでとうございます"; UI_CONGRATS.fontSize = 20; UI_CONGRATS.font = japaneseFont;
        UI_COMPLETION.text = "100％の達成"; UI_COMPLETION.fontSize = 16; UI_COMPLETION.font = japaneseFont;
        UI_THANKSOFRPLAYING.text = "プレイしてくれてありがとう！"; UI_THANKSOFRPLAYING.fontSize = 10; UI_THANKSOFRPLAYING.font = japaneseFont;

        languageSelectBar.SetActive(false); FindObjectOfType<AudioManager>().Play("UIClickSound");
    }
    #endregion

    //4
    #region korean
    public void KoreanLanguage()
    {
        language = 4;
        PlayerPrefs.SetInt("languageSelect", language);

        //Start screen
        UI_START.text = "시작"; UI_START.fontSize = 28; UI_START.font = koreanFont;
        UI_RESET.text = "재설정"; UI_RESET.fontSize = 28; UI_RESET.font = koreanFont;
        UI_OPTIONS.text = "옵션"; UI_OPTIONS.fontSize = 28; UI_OPTIONS.font = koreanFont;
        UI_EXIT.text = "종료"; UI_EXIT.fontSize = 28; UI_EXIT.font = koreanFont;

        //Inside Options
        UI_OPTIONSETTINGS.text = "옵션"; UI_OPTIONSETTINGS.fontSize = 36; UI_OPTIONSETTINGS.font = koreanFont;
        UI_FULLSCREEN.text = "전체 화면"; UI_FULLSCREEN.fontSize = 24; UI_FULLSCREEN.font = koreanFont;
        UI_RESET_SETTINGS.text = "재설정"; UI_RESET_SETTINGS.fontSize = 40; UI_RESET_SETTINGS.font = koreanFont;
        UI_EXITOPTIONS.text = "종료"; UI_EXITOPTIONS.fontSize = 45; UI_EXITOPTIONS.font = koreanFont;
        UI_UI.text = "UI"; UI_UI.fontSize = 45; UI_UI.font = koreanFont;
        UI_ON.text = "켜짐"; UI_ON.fontSize = 32; UI_ON.font = koreanFont;
        UI_OFF.text = "꺼짐"; UI_OFF.fontSize = 32; UI_OFF.font = koreanFont;
        UI_F_ON.text = "켜짐"; UI_F_ON.fontSize = 32; UI_F_ON.font = koreanFont;
        UI_F_OFF.text = "꺼짐"; UI_F_OFF.fontSize = 32; UI_F_OFF.font = koreanFont;

        //WishToReset?
        UI_WISHTORESET.text = "재설정 하시겠습니까?"; UI_WISHTORESET.fontSize = 27; UI_WISHTORESET.font = koreanFont;
        UI_RESET_NO.text = "아니요"; UI_RESET_NO.fontSize = 25; UI_RESET_NO.font = koreanFont;
        UI_RESET_YES.text = "예"; UI_RESET_YES.fontSize = 35; UI_RESET_YES.font = koreanFont;

        //100%Completion
        UI_CONGRATS.text = "축하합니다"; UI_CONGRATS.fontSize = 30; UI_CONGRATS.font = koreanFont;
        UI_COMPLETION.text = "100% 완료"; UI_COMPLETION.fontSize = 16; UI_COMPLETION.font = koreanFont;
        UI_THANKSOFRPLAYING.text = "플레이해주셔서 감사합니다!"; UI_THANKSOFRPLAYING.fontSize = 11; UI_THANKSOFRPLAYING.font = koreanFont;

        languageSelectBar.SetActive(false); FindObjectOfType<AudioManager>().Play("UIClickSound");
    }
    #endregion

    //5
    #region simplified_chinese
    public void SimplifiedChineseLanguage()
    {
        language = 5;
        PlayerPrefs.SetInt("languageSelect", language);

        //Start screen
        UI_START.text = "开始"; UI_START.fontSize = 28; UI_START.font = chineseFont;
        UI_RESET.text = "重置"; UI_RESET.fontSize = 28; UI_RESET.font = chineseFont;
        UI_OPTIONS.text = "选项"; UI_OPTIONS.fontSize = 28; UI_OPTIONS.font = chineseFont;
        UI_EXIT.text = "退出"; UI_EXIT.fontSize = 28; UI_EXIT.font = chineseFont;

        //Inside Options
        UI_OPTIONSETTINGS.text = "选项"; UI_OPTIONSETTINGS.fontSize = 36; UI_OPTIONSETTINGS.font = chineseFont;
        UI_FULLSCREEN.text = "全屏"; UI_FULLSCREEN.fontSize = 24; UI_FULLSCREEN.font = chineseFont;
        UI_RESET_SETTINGS.text = "重置"; UI_RESET_SETTINGS.fontSize = 40; UI_RESET_SETTINGS.font = chineseFont;
        UI_EXITOPTIONS.text = "退出"; UI_EXITOPTIONS.fontSize = 45; UI_EXITOPTIONS.font = chineseFont;
        UI_UI.text = "界面"; UI_UI.fontSize = 45; UI_UI.font = chineseFont;
        UI_ON.text = "开"; UI_ON.fontSize = 32; UI_ON.font = chineseFont;
        UI_OFF.text = "关"; UI_OFF.fontSize = 32; UI_OFF.font = chineseFont;
        UI_F_ON.text = "开"; UI_F_ON.fontSize = 32; UI_F_ON.font = chineseFont;
        UI_F_OFF.text = "关"; UI_F_OFF.fontSize = 32; UI_F_OFF.font = chineseFont;

        //WishToReset?
        UI_WISHTORESET.text = "重置？"; UI_WISHTORESET.fontSize = 45; UI_WISHTORESET.font = chineseFont;
        UI_RESET_NO.text = "否"; UI_RESET_NO.fontSize = 35; UI_RESET_NO.font = chineseFont;
        UI_RESET_YES.text = "是"; UI_RESET_YES.fontSize = 35; UI_RESET_YES.font = chineseFont;

        //100%Completion
        UI_CONGRATS.text = "恭喜"; UI_CONGRATS.fontSize = 35; UI_CONGRATS.font = chineseFont;
        UI_COMPLETION.text = "100% 完成"; UI_COMPLETION.fontSize = 16; UI_COMPLETION.font = chineseFont;
        UI_THANKSOFRPLAYING.text = "感谢您的游玩！"; UI_THANKSOFRPLAYING.fontSize = 15; UI_THANKSOFRPLAYING.font = chineseFont;

        languageSelectBar.SetActive(false); FindObjectOfType<AudioManager>().Play("UIClickSound");
    }
    #endregion

    //6
    #region german
    public void GermanLanguage()
    {
        language = 6;
        PlayerPrefs.SetInt("languageSelect", language);

        //Start screen
        UI_START.text = "START"; UI_START.fontSize = 28; UI_START.font = englishFontChangaOutline;
        UI_RESET.text = "ZURÜCKSETZEN"; UI_RESET.fontSize = 28; UI_RESET.font = englishFontChangaOutline;
        UI_OPTIONS.text = "OPTIONEN"; UI_OPTIONS.fontSize = 28; UI_OPTIONS.font = englishFontChangaOutline;
        UI_EXIT.text = "BEENDEN"; UI_EXIT.fontSize = 28; UI_EXIT.font = englishFontChangaOutline;

        //Inside Options
        UI_OPTIONSETTINGS.text = "OPTIONEN"; UI_OPTIONSETTINGS.fontSize = 36; UI_OPTIONSETTINGS.font = englishFontChanga;
        UI_FULLSCREEN.text = "VOLLBILD"; UI_FULLSCREEN.fontSize = 24; UI_FULLSCREEN.font = englishFontChanga;
        UI_RESET_SETTINGS.text = "ZURÜCKSETZEN"; UI_RESET_SETTINGS.fontSize = 24; UI_RESET_SETTINGS.font = englishFontChanga;
        UI_EXITOPTIONS.text = "BEENDEN"; UI_EXITOPTIONS.fontSize = 45; UI_EXITOPTIONS.font = englishFontChanga;
        UI_UI.text = "BENUTZEROBERFLÄCHE"; UI_UI.fontSize = 21; UI_UI.font = englishFontChanga;
        UI_ON.text = "AN"; UI_ON.fontSize = 32; UI_ON.font = englishFontChanga;
        UI_OFF.text = "AUS"; UI_OFF.fontSize = 32; UI_OFF.font = englishFontChanga;
        UI_F_ON.text = "AN"; UI_F_ON.fontSize = 32; UI_F_ON.font = englishFontChanga;
        UI_F_OFF.text = "AUS"; UI_F_OFF.fontSize = 32; UI_F_OFF.font = englishFontChanga;

        //WishToReset?
        UI_WISHTORESET.text = "ZURÜCKSETZEN?"; UI_WISHTORESET.fontSize = 30; UI_WISHTORESET.font = englishFontChanga;
        UI_RESET_NO.text = "NEIN"; UI_RESET_NO.fontSize = 35; UI_RESET_NO.font = englishFontChanga;
        UI_RESET_YES.text = "JA"; UI_RESET_YES.fontSize = 35; UI_RESET_YES.font = englishFontChanga;

        //100%Completion
        UI_CONGRATS.text = "GLÜCKWUNSCH"; UI_CONGRATS.fontSize = 30; UI_CONGRATS.font = englishFontChanga;
        UI_COMPLETION.text = "100% ABGESCHLOSSEN"; UI_COMPLETION.fontSize = 16; UI_COMPLETION.font = englishFontChanga;
        UI_THANKSOFRPLAYING.text = "DANKE FÜR DAS SPIELEN!"; UI_THANKSOFRPLAYING.fontSize = 15; UI_THANKSOFRPLAYING.font = englishFontChanga;

        languageSelectBar.SetActive(false); FindObjectOfType<AudioManager>().Play("UIClickSound");
    }
    #endregion

    //7
    #region french
    public void FrenchLanguage()
    {
        language = 7;
        PlayerPrefs.SetInt("languageSelect", language);

        //Start screen
        UI_START.text = "JOUER"; UI_START.fontSize = 28; UI_START.font = englishFontChangaOutline;
        UI_RESET.text = "RÉINITIALISER"; UI_RESET.fontSize = 28; UI_RESET.font = englishFontChangaOutline;
        UI_OPTIONS.text = "OPTIONS"; UI_OPTIONS.fontSize = 28; UI_OPTIONS.font = englishFontChangaOutline;
        UI_EXIT.text = "QUITTER"; UI_EXIT.fontSize = 28; UI_EXIT.font = englishFontChangaOutline;

        //Inside Options
        UI_OPTIONSETTINGS.text = "OPTIONS"; UI_OPTIONSETTINGS.fontSize = 36; UI_OPTIONSETTINGS.font = englishFontChanga;
        UI_FULLSCREEN.text = "PLEIN ÉCRAN"; UI_FULLSCREEN.fontSize = 24; UI_FULLSCREEN.font = englishFontChanga;
        UI_RESET_SETTINGS.text = "RÉINITIALISER"; UI_RESET_SETTINGS.fontSize = 26; UI_RESET_SETTINGS.font = englishFontChanga;
        UI_EXITOPTIONS.text = "QUITTER"; UI_EXITOPTIONS.fontSize = 45; UI_EXITOPTIONS.font = englishFontChanga;
        UI_UI.text = "INTERFACE UTILISATEUR"; UI_UI.fontSize = 20; UI_UI.font = englishFontChanga;
        UI_ON.text = "ACTIVÉ"; UI_ON.fontSize = 20; UI_ON.font = englishFontChanga;
        UI_OFF.text = "DÉSACTIVÉ"; UI_OFF.fontSize = 13; UI_OFF.font = englishFontChanga;
        UI_F_ON.text = "ACTIVÉ"; UI_F_ON.fontSize = 20; UI_F_ON.font = englishFontChanga;
        UI_F_OFF.text = "DÉSACTIVÉ"; UI_F_OFF.fontSize = 13; UI_F_OFF.font = englishFontChanga;

        //WishToReset?
        UI_WISHTORESET.text = "RÉINITIALISER ?"; UI_WISHTORESET.fontSize = 35; UI_WISHTORESET.font = englishFontChanga;
        UI_RESET_NO.text = "NON"; UI_RESET_NO.fontSize = 35; UI_RESET_NO.font = englishFontChanga;
        UI_RESET_YES.text = "OUI"; UI_RESET_YES.fontSize = 35; UI_RESET_YES.font = englishFontChanga;

        //100%Completion
        UI_CONGRATS.text = "FÉLICITATIONS"; UI_CONGRATS.fontSize = 30; UI_CONGRATS.font = englishFontChanga;
        UI_COMPLETION.text = "100% DE RÉUSSITE"; UI_COMPLETION.fontSize = 16; UI_COMPLETION.font = englishFontChanga;
        UI_THANKSOFRPLAYING.text = "MERCI D'AVOIR JOUÉ !"; UI_THANKSOFRPLAYING.fontSize = 15; UI_THANKSOFRPLAYING.font = englishFontChanga;

        languageSelectBar.SetActive(false); FindObjectOfType<AudioManager>().Play("UIClickSound");
    }
    #endregion

    //8
    #region spanish
    public void SpanishLanguage()
    {
        language = 8;
        PlayerPrefs.SetInt("languageSelect", language);

        //Start screen
        UI_START.text = "JUGAR"; UI_START.fontSize = 28; UI_START.font = englishFontChangaOutline;
        UI_RESET.text = "REINICIAR"; UI_RESET.fontSize = 28; UI_RESET.font = englishFontChangaOutline;
        UI_OPTIONS.text = "OPCIONES"; UI_OPTIONS.fontSize = 28; UI_OPTIONS.font = englishFontChangaOutline;
        UI_EXIT.text = "SALIR"; UI_EXIT.fontSize = 28; UI_EXIT.font = englishFontChangaOutline;

        //Inside Options
        UI_OPTIONSETTINGS.text = "OPCIONES"; UI_OPTIONSETTINGS.fontSize = 36; UI_OPTIONSETTINGS.font = englishFontChanga;
        UI_FULLSCREEN.text = "PANTALLA COMPLETA"; UI_FULLSCREEN.fontSize = 15; UI_FULLSCREEN.font = englishFontChanga;
        UI_RESET_SETTINGS.text = "REINICIAR"; UI_RESET_SETTINGS.fontSize = 40; UI_RESET_SETTINGS.font = englishFontChanga;
        UI_EXITOPTIONS.text = "SALIR"; UI_EXITOPTIONS.fontSize = 45; UI_EXITOPTIONS.font = englishFontChanga;
        UI_UI.text = "INTERFAZ DE USUARIO"; UI_UI.fontSize = 20; UI_UI.font = englishFontChanga;
        UI_ON.text = "ENCENDIDO"; UI_ON.fontSize = 12; UI_ON.font = englishFontChanga;
        UI_OFF.text = "APAGADO"; UI_OFF.fontSize = 15; UI_OFF.font = englishFontChanga;
        UI_F_ON.text = "ENCENDIDO"; UI_F_ON.fontSize = 12; UI_F_ON.font = englishFontChanga;
        UI_F_OFF.text = "APAGADO"; UI_F_OFF.fontSize = 15; UI_F_OFF.font = englishFontChanga;

        //WishToReset?
        UI_WISHTORESET.text = "¿REINICIAR?"; UI_WISHTORESET.fontSize = 45; UI_WISHTORESET.font = englishFontChanga;
        UI_RESET_NO.text = "NO"; UI_RESET_NO.fontSize = 35; UI_RESET_NO.font = englishFontChanga;
        UI_RESET_YES.text = "SÍ"; UI_RESET_YES.fontSize = 35; UI_RESET_YES.font = englishFontChanga;

        //100%Completion
        UI_CONGRATS.text = "FELICIDADES"; UI_CONGRATS.fontSize = 35; UI_CONGRATS.font = englishFontChanga;
        UI_COMPLETION.text = "100% COMPLETADO"; UI_COMPLETION.fontSize = 16; UI_COMPLETION.font = englishFontChanga;
        UI_THANKSOFRPLAYING.text = "¡GRACIAS POR JUGAR!"; UI_THANKSOFRPLAYING.fontSize = 15; UI_THANKSOFRPLAYING.font = englishFontChanga;

        languageSelectBar.SetActive(false); FindObjectOfType<AudioManager>().Play("UIClickSound");
    } 
    #endregion

    //9
    #region portuguese
    public void PortugueseLanguage()
    {
        language = 9;
        PlayerPrefs.SetInt("languageSelect", language);

        //Start screen
        UI_START.text = "JOGAR"; UI_START.fontSize = 28; UI_START.font = englishFontChangaOutline;
        UI_RESET.text = "REINICIAR"; UI_RESET.fontSize = 28; UI_RESET.font = englishFontChangaOutline;
        UI_OPTIONS.text = "OPÇÕES"; UI_OPTIONS.fontSize = 28; UI_OPTIONS.font = englishFontChangaOutline;
        UI_EXIT.text = "SAIR"; UI_EXIT.fontSize = 28; UI_EXIT.font = englishFontChangaOutline;

        //Inside Options
        UI_OPTIONSETTINGS.text = "OPÇÕES"; UI_OPTIONSETTINGS.fontSize = 36; UI_OPTIONSETTINGS.font = englishFontChanga;
        UI_FULLSCREEN.text = "TELA CHEIA"; UI_FULLSCREEN.fontSize = 24; UI_FULLSCREEN.font = englishFontChanga;
        UI_RESET_SETTINGS.text = "REINICIAR"; UI_RESET_SETTINGS.fontSize = 40; UI_RESET_SETTINGS.font = englishFontChanga;
        UI_EXITOPTIONS.text = "SAIR"; UI_EXITOPTIONS.fontSize = 45; UI_EXITOPTIONS.font = englishFontChanga;
        UI_UI.text = "INTERFACE DO USUÁRIO"; UI_UI.fontSize = 15; UI_UI.font = englishFontChanga;
        UI_ON.text = "ATIVADO"; UI_ON.fontSize = 14; UI_ON.font = englishFontChanga;
        UI_OFF.text = "DESLIGADO"; UI_OFF.fontSize = 13; UI_OFF.font = englishFontChanga;
        UI_F_ON.text = "ATIVADO"; UI_F_ON.fontSize = 14; UI_F_ON.font = englishFontChanga;
        UI_F_OFF.text = "DESLIGADO"; UI_F_OFF.fontSize = 13; UI_F_OFF.font = englishFontChanga;

        //WishToReset?
        UI_WISHTORESET.text = "REINICIAR?"; UI_WISHTORESET.fontSize = 45; UI_WISHTORESET.font = englishFontChanga;
        UI_RESET_NO.text = "NÃO"; UI_RESET_NO.fontSize = 35; UI_RESET_NO.font = englishFontChanga;
        UI_RESET_YES.text = "SIM"; UI_RESET_YES.fontSize = 35; UI_RESET_YES.font = englishFontChanga;

        //100%Completion
        UI_CONGRATS.text = "PARABÉNS"; UI_CONGRATS.fontSize = 35; UI_CONGRATS.font = englishFontChanga;
        UI_COMPLETION.text = "100% CONCLUÍDO"; UI_COMPLETION.fontSize = 16; UI_COMPLETION.font = englishFontChanga;
        UI_THANKSOFRPLAYING.text = "OBRIGADO POR JOGAR!"; UI_THANKSOFRPLAYING.fontSize = 15; UI_THANKSOFRPLAYING.font = englishFontChanga;

        languageSelectBar.SetActive(false); FindObjectOfType<AudioManager>().Play("UIClickSound");
    }
    #endregion

    //10
    #region polish
    public void PolishLanguage()
    {
        language = 10;
        PlayerPrefs.SetInt("languageSelect", language);

        //Start screen
        UI_START.text = "GRAJ"; UI_START.fontSize = 28; UI_START.font = englishFontChangaOutline;
        UI_RESET.text = "RESETUJ"; UI_RESET.fontSize = 28; UI_RESET.font = englishFontChangaOutline;
        UI_OPTIONS.text = "OPCJE"; UI_OPTIONS.fontSize = 28; UI_OPTIONS.font = englishFontChangaOutline;
        UI_EXIT.text = "WYJDŹ"; UI_EXIT.fontSize = 28; UI_EXIT.font = englishFontChangaOutline;

        //Inside Options
        UI_OPTIONSETTINGS.text = "OPCJE"; UI_OPTIONSETTINGS.fontSize = 36; UI_OPTIONSETTINGS.font = englishFontChanga;
        UI_FULLSCREEN.text = "PEŁNY EKRAN"; UI_FULLSCREEN.fontSize = 19; UI_FULLSCREEN.font = englishFontChanga;
        UI_RESET_SETTINGS.text = "RESETUJ"; UI_RESET_SETTINGS.fontSize = 40; UI_RESET_SETTINGS.font = englishFontChanga;
        UI_EXITOPTIONS.text = "WYJDŹ"; UI_EXITOPTIONS.fontSize = 45; UI_EXITOPTIONS.font = englishFontChanga;
        UI_UI.text = "INTERFEJS"; UI_UI.fontSize = 31; UI_UI.font = englishFontChanga;
        UI_ON.text = "WŁ."; UI_ON.fontSize = 32; UI_ON.font = englishFontChanga;
        UI_OFF.text = "WYŁ."; UI_OFF.fontSize = 29; UI_OFF.font = englishFontChanga;
        UI_F_ON.text = "WŁ."; UI_F_ON.fontSize = 32; UI_F_ON.font = englishFontChanga;
        UI_F_OFF.text = "WYŁ."; UI_F_OFF.fontSize = 29; UI_F_OFF.font = englishFontChanga;

        //WishToReset?
        UI_WISHTORESET.text = "RESETOWAĆ?"; UI_WISHTORESET.fontSize = 40; UI_WISHTORESET.font = englishFontChanga;
        UI_RESET_NO.text = "NIE"; UI_RESET_NO.fontSize = 35; UI_RESET_NO.font = englishFontChanga;
        UI_RESET_YES.text = "TAK"; UI_RESET_YES.fontSize = 35; UI_RESET_YES.font = englishFontChanga;

        //100%Completion
        UI_CONGRATS.text = "GRATULACJE"; UI_CONGRATS.fontSize = 35; UI_CONGRATS.font = englishFontChanga;
        UI_COMPLETION.text = "100% UKOŃCZENIA"; UI_COMPLETION.fontSize = 16; UI_COMPLETION.font = englishFontChanga;
        UI_THANKSOFRPLAYING.text = "DZIĘKUJEMY ZA GRĘ!"; UI_THANKSOFRPLAYING.fontSize = 15; UI_THANKSOFRPLAYING.font = englishFontChanga;

        languageSelectBar.SetActive(false); FindObjectOfType<AudioManager>().Play("UIClickSound");
    }
    #endregion

    //11
    #region italian
    public void ItalianLanguage()
    {
        language = 11;
        PlayerPrefs.SetInt("languageSelect", language);

        //Start screen
        UI_START.text = "GIOCA"; UI_START.fontSize = 28; UI_START.font = englishFontChangaOutline;
        UI_RESET.text = "RESETTA"; UI_RESET.fontSize = 28; UI_RESET.font = englishFontChangaOutline;
        UI_OPTIONS.text = "OPZIONI"; UI_OPTIONS.fontSize = 28; UI_OPTIONS.font = englishFontChangaOutline;
        UI_EXIT.text = "ESCI"; UI_EXIT.fontSize = 28; UI_EXIT.font = englishFontChangaOutline;

        //Inside Options
        UI_OPTIONSETTINGS.text = "OPZIONI"; UI_OPTIONSETTINGS.fontSize = 36; UI_OPTIONSETTINGS.font = englishFontChanga;
        UI_FULLSCREEN.text = "SCHERMO INTERO"; UI_FULLSCREEN.fontSize = 17; UI_FULLSCREEN.font = englishFontChanga;
        UI_RESET_SETTINGS.text = "RESETTA"; UI_RESET_SETTINGS.fontSize = 40; UI_RESET_SETTINGS.font = englishFontChanga;
        UI_EXITOPTIONS.text = "ESCI"; UI_EXITOPTIONS.fontSize = 45; UI_EXITOPTIONS.font = englishFontChanga;
        UI_UI.text = "INTERFACCIA UTENTE"; UI_UI.fontSize = 21; UI_UI.font = englishFontChanga;
        UI_ON.text = "ACCESO"; UI_ON.fontSize = 19; UI_ON.font = englishFontChanga;
        UI_OFF.text = "SPENTO"; UI_OFF.fontSize = 18; UI_OFF.font = englishFontChanga;
        UI_F_ON.text = "ACCESO"; UI_F_ON.fontSize = 19; UI_F_ON.font = englishFontChanga;
        UI_F_OFF.text = "SPENTO"; UI_F_OFF.fontSize = 18; UI_F_OFF.font = englishFontChanga;

        //WishToReset?
        UI_WISHTORESET.text = "RESETTARE?"; UI_WISHTORESET.fontSize = 45; UI_WISHTORESET.font = englishFontChanga;
        UI_RESET_NO.text = "NO"; UI_RESET_NO.fontSize = 35; UI_RESET_NO.font = englishFontChanga;
        UI_RESET_YES.text = "SI"; UI_RESET_YES.fontSize = 35; UI_RESET_YES.font = englishFontChanga;

        //100%Completion
        UI_CONGRATS.text = "COMPLIMENTI"; UI_CONGRATS.fontSize = 35; UI_CONGRATS.font = englishFontChanga;
        UI_COMPLETION.text = "COMPLETAMENTO 100%"; UI_COMPLETION.fontSize = 16; UI_COMPLETION.font = englishFontChanga;
        UI_THANKSOFRPLAYING.text = "GRAZIE PER AVER GIOCATO!"; UI_THANKSOFRPLAYING.fontSize = 15; UI_THANKSOFRPLAYING.font = englishFontChanga;

        languageSelectBar.SetActive(false); FindObjectOfType<AudioManager>().Play("UIClickSound");
    }
    #endregion

    //12
    #region turkish
    public void TurkishLanguage()
    {
        language = 12;
        PlayerPrefs.SetInt("languageSelect", language);

        //Start screen
        UI_START.text = "OYNA"; UI_START.fontSize = 28; UI_START.font = englishFontChangaOutline;
        UI_RESET.text = "SIFIRLA"; UI_RESET.fontSize = 28; UI_RESET.font = englishFontChangaOutline;
        UI_OPTIONS.text = "AYARLAR"; UI_OPTIONS.fontSize = 28; UI_OPTIONS.font = englishFontChangaOutline;
        UI_EXIT.text = "ÇIKIS"; UI_EXIT.fontSize = 28; UI_EXIT.font = englishFontChangaOutline;

        //Inside Options
        UI_OPTIONSETTINGS.text = "AYARLAR"; UI_OPTIONSETTINGS.fontSize = 36; UI_OPTIONSETTINGS.font = englishFontChanga;
        UI_FULLSCREEN.text = "TAM EKRAN"; UI_FULLSCREEN.fontSize = 24; UI_FULLSCREEN.font = englishFontChanga;
        UI_RESET_SETTINGS.text = "SIFIRLA"; UI_RESET_SETTINGS.fontSize = 40; UI_RESET_SETTINGS.font = englishFontChanga;
        UI_EXITOPTIONS.text = "ÇIKIS"; UI_EXITOPTIONS.fontSize = 45; UI_EXITOPTIONS.font = englishFontChanga;
        UI_UI.text = "KULLANICI ARAYÜZÜ"; UI_UI.fontSize = 21; UI_UI.font = englishFontChanga;
        UI_ON.text = "AÇIK"; UI_ON.fontSize = 25; UI_ON.font = englishFontChanga;
        UI_OFF.text = "KAPALI"; UI_OFF.fontSize = 21; UI_OFF.font = englishFontChanga;
        UI_F_ON.text = "AÇIK"; UI_F_ON.fontSize = 25; UI_F_ON.font = englishFontChanga;
        UI_F_OFF.text = "KAPALI"; UI_F_OFF.fontSize = 21; UI_F_OFF.font = englishFontChanga;

        //WishToReset?
        UI_WISHTORESET.text = "SIFIRLAMAK İSTİYOR MUSUNUZ?"; UI_WISHTORESET.fontSize = 29; UI_WISHTORESET.font = englishFontChanga;
        UI_RESET_NO.text = "HAYIR"; UI_RESET_NO.fontSize = 35; UI_RESET_NO.font = englishFontChanga;
        UI_RESET_YES.text = "EVET"; UI_RESET_YES.fontSize = 35; UI_RESET_YES.font = englishFontChanga;

        //100%Completion
        UI_CONGRATS.text = "TEBRİKLER"; UI_CONGRATS.fontSize = 35; UI_CONGRATS.font = englishFontChanga;
        UI_COMPLETION.text = "100% TAMAMLANMA"; UI_COMPLETION.fontSize = 16; UI_COMPLETION.font = englishFontChanga;
        UI_THANKSOFRPLAYING.text = "OYUN OYNADIGINIZ İÇİN TESEKKÜRLER!"; UI_THANKSOFRPLAYING.fontSize = 11; UI_THANKSOFRPLAYING.font = englishFontChanga;
         
        languageSelectBar.SetActive(false); FindObjectOfType<AudioManager>().Play("UIClickSound");
    }
    #endregion

    public void ResetKeys()
    {
        PlayerPrefs.DeleteAll();
    }

}
