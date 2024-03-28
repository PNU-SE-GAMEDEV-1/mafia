using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CanvasSwitcher : MonoBehaviour
{
    private Button thisButton;
    public GameObject target;
    // public TMP_InputField input;
    void Start()
    {
        thisButton = GetComponent<Button>();
        if (thisButton != null )
        {
            thisButton.onClick.AddListener(SwitchToTarget);
        }
        else
        {
            Debug.Log("CanvasSwitcher Object isn't a button at Script attached to: " + gameObject.name + " at position: " + gameObject.transform.position);
        }
    }

    // Update is called once per frame
    private void SwitchToTarget()
    {
        MainCanvasSwitch.instance.SwitchToCanvas(target);
    }
}
