using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar1 : MonoBehaviour
{

    private Slider slider;

    public float fillSpeed = 0.5f;
    private float targetProgress = 0;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }


    // Start is called before the first frame update
    void Start()
    {
        //Increment(0.75f);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < targetProgress)
        {
            slider.value += fillSpeed * Time.deltaTime;
        }
        if (slider.value > targetProgress)
        {
            slider.value -= fillSpeed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            Increment(0.1f);
        }

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Substract(0.1f);
        }
    }

    public void Increment (float valorInc)
    {
        targetProgress = slider.value + valorInc;
    }

    public void Substract(float valorSub)
    {
        targetProgress = slider.value - valorSub;
    }


}