using System;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    
    void Awake()
    {
        foreach(Sound s in sounds)
        {
            s.audioSource = gameObject.AddComponent<AudioSource>();
            s.audioSource.clip = s.clip;

            s.audioSource.volume = s.volume;
            s.audioSource.pitch = s.pitch;
            s.audioSource.loop = s.loop;
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound not found!");
            return;
        }
        s.audioSource.Play();
    }

    public void Stop()
    {
        foreach (Sound s in sounds)
        {
            s.audioSource.Stop();
        }    
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound not found!");
            return;
        }
        s.audioSource.Stop();
    }

    public void Volume(float volume)
    {
        foreach (Sound s in sounds)
        {
            s.audioSource.volume = s.volume * volume;
        }
    }
}
