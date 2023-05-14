using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    [SerializeField]
    GameObject goUI = null;

    [SerializeField]
    Text[] txtCount = null;

    [SerializeField]
    Text txtMaxCombo = null;

    [SerializeField]
    Text txtexp = null;

    ScoreManager theScore;
    ComboManager theCombo;
    TimingManager theTiming;

    int exp;
    public int t_exp;

    // Start is called before the first frame update
    void Start()
    {
        
        theScore = FindObjectOfType<ScoreManager>();
        theCombo = FindObjectOfType<ComboManager>();
        theTiming = FindObjectOfType<TimingManager>();
        //exp = PlayerPrefs.GetInt("exp", 0);

    }

    public void ShowResult()
    {
        goUI.SetActive(true);

        for (int i = 0; i < txtCount.Length; i++)
            txtCount[i].text = "0";

        txtMaxCombo.text = "0";
        txtexp.text = "0";

        int[] t_judgement = theTiming.GetJudgementRecord();
        int t_currentScore = theScore.GetCurrentScore();
        int t_maxCombo = theCombo.GetMaxCombo();
        t_exp = (t_currentScore / 10);


        for (int i =0; i < txtCount.Length; i++)
        {
            txtCount[i].text = string.Format("{0:#,##0}", t_judgement[i]);
        }

        txtMaxCombo.text = string.Format("{0:#,##0}", t_maxCombo);
        txtexp.text = string.Format("{0:#,##0}", t_exp);
        exp += t_exp;


        //PlayerPrefs.SetInt("exp", exp);
        PlayerPrefs.Save();

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
