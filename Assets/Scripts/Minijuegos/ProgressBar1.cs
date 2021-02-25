using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar1 : MonoBehaviour
{

    private Slider slider;

    public float fillSpeed = 0.5f;
    public float targetProgress = 0;

    public GameObject texto;
    public Text txt;

    public ParticleSystem ps;

    private bool mitad;
    private bool tresC;


    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        
        //texto.SetActive(false);
        txt = texto.GetComponent<Text>();

        mitad = false;
        tresC = false;
    }


    // Start is called before the first frame update
    void Start()
    {
        //Increment(0.75f);
    }

    // Update is called once per frame
    void FixedUpdate()
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
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            Increment(0.05f);
        }

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Substract(0.1f);
        }
        txt.text = (Mathf.Round(slider.value * 100)/10).ToString();

        if (slider.value >= 0.5 && !mitad)
        {
            //ps.Play();
            mitad = true;
        }
        
        if (slider.value < 0.5 && mitad)
        {
            mitad = false;
        }

        if (slider.value >= 0.75 && !tresC)
        {
            //ps.Play();
            tresC = true;
        }

        if (slider.value < 0.75 && tresC)
        {
            tresC = false;
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