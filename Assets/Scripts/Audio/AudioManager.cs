using FirstAidGame.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace FirstAidGame.Audio
{
    public class AudioManager : Singleton<AudioManager>
    {
        [Header("Audio Sources")]
        public AudioSource musicSource;
        public AudioSource SFXSource;
        public AudioSource voiceSource;

        public void PlayMusic(AudioClip clip, bool loop =true)
        {
            if (clip == null || musicSource.clip == clip) return;

            musicSource.clip = clip;
            musicSource.loop = loop;
            musicSource.Play();
        }

        public void PlaySFX(AudioClip clip)
        {
            if(clip != null)
                SFXSource.PlayOneShot(clip);
        }

        public void PlayVoice(AudioClip clip)
        {
            if (clip == null) return;

            voiceSource.Stop();
            voiceSource.clip = clip;
            voiceSource.Play();
        }
    }
}