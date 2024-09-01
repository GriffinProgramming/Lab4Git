using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GameObject;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update
    public Renderer rend;
    private int counter;
    private int randomNum;
    void Start()
    {
        counter = 3;
        randomNum = Random.Range(150, 251);

    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        Debug.Log(name +":" + counter);
        if (counter == 101)
        {
            FindWithTag("Red").SetActive(false);
        }
        if (counter == randomNum)
        {
            FindWithTag("Blue").GetComponent<Renderer>().enabled = false; 
        }
    }
}
