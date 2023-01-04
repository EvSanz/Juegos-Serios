using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class MusicFadeOut : MonoBehaviour
{
    public int secondsToFadeOut;
    public AudioSource backgroundMusic; 

    public void findAudio()
    {
        StartCoroutine(findAudioAndFadeOut());
    }

    IEnumerator findAudioAndFadeOut()
    {
        while (backgroundMusic.volume > 0.01f)
        {
            backgroundMusic.volume -= Time.deltaTime / secondsToFadeOut;
            yield return null;
        }

        backgroundMusic.volume = 0;
        backgroundMusic.Stop();
        Destroy(this);
    }
}
