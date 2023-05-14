using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusManager : MonoBehaviour
{

    public Slider timerSlider;

    public float gametime;

    private bool stopTimer;


    // Start is called before the first frame update
    void Start()
    {
            stopTimer = false;
            timerSlider.maxValue = gametime;
            gametime = GameObject.Find("PlayerController").GetComponent<PlayerCountroller>().hp;
        //timerSlider.value - gametime;
    }

    // Update is called once per frame
    void Update()
    {
        //float time = gametime - Time.deltaTime;
        gametime -= Time.deltaTime;
        float time = gametime;



            if (time <= 0)
            {
                stopTimer = true;
            }
            if (stopTimer == false)
            {
                timerSlider.value = time;
            }

    }

}
