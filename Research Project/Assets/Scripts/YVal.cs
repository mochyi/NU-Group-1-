using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YVal : MonoBehaviour


{

    public TextMeshProUGUI user_name;
    public TMP_InputField user_YVal;


    public void setName()
    {
        user_name.text = user_YVal.text;
    }


}