using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCanvasSwitch : MonoBehaviour
{
    public static MainCanvasSwitch instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }


    public GameObject active;
    /*void Start()
    {
        canvas1Button.onClick.AddListener(SwitchToCanvas);
        canvas2Button.onClick.AddListener(Canvas2Activate);
        canvas3Button.onClick.AddListener(Canvas3Activate);

        Canvas1Activate();
    }*/
    public void SwitchToCanvas(GameObject newActive)
    {
        newActive.SetActive(true);
        active.SetActive(false);
        active = newActive;
        active.SetActive(true);
    }

    /*void MakeButtonBoldAndDarkenBackground(Button button)
    {

        Text buttonText = button.GetComponentInChildren<Text>();
        if (buttonText != null)
        {
            buttonText.fontStyle = FontStyle.Bold;
        }


        Image buttonImage = button.GetComponent<Image>();
        if (buttonImage != null)
        {
            buttonImage.color = new Color(1.0f, 1.0f, 0.5f, 1f);
        }
    }
    void RevertStyle(Button button)
    {

        Text buttonText = button.GetComponentInChildren<Text>();
        if (buttonText != null)
        {
            buttonText.fontStyle = FontStyle.Normal;
        }


        Image buttonImage = button.GetComponent<Image>();
        if (buttonImage != null)
        {
            buttonImage.color = new Color(0.9f, 0.9f, 1f, 1f);
        }
    }*/
}