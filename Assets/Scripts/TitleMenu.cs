using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    [SerializeField]
    GameObject goStageUI = null;
    [SerializeField]
    GameObject goMenu = null;
    [SerializeField]
    GameObject goStage1 = null;
    [SerializeField]
    GameObject goStage2 = null;
    [SerializeField]
    GameObject goStage3 = null;
    [SerializeField]
    GameObject goStage4 = null;
    [SerializeField]
    GameObject goStage5 = null;

    int exp;
    int total;

    void Start()
    {
        total = PlayerPrefs.GetInt("exp", 0);
    }

    public void BtnPlay()
    {
        goStageUI.SetActive(true);
        
        this.gameObject.SetActive(false);
    }

    public void BtnMenu()
    {

        exp = GameObject.Find("Result").GetComponent<Result>().t_exp;
        total += exp;
        Debug.Log(exp);
        Debug.Log(total);
        PlayerPrefs.SetInt("exp", total);
        PlayerPrefs.Save();
        goMenu.SetActive(true);
        goStage1.SetActive(false);
        goStage2.SetActive(false);
        goStage3.SetActive(false);
        goStage4.SetActive(false);
        goStage5.SetActive(false);
        this.gameObject.SetActive(false);
        //GameManager.instance.GameStart();
        //SceneManager.LoadScene("Menu");

    }
}
