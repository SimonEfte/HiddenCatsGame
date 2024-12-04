using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AudioOptionsManager : MonoBehaviour
{
    public static float soundEffectolume { get; private set; }
    public static float musicVolume { get; private set; }

    public Slider audioSlider;
    public Slider musicSlider;


    public void Start()
    {
        if (!PlayerPrefs.HasKey("saveAudio")) { audioSlider.value = 0.39f; }
        else { audioSlider.value = PlayerPrefs.GetFloat("saveAudio"); }

        if (!PlayerPrefs.HasKey("saveMusic")) { audioSlider.value = 0.57f; }
        else { musicSlider.value = PlayerPrefs.GetFloat("saveMusic"); }

       
        

        if(audioSlider.value == 0.0001f) { soundEffectolume = -80; }
        if (musicSlider.value == 0.0001f) {  musicVolume = -80; }
    }

    public void OnAudioSliderValueChange(float value)
    {
        
        soundEffectolume = value;
        PlayerPrefs.SetFloat("saveAudio", audioSlider.value);
        //soundEffectSliderText.text = ((int)(value * 100)).ToString();
        AudioManager.Instance.UpdateMixerVolume();
    }

    public void OnMusicSliderValueChance(float value)
    {
        musicVolume = value;
        PlayerPrefs.SetFloat("saveMusic", musicSlider.value);
        //musicSliderText.text = ((int)(value * 100)).ToString();
        AudioManager.Instance.UpdateMixerVolume();
    }

}
