using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slidervalue : MonoBehaviour
{

    public Text percentageText;

    // Start is called before the first frame update
    void Start()
    {
        percentageText = GetComponent<Text>();
    }

    // Update is called once per frame
    public void textUpdate(float value)
    {
        percentageText.text = Mathf.RoundToInt(value).ToString();
    }
}
