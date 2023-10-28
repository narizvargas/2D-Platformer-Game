using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Slider : MonoBehaviour
{
    public TextMeshProUGUI numberText;
    private Slider slider;
    private readonly float val;

    void Start()
    {
        slider = GetComponent<Slider>();
        SetNumberText(slider.val);
    }
    public void SetNumberText(float value)
    {
        numberText.text = value.ToString();
    }
}
