using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using OculusSampleFramework;

public class CustomUIController : MonoBehaviour
{
    private bool limitSelection = false;

    public Transform piano;

    [SerializeField]
    private float scale;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            piano.localScale *= scale;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            piano.localScale /= scale;
        }
    }

    public void IncreasePianoScale(InteractableStateArgs obj)
    {
        if (limitSelection == false)
        {
            limitSelection = true;

            if (obj.NewInteractableState == InteractableState.ActionState)
            {
                piano.localScale *= scale;

                // play coroutine to reset bool
                StartCoroutine(ResetBool());
            }
        }
    }

    public void DecreasePianoScale(InteractableStateArgs obj)
    {
        if (limitSelection == false)
        {
            limitSelection = true;

            if (obj.NewInteractableState == InteractableState.ActionState)
            {
                piano.localScale /= scale;

                // play coroutine to reset bool
                StartCoroutine(ResetBool());
            }
        }
    }

    private IEnumerator ResetBool()
    {
        yield return new WaitForSeconds(1);
        limitSelection = false;
    }
}
