using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FloatConverter : MonoBehaviour
{

    public string myString;

    public float myFloat;

    public 
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       if (float.TryParse(myString, out myFloat))
        {

            Debug.Log("Convert Success");

        }
       else
        {
            Debug.Log("Couldn't Be Converted");
        }

    }
}
