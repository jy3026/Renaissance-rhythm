using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    [SerializeField]
    UnityEngine.UI.Text txtScore = null;

    public int increaseScore = 10;

    public int currentScore = 0;

    [SerializeField]
    float[] weight = null;

    [SerializeField]
    int comboBonusScore = 10;

    Animator myAnim;
    string animScoreUp = "ScoreUp";

    ComboManager theCombo;

    public int t_increaseScore = 0;

    // Start is called before the first frame update


    void Start()
    {
        theCombo = FindObjectOfType<ComboManager>();
        myAnim = GetComponent<Animator>();
        currentScore = 0;
        txtScore.text = "0";
        increaseScore = PlayerPrefs.GetInt("Attack", 10);
        //enemyHP = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void IncreaseScore(int p_JudgementState)
    {
        theCombo.IncreaseCombo();

        int t_currentCombo = theCombo.GetCurrentCombo();
        int t_bonusComboScore = (t_currentCombo / 10) * comboBonusScore;

        t_increaseScore = increaseScore + t_bonusComboScore;

        t_increaseScore = (int)(t_increaseScore * weight[p_JudgementState]);

        currentScore += t_increaseScore;
        txtScore.text = string.Format("{0:#,##0}", currentScore);


        myAnim.SetTrigger(animScoreUp);


    }

    public int GetCurrentScore()
    {
        return currentScore;
    }


}
