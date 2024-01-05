using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBox : MonoBehaviour
{
    public GameObject CardboardBox;
    public GameObject surface;
    public void CreateBoxClick()
    {
        if (surface != null)
        {
            // Get the current position of the "surface" object
            Vector3 spawnPosition = surface.transform.position;
            Vector3 PositionCute = surface.transform.position;

            // Add the spawn height to the Y-axis
            spawnPosition.y += 0.01f;
            GameObject box = Instantiate(CardboardBox, spawnPosition, Quaternion.identity);
            box.tag = "Box";
        }
    }

    public void RemoveBox()
    {
        GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");
        foreach (GameObject box in boxes)
        {
            Destroy(box);
        }
    }
}
