using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonPushOpenBlinds : MonoBehaviour
{
    public Animator animator;

    public string boolName = "Open";
    private bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => BlindsOpen());
    }

    public void BlindsOpen()
    {
        isOpen = true;
        animator.SetBool(boolName, isOpen);

    }
    
    public void OpenAnimationEnd()
    {
        isOpen = false;
        animator.SetBool(boolName, isOpen);
    }
}
