using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonPushCloseBlinds : MonoBehaviour
{
    public Animator animator;

    public string boolName = "Close";
    private bool isClose = false;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => BlindsClose());
    }

    public void BlindsClose()
    {
        isClose = true;
        animator.SetBool(boolName, isClose);
    }
    public void CloseAnimationEnd()
    {
        isClose = false;
        animator.SetBool(boolName, isClose);
    }
}
