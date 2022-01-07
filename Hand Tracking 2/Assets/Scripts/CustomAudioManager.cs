using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomAudioManager : MonoBehaviour
{
    public AudioSource pianoSource;
    public AudioSource uiSource;
    public AudioClip clickSound;
    public AudioClip[] octaveThreeKeys;
    public AudioClip[] octaveFourKeys;
    //public GameObject[] keyObjects;

    // color
    public Renderer[] whiteKeyRenderers;
    public Renderer[] blackKeyRenderers;
    public float resetColorTimer = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // UI click
    public void PlayUIClick()
    {
        uiSource.volume = 0.7f;
        uiSource.PlayOneShot(clickSound);
    }

    // octave 3
    #region 
    public void PlayC3Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveThreeKeys[0]);
        whiteKeyRenderers[0].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }

    public void PlayCSharp3Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveThreeKeys[1]);
        blackKeyRenderers[0].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetBlackKeyColor", resetColorTimer);
    }

    public void PlayD3Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveThreeKeys[2]);
        whiteKeyRenderers[1].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }

    public void PlayDSharp3Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveThreeKeys[3]);
        blackKeyRenderers[1].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetBlackKeyColor", resetColorTimer);
    }

    public void PlayE3Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveThreeKeys[4]);
        whiteKeyRenderers[2].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }

    public void PlayF3Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveThreeKeys[5]);
        whiteKeyRenderers[3].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }

    public void PlayFSharp3Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveThreeKeys[6]);
        blackKeyRenderers[2].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetBlackKeyColor", resetColorTimer);
    }

    public void PlayG3Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveThreeKeys[7]);
        whiteKeyRenderers[4].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }

    public void PlayGSharp3Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveThreeKeys[8]);
        blackKeyRenderers[3].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetBlackKeyColor", resetColorTimer);
    }

    public void PlayA3Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveThreeKeys[9]);
        whiteKeyRenderers[5].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }

    public void PlayBb3Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveThreeKeys[10]);
        blackKeyRenderers[4].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetBlackKeyColor", resetColorTimer);
    }

    public void PlayB3Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveThreeKeys[11]);
        whiteKeyRenderers[6].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }
    #endregion

    // octave 4
    #region
    public void PlayC4Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveFourKeys[0]);
        whiteKeyRenderers[7].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }

    public void PlayCSharp4Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveFourKeys[1]);
        blackKeyRenderers[5].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetBlackKeyColor", resetColorTimer);
    }

    public void PlayD4Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveFourKeys[2]);
        whiteKeyRenderers[8].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }

    public void PlayDSharp4Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveFourKeys[3]);
        blackKeyRenderers[6].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetBlackKeyColor", resetColorTimer);
    }

    public void PlayE4Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveFourKeys[4]);
        whiteKeyRenderers[9].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }

    public void PlayF4Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveFourKeys[5]);
        whiteKeyRenderers[10].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }

    public void PlayFSharp4Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveFourKeys[6]);
        blackKeyRenderers[7].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetBlackKeyColor", resetColorTimer);
    }

    public void PlayG4Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveFourKeys[7]);
        whiteKeyRenderers[11].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }

    public void PlayGSharp4Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveFourKeys[8]);
        blackKeyRenderers[8].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetBlackKeyColor", resetColorTimer);
    }

    public void PlayA4Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveFourKeys[9]);
        whiteKeyRenderers[12].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }

    public void PlayBb4Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveFourKeys[10]);
        blackKeyRenderers[9].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetBlackKeyColor", resetColorTimer);
    }

    public void PlayB4Key()
    {
        // play audio
        pianoSource.PlayOneShot(octaveFourKeys[11]);
        whiteKeyRenderers[13].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }

    #endregion

    // resets color
    #region
    public void ResetWhiteKeyColor()
    {
        for (int i = 0; i < whiteKeyRenderers.Length; ++i)
        {
            whiteKeyRenderers[i].material.color = Color.white;
        }
    }

    public void ResetBlackKeyColor()
    {
        for (int i = 0; i < blackKeyRenderers.Length; ++i)
        {
            blackKeyRenderers[i].material.color = Color.black;
        }
    }
    #endregion
}
