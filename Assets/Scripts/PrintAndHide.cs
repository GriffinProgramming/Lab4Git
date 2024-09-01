using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update
    public Renderer rend;
    private int counter;
    void Start()
    {
        counter = 3;
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        Debug.Log(name +":" + counter);

    }
}
