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
