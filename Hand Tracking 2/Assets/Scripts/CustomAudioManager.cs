using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomAudioManager : MonoBehaviour
{
    private AudioSource soundSource;
    public AudioClip[] pianoKeys;
    //public GameObject[] keyObjects;

    // color
    public Renderer[] whiteKeyRenderers;
    public Renderer[] blackKeyRenderers;
    public float resetColorTimer = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        // key sounds
        soundSource = GetComponent<AudioSource>();
    }

    public void PlayCKey()
    {
        // play audio
        soundSource.PlayOneShot(pianoKeys[0]);
        whiteKeyRenderers[0].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }

    public void PlayCSharpKey()
    {
        // play audio
        soundSource.PlayOneShot(pianoKeys[1]);
        blackKeyRenderers[0].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetBlackKeyColor", resetColorTimer);
    }

    public void PlayDKey()
    {
        // play audio
        soundSource.PlayOneShot(pianoKeys[2]);
        whiteKeyRenderers[1].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }

    public void PlayDSharpKey()
    {
        // play audio
        soundSource.PlayOneShot(pianoKeys[3]);
        blackKeyRenderers[1].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetBlackKeyColor", resetColorTimer);
    }

    public void PlayEKey()
    {
        // play audio
        soundSource.PlayOneShot(pianoKeys[4]);
        whiteKeyRenderers[2].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }

    public void PlayFKey()
    {
        // play audio
        soundSource.PlayOneShot(pianoKeys[5]);
        whiteKeyRenderers[3].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }

    public void PlayFSharpKey()
    {
        // play audio
        soundSource.PlayOneShot(pianoKeys[6]);
        blackKeyRenderers[2].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetBlackKeyColor", resetColorTimer);
    }

    public void PlayGKey()
    {
        // play audio
        soundSource.PlayOneShot(pianoKeys[7]);
        whiteKeyRenderers[4].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }

    public void PlayGSharpKey()
    {
        // play audio
        soundSource.PlayOneShot(pianoKeys[8]);
        blackKeyRenderers[3].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetBlackKeyColor", resetColorTimer);
    }

    public void PlayAKey()
    {
        // play audio
        soundSource.PlayOneShot(pianoKeys[9]);
        whiteKeyRenderers[5].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }

    public void PlayBbKey()
    {
        // play audio
        soundSource.PlayOneShot(pianoKeys[10]);
        blackKeyRenderers[4].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetBlackKeyColor", resetColorTimer);
    }

    public void PlayBKey()
    {
        // play audio
        soundSource.PlayOneShot(pianoKeys[11]);
        whiteKeyRenderers[6].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }

    public void PlayC4Key()
    {
        // play audio
        soundSource.pitch = 2;
        soundSource.PlayOneShot(pianoKeys[12]);
        whiteKeyRenderers[7].material.color = Color.red;
        print("it played");
        // play coroutine
        Invoke("ResetWhiteKeyColor", resetColorTimer);
    }

    public void ResetWhiteKeyColor()
    {
        for (int i = 0; i < whiteKeyRenderers.Length; ++i)
        {
            soundSource.pitch = 1;
            whiteKeyRenderers[i].material.color = Color.white;
        }
    }

    public void ResetBlackKeyColor()
    {
        for (int i = 0; i < blackKeyRenderers.Length; ++i)
        {
            soundSource.pitch = 1;
            blackKeyRenderers[i].material.color = Color.black;
        }
    }
}
