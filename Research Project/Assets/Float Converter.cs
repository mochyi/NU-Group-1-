using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FloatConverter : MonoBehaviour
{

    public string myString;

    public float myFloat;

    


    
    public void whenButtonClicked()
    {
        float.TryParse(myString, out myFloat);
    }
    








}
