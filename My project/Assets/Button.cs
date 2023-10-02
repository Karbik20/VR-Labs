using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject cylinder;
    // Start is called before the first frame update
    void Start()
    {
        cylinder.GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onclick()
    {
        if (cylinder.GetComponent<Renderer>().material.color == Color.red)
        {
            cylinder.GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            cylinder.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
