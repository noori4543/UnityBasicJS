using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Practice_Button2 : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    public string nextText = "1234";
    
    public void ChangText()
    {
        textMeshProUGUI.text = nextText;
    }


}