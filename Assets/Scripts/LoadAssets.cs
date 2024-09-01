using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    
    /*
     * Create a private GameObject member variable called blueObj of the LoadAssets class but
       make it available to the Inspector View (tip: search SerializeField in Unity Docs).
       • Open the LoadAssets script again. When the game starts, the LoadAssets component
       should create a redObj at (2,0,0) and a rotation of zero and a blueObj at (-2,0,0) and a
       rotation of zero (tip: search Instantiate, Vector3, and Quaternion.identity in Unity Docs).
       • Save the script, assign BluePrefab to blueObj on the LoadManager game object, and press
       play in Unity to see the results.
     */
    public GameObject redObj;

    [SerializeField] private GameObject blueObj;
    // Start is called before the first frame update
    void Start()
    {
        // Limit framerate to cinematic 24fps.
        QualitySettings.vSyncCount = 0; // Set vSyncCount to 0 so that using .targetFrameRate is enabled.
        Application.targetFrameRate = 60;
        
        Instantiate(blueObj, new Vector3(-2f,0f,0f), new Quaternion(0f,0f,0f, 0f));
        Instantiate(redObj, new Vector3(2f,0f,0f), new Quaternion(0f,0f,0f, 0f));
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
