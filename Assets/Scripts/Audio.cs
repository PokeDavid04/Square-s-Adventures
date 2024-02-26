using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public static Audio inst;

    AudioSource _audioSource;

    public static bool Musica = true;

    void Awake()
    {
        if (Musica == true)
        {
            if (Audio.inst == null)
            {
                Audio.inst = this;
                DontDestroyOnLoad(gameObject);
                _audioSource = GetComponent <AudioSource>();
            }
            
            else
            {
                Destroy(gameObject);
            }
        }
        else if (Musica==false)
        {
            inst._audioSource.UnPause();
            Musica = true;
        }
        
    }

    
    public static void Parar_final()
    {
        if (Musica == true)
        {
            inst._audioSource.Pause();
            Musica = false;
        }
        

    }
}
