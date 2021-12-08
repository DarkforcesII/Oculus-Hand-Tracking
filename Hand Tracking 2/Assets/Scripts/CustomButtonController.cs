using OculusSampleFramework;
using System.Collections;
using System.Collections.Generic;
using UniOSC;
using UnityEngine;
using UnityEngine.Assertions;

public class CustomButtonController : MonoBehaviour
{
    [SerializeField] 
    private CustomAudioManager _audioManger = null;

    [SerializeField]
    private UniOSCEventDispatcherButton dispatcher;

    void Awake()
    {
        Assert.IsNotNull(_audioManger);
    }


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
        }
    }

    public void PlayNoteD3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayD3Key();
        }
    }

    public void PlayNoteDSharp3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayDSharp3Key();
        }
    }

    public void PlayNoteE3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayE3Key();
        }
    }

    public void PlayNoteF3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayF3Key();
        }
    }

    public void PlayNoteFSharp3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayFSharp3Key();
        }
    }

    public void PlayNoteG3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayG3Key();
        }
    }

    public void PlayNoteGSharp3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayGSharp3Key();
        }
    }

    public void PlayNoteA3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayA3Key();
        }
    }

    public void PlayNoteBb3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayBb3Key();
        }
    }

    public void PlayNoteB3(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayB3Key();
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
        }
    }
    public void PlayNoteCSharp4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayCSharp4Key();
        }
    }

    public void PlayNoteD4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayD4Key();
        }
    }

    public void PlayNoteDSharp4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayDSharp4Key();
        }
    }

    public void PlayNoteE4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayE4Key();
        }
    }

    public void PlayNoteF4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayF4Key();
        }
    }

    public void PlayNoteFSharp4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayFSharp4Key();
        }
    }

    public void PlayNoteG4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayG4Key();
        }
    }

    public void PlayNoteGSharp4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayGSharp4Key();
        }
    }

    public void PlayNoteA4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayA4Key();
        }
    }

    public void PlayNoteBb4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayBb4Key();
        }
    }

    public void PlayNoteB4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayB4Key();
        }
    }

    #endregion
}
