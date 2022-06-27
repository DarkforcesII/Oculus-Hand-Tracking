using OculusSampleFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
using UniOSC;
using System;

public class CustomPianoController : MonoBehaviour
{
    [SerializeField] 
    private CustomAudioManager _audioManger = null;

    private bool limitSelection = false;

    [SerializeField]
    private UniOSCEventDispatcherButton dispatcher;

    [SerializeField]
    private AudioSource pianoSource;

    [SerializeField]
    private AudioClip[] noteClips;

    // color

    public Renderer[] keysRenderer;

    void Awake()
    {
        Assert.IsNotNull(_audioManger);
        DataManager.Instance.PrintToScreen();
    }

    // coroutine to reset bool and limit selection
    #region
    private IEnumerator ResetBool()
    {
        yield return new WaitForSeconds(1);
        limitSelection = false;
    }
    #endregion

    public void PlayNote(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            FindPianoKey();
            dispatcher.SendOSCMessageDown();
            Octave3Keys();
            Octave4Keys();
            pianoSource.PlayOneShot(noteClips[DataManager.Instance.keyCounter]);
        }
    }

    private void Octave3Keys()
    {
        switch (DataManager.Instance.keyCounter)
        {
            case 0: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetWhiteKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 1: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetBlackKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 2: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetWhiteKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 3: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetBlackKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 4: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetWhiteKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 5: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetWhiteKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 6: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetBlackKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 7: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetWhiteKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 8: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetBlackKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 9: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetWhiteKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 10: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetBlackKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 11: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetWhiteKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
        }
    }

    private void Octave4Keys()
    {
        switch (DataManager.Instance.keyCounter)
        {
            case 12: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetWhiteKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 13: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetBlackKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 14: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetWhiteKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 15: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetBlackKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 16: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetWhiteKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 17: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetWhiteKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 18: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetBlackKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 19: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetWhiteKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 20: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetBlackKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 21: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetWhiteKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 22: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetBlackKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
            case 23: keysRenderer[DataManager.Instance.keyCounter].material.color = Color.red; Invoke("ResetWhiteKeyColor", noteClips[DataManager.Instance.keyCounter].length); break;
        }
    }

    private void FindPianoKey()
    {
        Debug.Log(DataManager.Instance.keyCounter);
    }

    // resets color
    #region
    public void ResetWhiteKeyColor()
    {
        keysRenderer[0].material.color = Color.white;
        keysRenderer[2].material.color = Color.white;
        keysRenderer[4].material.color = Color.white;
        keysRenderer[5].material.color = Color.white;
        keysRenderer[7].material.color = Color.white;
        keysRenderer[9].material.color = Color.white;
        keysRenderer[11].material.color = Color.white;
        keysRenderer[12].material.color = Color.white;
        keysRenderer[14].material.color = Color.white;
        keysRenderer[16].material.color = Color.white;
        keysRenderer[17].material.color = Color.white;
        keysRenderer[19].material.color = Color.white;
        keysRenderer[21].material.color = Color.white;
        keysRenderer[23].material.color = Color.white;
    }

    public void ResetBlackKeyColor()
    {
        keysRenderer[1].material.color = Color.black;
        keysRenderer[3].material.color = Color.black;
        keysRenderer[6].material.color = Color.black;
        keysRenderer[8].material.color = Color.black;
        keysRenderer[10].material.color = Color.black;
        keysRenderer[13].material.color = Color.black;
        keysRenderer[15].material.color = Color.black;
        keysRenderer[18].material.color = Color.black;
        keysRenderer[20].material.color = Color.black;
        keysRenderer[22].material.color = Color.black;

    }
    #endregion

    // octave 3
    #region
    public void PlayNoteC3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayC3Key();
            dispatcher.SendOSCMessageDown();
        }
    }
    public void PlayNoteCSharp3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayCSharp3Key();
            dispatcher.SendOSCMessageDown();
        }
    }

    public void PlayNoteD3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayD3Key();
            dispatcher.SendOSCMessageDown();
        }
    }

    public void PlayNoteDSharp3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayDSharp3Key();
            dispatcher.SendOSCMessageDown();
        }
    }

    public void PlayNoteE3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayE3Key();
            dispatcher.SendOSCMessageDown();
        }
    }

    public void PlayNoteF3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayF3Key();
            dispatcher.SendOSCMessageDown();
        }
    }

    public void PlayNoteFSharp3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayFSharp3Key();
            dispatcher.SendOSCMessageDown();
        }
    }

    public void PlayNoteG3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayG3Key();
            dispatcher.SendOSCMessageDown();
        }
    }

    public void PlayNoteGSharp3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayGSharp3Key();
            dispatcher.SendOSCMessageDown();
        }
    }

    public void PlayNoteA3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayA3Key();
            dispatcher.SendOSCMessageDown();
        }
    }

    public void PlayNoteBb3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayBb3Key();
            dispatcher.SendOSCMessageDown();
        }
    }

    public void PlayNoteB3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayB3Key();
            dispatcher.SendOSCMessageDown();
        }
    }
    #endregion

    // octave 4
    #region
    public void PlayNoteC4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayC4Key();
            dispatcher.SendOSCMessageDown();
        }
    }
    public void PlayNoteCSharp4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayCSharp4Key();
            dispatcher.SendOSCMessageDown();
        }
    }

    public void PlayNoteD4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayD4Key();
            dispatcher.SendOSCMessageDown();
        }
    }

    public void PlayNoteDSharp4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayDSharp4Key();
            dispatcher.SendOSCMessageDown();
        }
    }

    public void PlayNoteE4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayE4Key();
            dispatcher.SendOSCMessageDown();
        }
    }

    public void PlayNoteF4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayF4Key();
            dispatcher.SendOSCMessageDown();
        }
    }

    public void PlayNoteFSharp4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayFSharp4Key();
            dispatcher.SendOSCMessageDown();
        }
    }

    public void PlayNoteG4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayG4Key();
            dispatcher.SendOSCMessageDown();
        }
    }

    public void PlayNoteGSharp4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayGSharp4Key();
            dispatcher.SendOSCMessageDown();
        }
    }

    public void PlayNoteA4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayA4Key();
            dispatcher.SendOSCMessageDown();
        }
    }

    public void PlayNoteBb4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayBb4Key();
            dispatcher.SendOSCMessageDown();
        }
    }

    public void PlayNoteB4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayB4Key();
            dispatcher.SendOSCMessageDown();
        }
    }

    #endregion
}
