using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveSpeed : MonoBehaviour
{
    public Slider slider;
    public Text sliderNumber;

    public string smt;
    public float sliderPog;

    public void Start()
    {
        smt = sliderNumber.text;
        sliderNumber.text = PlayerPrefs.GetString("savetext", sliderNumber.text);
        //Debug.Log(sliderNumber.text);
        slider.value = PlayerPrefs.GetFloat("saveint", sliderPog);
        //Debug.Log(slider.value);
    }

    public void SaveSlider(float value)
    {
        sliderPog = value;
        smt = sliderNumber.text;
        PlayerPrefs.SetFloat("saveint", sliderPog);
        PlayerPrefs.SetString("savetext", smt);
    }
}
