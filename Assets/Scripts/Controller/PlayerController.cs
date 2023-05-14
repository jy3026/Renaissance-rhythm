using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    TimingManager theTimingManager;
    Hp hpManager;

    // Start is called before the first frame update
    void Start()
    {
        theTimingManager = FindObjectOfType<TimingManager>();
        hpManager = FindObjectOfType<Hp>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.isStartGame)
        { 
            if (Input.GetKeyDown(KeyCode.Space))
            {
                theTimingManager.CheckTiming();
                hpManager.damage();
            }
        }

    }
}
