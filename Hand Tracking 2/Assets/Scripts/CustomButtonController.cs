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

    private LinkedList<string> addressList;
    private string[] stringArray = { ""};
    private string linkedString;

    private string fillerText = "";

    public InputField textField;

    void Awake()
    {
        Assert.IsNotNull(_audioManger);

        // makes sure that ip address is reset each time app is started
        /*
        print(ipConnection.oscOutIPAddress);
        ipConnection.oscOutIPAddress = ipAddress.text;
        print(ipConnection.oscOutIPAddress);
        */

        //addressList = new LinkedList<string>(stringArray);
    }

    private void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            addressList.AddLast("7");
            //ChangeText();
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            addressList.AddLast("8");
            //ChangeText();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            addressList.RemoveLast();

            foreach (string str in addressList)
            {
                print(str);
                linkedString += str;
            }
            //print(linkedString);
            ipAddress.text = linkedString;
            print("it worked");
            //RemoveLastDigit();
            //print(linkedString);
        }*/

        if (Input.GetKeyDown(KeyCode.H))
        {
            ipConnection.oscOutIPAddress = textField.text;
            ipConnection.ConnectOSCOut();
            print(ipConnection.oscOutIPAddress);
            //ipConnection.oscOutIPAddress = ipAddress.text;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            dispatcher.SendOSCMessageDown();
        }
    }

    // Numpad object methods
    #region

    // will make sure to concatenate string as more are selected
    private void ChangeText(string newString)
    {
        if (ipAddress.text == "Enter IP Address" || ipAddress.text == fillerText)
        {
            ipAddress.text = newString;
            //addressList.RemoveFirst();

            /*
            foreach (string str in addressList)
            {
                linkedString += str;
            }*/
            //ipAddress.text = linkedString;
            //print(ipAddressList);
        }
        else
        {
            //addressList.RemoveFirst();
            ipAddress.text += newString;

            /*
            foreach (string str in addressList)
            {
                linkedString += str;
            }
            ipAddress.text = linkedString;*/
        }

        //print(linkedString);
    }

    private void RemoveLastDigit()
    {
        {
            /*
            addressList.Clear();

            foreach (string str in addressList)
            {
                linkedString += str;
            }
            print(linkedString);
            ipAddress.text = linkedString;
            print("it worked");*/

            ipAddress.text = fillerText;
        }
    }

    // Update IP string with digit 7
    public void Add7String(InteractableStateArgs obj)
    {
        if (limitSelection == false)
        {
            limitSelection = true;

            if (obj.NewInteractableState == InteractableState.ActionState)
            {
                // update address
                //addressList.AddLast("7");
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
                //addressList.AddLast("8");
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
                //addressList.AddLast("9");
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
                //addressList.AddLast("4");
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
                //addressList.AddLast("5");
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
                //addressList.AddLast("6");
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
                //addressList.AddLast("1");
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
                //addressList.AddLast("2");
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
                //addressList.AddLast("3");
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
                //addressList.AddLast(".");
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
                //addressList.AddLast("0");
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
            RemoveLastDigit();
        }
    }

    // Update IP Address to accurately reflect phone address
    public void EnterIPAddress(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
            // update address
            ipConnection.oscOutIPAddress = ipAddress.text;
            ipConnection.ConnectOSCOut();
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
