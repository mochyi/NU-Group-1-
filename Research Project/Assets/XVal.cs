using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class XVal : MonoBehaviour


{

    public TextMeshProUGUI user_name;
    public TMP_InputField user_InputField;


    public void setName()
    {
        user_name.text = user_InputField.text;
    }


}

