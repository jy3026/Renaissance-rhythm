using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hp : MonoBehaviour
{

    public Slider enemyHP;

    int theScoreManager;
    public int hp;
    public int maxhp;

    Result theResult;

    // Start is called before the first frame update
    void Start()
    {
        enemyHP = GetComponent<Slider>();
        theResult = FindObjectOfType<Result>();

    }
    void Update()
    {
        enemyHP.value = (float)hp / maxhp;
        theScoreManager = GameObject.Find("Score").GetComponent<ScoreManager>().t_increaseScore;

        if(enemyHP.value <= 0)
        {
            theResult.ShowResult();
            Time.timeScale = 0;
            //GameManager.instance.GameStart();
        }
    }
    // Update is called once per frame
    public void damage()
    {
        Debug.Log(theScoreManager);
        hp = hp - theScoreManager;
        //enemyHP.value -= (float)theScoreManager /100; 
    }
}
