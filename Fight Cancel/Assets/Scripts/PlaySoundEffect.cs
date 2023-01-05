using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundEffect : MonoBehaviour
{
    public AudioSource soundEffect; 

    public void PlayThisSound()
    {
        soundEffect.Play(); 
    }

    public void StopSound()
    {
        soundEffect.Pause();
        soundEffect.Stop();
        soundEffect.mute = true;
    }
}
