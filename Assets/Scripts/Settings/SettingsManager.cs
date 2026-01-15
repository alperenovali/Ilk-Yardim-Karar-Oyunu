using FirstAidGame.Core;
using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental.GraphView;

namespace FirstAidGame.Settings
{
    public class SettingsManager : Singleton<SettingsManager>
    {
        [Header("Audio Mixer Connection")]
        public AudioMixer mainMixer;
        public string CurrentLanguage { get; private set; } = "TR";
        public float MusicVolume { get; private set; }
        public float SFXVolume { get; private set; }
        public float VoiceVolume { get; private set; }
        private void Start()
        {
            LoadSettings();
        }


        public void SetMusicVolume(float value)
        {
            MusicVolume = value;
            ApplyVolume("MusicVol", value);
            PlayerPrefs.SetFloat("MusicVolume",value);
            Debug.Log("Music Volume set to: " + value);
        }

        public void SetSFXVolume(float value)
        {
            SFXVolume = value;
            ApplyVolume("SFXVol", value);
            PlayerPrefs.SetFloat("SFXVolume", value);
            Debug.Log("SFX Volume set to: " + value);
        }

        public void SetVoiceVolume(float value)
        {
            VoiceVolume = value;
            ApplyVolume("VoiceVol", value);
            PlayerPrefs.SetFloat("VoiceVolume", value);
        }

        private void ApplyVolume(string parameterName, float value)
        {
            float dB = value > 0 ? Mathf.Log10(value) * 20 : -80f;
            mainMixer.SetFloat(parameterName,dB);
        }

        private void LoadSettings()
        {
            MusicVolume = PlayerPrefs.GetFloat("MusicVolume",0.75f);
            SFXVolume = PlayerPrefs.GetFloat("SFXVolume",0.75f);
            VoiceVolume = PlayerPrefs.GetFloat("VoiceVolume", 1f);

            SetMusicVolume(MusicVolume);
            SetSFXVolume(SFXVolume);
            SetVoiceVolume(VoiceVolume);
        }

        public void SetLanguage(string language)
        {
            if(language == "TR")
                Debug.Log("Dil Türkçe olarak ayarlandý.");
            else if (language == "EN")
                Debug.Log("Dil Ýngilizce olarak ayarlandý.");
            else
                Debug.LogWarning("Dil ayarlanamadý.");
        }
    }
}