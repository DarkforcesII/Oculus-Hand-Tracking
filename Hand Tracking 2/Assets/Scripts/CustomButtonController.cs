using OculusSampleFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class CustomButtonController : MonoBehaviour
{
    [SerializeField] private CustomAudioManager _audioManger = null;

    void Awake()
    {
        Assert.IsNotNull(_audioManger);
    }

    public void PlayNoteC(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayCKey();
        }
    }
    public void PlayNoteCSharp(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayCSharpKey();
        }
    }

    public void PlayNoteD(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayDKey();
        }
    }

    public void PlayNoteDSharp(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayDSharpKey();
        }
    }

    public void PlayNoteE(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayEKey();
        }
    }

    public void PlayNoteF(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayFKey();
        }
    }

    public void PlayNoteFSharp(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayFSharpKey();
        }
    }

    public void PlayNoteG(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayGKey();
        }
    }

    public void PlayNoteGSharp(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayGSharpKey();
        }
    }

    public void PlayNoteA(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayAKey();
        }
    }

    public void PlayNoteBb(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayBbKey();
        }
    }

    public void PlayNoteB(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayBKey();
        }
    }

    public void PlayNoteC4(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            _audioManger.PlayC4Key();
        }
    }
}
