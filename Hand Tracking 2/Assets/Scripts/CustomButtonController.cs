using OculusSampleFramework;
using System.Collections;
using System.Collections.Generic;
using UniOSC;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class CustomButtonController : MonoBehaviour
{
    [SerializeField] 
    private CustomAudioManager _audioManger = null;

    [SerializeField]
    private UniOSCEventDispatcherButton dispatcher;

    [SerializeField]
    private UniOSCConnection ipConnection;

    public Text ipAddress;

    private bool limitSelection = false;

    void Awake()
    {
        Assert.IsNotNull(_audioManger);

        // makes sure that ip address is reset each time app is started
        /*
        print(ipConnection.oscOutIPAddress);
        ipConnection.oscOutIPAddress = ipAddress.text;
        print(ipConnection.oscOutIPAddress);
        */
    }

    // Numpad object methods
    #region

    // will make sure to concatenate string as more are selected
    private void ChangeText(string newString)
    {
        if (ipAddress.text == "Enter IP Address")
        {
            ipAddress.text = newString;
            //print(ipAddressList);
        }
        else
        {
            ipAddress.text += newString;
        }

        print(ipAddress.text);
    }

    // Update IP string with digit 7
    public void Add7String(InteractableStateArgs obj)
    {
        if (limitSelection == false)
        {
            limitSelection = true;

            if (obj.NewInteractableState == InteractableState.ActionState)
            {
                //ipAddressList.AddAfter()
                // update address
                ChangeText("7");
            }
            // play coroutine to reset bool
            StartCoroutine(ResetBool());
        }
    }
    public void Add8String(InteractableStateArgs obj)
    {
        if (limitSelection == false)
        {
            limitSelection = true;

            if (obj.NewInteractableState == InteractableState.ActionState)
            {
                // update address
                ChangeText("8");
            }
            // play coroutine to reset bool
            StartCoroutine(ResetBool());
        }
    }
    public void Add9String(InteractableStateArgs obj)
    {
        if (limitSelection == false)
        {
            limitSelection = true;

            if (obj.NewInteractableState == InteractableState.ActionState)
            {
                // update address
                ChangeText("9");
            }
            // play coroutine to reset bool
            StartCoroutine(ResetBool());
        }
    }
    public void Add4String(InteractableStateArgs obj)
    {
        if (limitSelection == false)
        {
            limitSelection = true;

            if (obj.NewInteractableState == InteractableState.ActionState)
            {
                // update address
                ChangeText("4");
            }
            // play coroutine to reset bool
            StartCoroutine(ResetBool());
        }
    }
    public void Add5String(InteractableStateArgs obj)
    {
        if (limitSelection == false)
        {
            limitSelection = true;

            if (obj.NewInteractableState == InteractableState.ActionState)
            {
                // update address
                ChangeText("5");
            }
            // play coroutine to reset bool
            StartCoroutine(ResetBool());
        }
    }
    public void Add6String(InteractableStateArgs obj)
    {
        if (limitSelection == false)
        {
            limitSelection = true;

            if (obj.NewInteractableState == InteractableState.ActionState)
            {
                // update address
                ChangeText("6");
            }
            // play coroutine to reset bool
            StartCoroutine(ResetBool());
        }
    }
    public void Add1String(InteractableStateArgs obj)
    {
        if (limitSelection == false)
        {
            limitSelection = true;

            if (obj.NewInteractableState == InteractableState.ActionState)
            {
                // update address
                ChangeText("1");
            }
            // play coroutine to reset bool
            StartCoroutine(ResetBool());
        }
    }
    public void Add2String(InteractableStateArgs obj)
    {
        if (limitSelection == false)
        {
            limitSelection = true;

            if (obj.NewInteractableState == InteractableState.ActionState)
            {
                // update address
                ChangeText("2");
            }
            // play coroutine to reset bool
            StartCoroutine(ResetBool());
        }
    }
    public void Add3String(InteractableStateArgs obj)
    {
        if (limitSelection == false)
        {
            limitSelection = true;
            
            if (obj.NewInteractableState == InteractableState.ActionState)
            {
                // update address
                ChangeText("3");
            }
            // play coroutine to reset bool
            StartCoroutine(ResetBool());
        }
    }
    public void AddPeriodString(InteractableStateArgs obj)
    {
        if (limitSelection == false)
        {
            limitSelection = true;

            if (obj.NewInteractableState == InteractableState.ActionState)
            {
                // update address
                ChangeText(".");
            }
            // play coroutine to reset bool
            StartCoroutine(ResetBool());
        }
    }
    public void Add0String(InteractableStateArgs obj)
    {
        if (limitSelection == false)
        {
            limitSelection = true;

            if (obj.NewInteractableState == InteractableState.ActionState)
            {
                // update address
                ChangeText("0");
            }
            // play coroutine to reset bool
            StartCoroutine(ResetBool());
        }
    }

    public void ClearText(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            // update address
            ipAddress.text = "";
            ipConnection.oscOutIPAddress = ipAddress.text;
        }
    }

    // Update IP Address to accurately reflect phone address
    public void EnterIPAddress(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            // update address
            ipConnection.oscOutIPAddress = ipAddress.text;
        }
    }

    #endregion


    // coroutine to reset bool and limit selection
    #region
    private IEnumerator ResetBool()
    {
        yield return new WaitForSeconds(1);
        limitSelection = false;
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
