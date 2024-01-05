using System.Collections;
using UnityEngine;
using MixedReality.Toolkit.UX;
using System.Collections.Generic;

public class SpawnSpiderOnButtonPress : MonoBehaviour
{
    public PressableButton HeartSpiderButton;
    public PressableButton RealisticSpiderButton;
    public PressableButton ThreadSpiderButton;
    public PressableButton FeatherSpiderButton;
    public PressableButton ClothSpiderButton;
    public PressableButton CuteSpiderButton;

    public GameObject HeartSpiderPrefab;
    public GameObject RealisticSpiderPrefab;
    public GameObject ThreadSpiderPrefab;
    public GameObject FeatherSpiderPrefab;
    public GameObject ClothSpiderPrefab;
    public GameObject CuteSpiderPrefab;




    public GameObject surface; // Drag your "surface" cube object here

    public float spawnHeight = 2.0f;   // Adjust this value to set the height from the surface

    // Reference to the sliders
    public Slider sizeSlider;
    public Slider delaySlider;

    private List<GameObject> spawnedSpiders = new List<GameObject>();

    public void DisableSpiderControllers()
    {
        // Find all GameObjects with the word "spider" in their name
        GameObject[] spiderObjects = GameObject.FindGameObjectsWithTag("Spider");

        foreach (GameObject spiderObject in spiderObjects)
        {
            // Access the SpiderNPCController script on the GameObject
            SpiderNPCController spiderController = spiderObject.GetComponent<SpiderNPCController>();

            // If the script is attached, disable it
            if (spiderController != null)
            {
                spiderController.enabled = false;
                Debug.Log("Disabled SpiderNPCController on: " + spiderObject.name);
            }
            else
            {
                Debug.LogWarning("SpiderNPCController script not found on: " + spiderObject.name);
            }
        }
    }

    public void EnableSpiderControllers()
    {
        // Find all GameObjects with the word "spider" in their name
        GameObject[] spiderObjects = GameObject.FindGameObjectsWithTag("Spider");

        foreach (GameObject spiderObject in spiderObjects)
        {
            // Access the SpiderNPCController script on the GameObject
            SpiderNPCController spiderController = spiderObject.GetComponent<SpiderNPCController>();

            // If the script is attached, disable it
            if (spiderController != null)
            {
                spiderController.enabled = true;
                Debug.Log("Disabled SpiderNPCController on: " + spiderObject.name);
            }
            else
            {
                Debug.LogWarning("SpiderNPCController script not found on: " + spiderObject.name);
            }
        }
    }

    public void OnButtonPress()
    {
        float spawnDelay = delaySlider.Value;
        Invoke("InstantiateObject", spawnDelay);
    }

    public void InstantiateObject()
    {

        Debug.Log("Spider size: " + sizeSlider.Value);
        Debug.Log("Spider delay: " + delaySlider.Value);
        if (surface != null)
        {
            // Get the current position of the "surface" object
            Vector3 spawnPosition = surface.transform.position;
            Vector3 PositionCute = surface.transform.position;

            // Add the spawn height to the Y-axis
            spawnPosition.y += spawnHeight;
            PositionCute.y += 0.01f;

            // Set the spider size and delay based on slider values
            float spiderSize = sizeSlider.Value;
            float spawnDelay = delaySlider.Value;




            if (HeartSpiderButton.IsToggled == true){
                GameObject spiderInstance = Instantiate(HeartSpiderPrefab, spawnPosition, Quaternion.identity);
                spiderInstance.transform.localScale = new Vector3(spiderSize, spiderSize, spiderSize);
                spiderInstance.tag = "Spider";
                spawnedSpiders.Add(spiderInstance);
                StartCoroutine(SpawnWithDelay(spiderInstance, spawnDelay));
                SpiderNPCController spiderNPCCController = spiderInstance.GetComponent<SpiderNPCController>();
                spiderNPCCController.enabled = true;
            }
            else if(RealisticSpiderButton.IsToggled == true){
                GameObject spiderInstance = Instantiate(RealisticSpiderPrefab, spawnPosition, Quaternion.identity);
                spiderInstance.transform.localScale = new Vector3(spiderSize, spiderSize, spiderSize);
                spiderInstance.tag = "Spider";
                spawnedSpiders.Add(spiderInstance);
                StartCoroutine(SpawnWithDelay(spiderInstance, spawnDelay));
                SpiderNPCController spiderNPCCController = spiderInstance.GetComponent<SpiderNPCController>();
                spiderNPCCController.enabled = true;
            }
            else if (ThreadSpiderButton.IsToggled == true){
                GameObject spiderInstance = Instantiate(ThreadSpiderPrefab, spawnPosition, Quaternion.identity);
                spiderInstance.transform.localScale = new Vector3(spiderSize, spiderSize, spiderSize);
                spiderInstance.tag = "Spider";
                spawnedSpiders.Add(spiderInstance);
                StartCoroutine(SpawnWithDelay(spiderInstance, spawnDelay));
                SpiderNPCController spiderNPCCController = spiderInstance.GetComponent<SpiderNPCController>();
                spiderNPCCController.enabled = true;
            }
            else if (FeatherSpiderButton.IsToggled == true)
            {
                GameObject spiderInstance = Instantiate(FeatherSpiderPrefab, spawnPosition, Quaternion.identity);
                spiderInstance.transform.localScale = new Vector3(spiderSize, spiderSize, spiderSize);
                spiderInstance.tag = "Spider";
                spawnedSpiders.Add(spiderInstance);
                StartCoroutine(SpawnWithDelay(spiderInstance, spawnDelay));
                SpiderNPCController spiderNPCCController = spiderInstance.GetComponent<SpiderNPCController>();
                spiderNPCCController.enabled = true;
            }
            else if (ClothSpiderButton.IsToggled == true)
            {
 
                GameObject spiderInstance = Instantiate(ClothSpiderPrefab, spawnPosition, Quaternion.identity);
                spiderInstance.transform.localScale = new Vector3(spiderSize, spiderSize, spiderSize);
                spiderInstance.tag = "Spider";
                spawnedSpiders.Add(spiderInstance);
                StartCoroutine(SpawnWithDelay(spiderInstance, spawnDelay));
                SpiderNPCController spiderNPCCController = spiderInstance.GetComponent<SpiderNPCController>();
                spiderNPCCController.enabled = true;
            }
            else if (CuteSpiderButton.IsToggled == true)
            {
                GameObject spiderInstance = Instantiate(CuteSpiderPrefab, PositionCute, Quaternion.identity);
                spiderInstance.transform.localScale = new Vector3(spiderSize - 1, spiderSize - 1, spiderSize - 1);
                spawnedSpiders.Add(spiderInstance);
                StartCoroutine(SpawnWithDelay(spiderInstance, spawnDelay));
            }

        }
        else
        {
            Debug.LogError("Surface object not assigned!");
        }
    }

    private IEnumerator SpawnWithDelay(GameObject spiderInstance, float delay)
    {
        yield return new WaitForSeconds(delay);
        Debug.Log("Spider spawn with delay: " + delay);
    }

    public void RemoveAllSpiders()
    {
        GameObject cam1 = GameObject.Find("Spider Controller Camera");
        GameObject cam2 = GameObject.Find("Spider Spectating Camera Target");
        GameObject cam3 = GameObject.Find("Spider Spectating Camera");
        Destroy(cam1);
        Destroy(cam2);
        Destroy(cam3);
        foreach (var spider in spawnedSpiders)
        {
            if (spider != null)
            {
                Destroy(spider);
            }
        }

        // Clear the list of spawned spiders
        spawnedSpiders.Clear();
    }




}
