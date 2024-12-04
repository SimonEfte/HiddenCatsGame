using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;
public class AudioManager : MonoBehaviour
{


    [SerializeField] private AudioMixerGroup musicEffectGroup;
    [SerializeField] private AudioMixerGroup soundEffectsGroup;

    public static AudioManager Instance;
    public Sounds[] sounds;


    public void Awake()
    {
        
        Instance = this;


        foreach (Sounds s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.audioClip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.Loop;

            switch (s.audioType)
            {
                case Sounds.AudioTypes.soundEffect:
                    s.source.outputAudioMixerGroup = soundEffectsGroup;
                    break;

                case Sounds.AudioTypes.music:
                    s.source.outputAudioMixerGroup = musicEffectGroup;
                    break;

            }

            

            //s.source.outputAudioMixerGroup = soundEffectsGroup;
        }
    }

    public void Stop(string name)
    {
        Sounds s = Array.Find(sounds, sound => sound.clipName == name);
        if (s == null)
        {
            Debug.LogWarning("Sound clip not found: " + name);
            return;
        }
        s.source.Stop();
    }


    public void Play(string name)
    {
        Sounds s = Array.Find(sounds, sound => sound.clipName == name);
        s.source.Play();
    }

    public void UpdateMixerVolume()
    {
       
        musicEffectGroup.audioMixer.SetFloat("Music Volume", Mathf.Log10(AudioOptionsManager.musicVolume) * 20);
        soundEffectsGroup.audioMixer.SetFloat("Audio Volume", Mathf.Log10(AudioOptionsManager.soundEffectolume) * 20);
    }
}
