using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar2 : MonoBehaviour
{

    private Slider slider;

    public float fillSpeed = 0.5f;
    private float targetProgress = 0;

    public GameObject texto;
    public Text txt;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();

        //texto.SetActive(false);
        txt = texto.GetComponent<Text>();
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

        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            Increment(0.1f);
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Substract(0.1f);
        }

        txt.text = (Mathf.Round(slider.value * 100)).ToString();

    }

    public void Increment(float valorInc)
    {
        targetProgress = slider.value + valorInc;
    }

    public void Substract(float valorSub)
    {
        targetProgress = slider.value - valorSub;
    }

    IEnumerator MostrarTexto()
    {


        yield return new WaitForSeconds(1.0f);
    }
}

