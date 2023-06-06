using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Audiomanager : MonoBehaviour
{
    public Sound[] sounds;
    public static Audiomanager instance;

    public float v1;
    public float v2;
    


    void Awake()
    {

        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
           
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }


    }
    
    public void Musicplay()
    {
        Play("music");
    }
    public void Clicksound()
    {
        Play("clicksound");
    }

    public void Footstep()
    {
        Play("footsteps");
    }

    public void Stopmusic()
    {
        Stop("music");
    }
    public void Musicoff()
    {
        Mute("music");
    }
    public void Musicon()
    {
        Mutev1("music");
    }
    public void Sfxon()
    {
        Mutev2("footsteps");
        Mutev2("clicksound");
        Debug.Log("onnnnnnnn");

    }
    public void Sfxoff()
    {
        Mute("footsteps");
        Mute("clicksound");
        Debug.Log("offfffff");
    }
    public void Stopwalking()
    {
        Stop("footsteps");
    }

    public void Play(string name)
    {
        Sound s = System.Array.Find(sounds, Sound => Sound.name == name);
        if(s==null)
        {
            Debug.Log("Sound:" + name + "not found on game");
            return;
        }

        s.source.Play();
    }

    public void Stop(string name)
    {
        Sound s = System.Array.Find(sounds, Sound => Sound.name == name);

        s.source.Stop();
    }
    public void Mutev1(string name)
    {
        Sound s = System.Array.Find(sounds, Sound => Sound.name == name);

        s.source.volume = v1;
    }
    public void Mutev2(string name)
    {
        Sound s = System.Array.Find(sounds, Sound => Sound.name == name);

        s.source.volume = v2;
    }
    public void Mute(string name)
    {
        Sound s = System.Array.Find(sounds, Sound => Sound.name == name);

        s.source.volume = 0;
    }
}


