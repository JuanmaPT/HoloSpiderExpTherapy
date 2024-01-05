using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowElementsOnButtonClick : MonoBehaviour
{
    public GameObject[] sceneElements;
    public GameObject[] UIexposure;
    private void Start()
    {
        // Disable all scene elements initially
        foreach (var element in sceneElements)
        {
            element.SetActive(false);
        }
    }

    public void OnOkButtonClick()
    {
        // Enable all scene elements when the OK button is clicked
        foreach (var element in sceneElements)
        {
            element.SetActive(true);
        }
    }

    public void DisableUI()
    {
        // Enable all scene elements when the OK button is clicked
        foreach (var element in UIexposure)
        {
            element.SetActive(false);
        }

    }

    public void EnableUI()
    {
        // Enable all scene elements when the OK button is clicked
        foreach (var element in sceneElements)
        {
            element.SetActive(true);
        }

    }

}
