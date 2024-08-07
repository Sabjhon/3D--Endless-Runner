using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollatableControl : MonoBehaviour
{
    public static int coinCount;
    public TMP_Text coinCountDisplay; 
    public TMP_Text coinEndDisplay; 

    void Update()
    {
        coinCountDisplay.GetComponent<TMP_Text>().text = "" +coinCount; 
        coinEndDisplay.GetComponent<TMP_Text>().text = "" +coinCount; 
    }
}
