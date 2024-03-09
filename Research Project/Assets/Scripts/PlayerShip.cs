using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using TMPro;
using UnityEngine.Internal;
using UnityEngine.Playables;

public class TMPFieldParser : MonoBehaviour
{
    public TMP_InputField inputField; // Reference to the TMP InputField
    public GameObject PlayerShip; // Reference to the GameObject to transform

    public void ParseTMPFieldAndTransformVector()
    {
        string textValue = inputField.text;

        float floatValue;
        if (float.TryParse(textValue, out floatValue))
        {   
            // Parsing successful, transform the vector of the GameObject
            Vector3 newPosition = PlayerShip.transform.position;
            newPosition.x = floatValue; // Assuming you want to change the x coordinate
            PlayerShip.transform.position = newPosition;
        }
        else
        {
            // Parsing failed, handle the error accordingly
            Debug.LogError("Failed to parse float value from TMP field.");
        }
    }
}
