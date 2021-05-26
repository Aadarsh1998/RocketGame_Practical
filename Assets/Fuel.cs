using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fuel : MonoBehaviour
{
    public float fuel = 100f;
    public Text timeText; 

    private void Update()
    {
        timeText.text = Mathf.RoundToInt(fuel).ToString();
    }
}
