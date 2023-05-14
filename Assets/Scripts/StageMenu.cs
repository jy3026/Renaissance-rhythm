using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageMenu : MonoBehaviour
{

    [SerializeField]
    GameObject TitleMenu = null;

    [SerializeField]
    GameObject[] Song = null;

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

    public GameObject before;
    public GameObject next;

    public GameObject store;
    int select = 0;

    void Update()
    {

    }


    public void BtnBack()
    {
        TitleMenu.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void BtnPlay1()
    {
        goStage1.SetActive(true);
        this.gameObject.SetActive(false);
        //SceneManager.LoadScene("Stage");
        Time.timeScale = 1;
        GameManager.instance.GameStart();
    }

    public void BtnPlay2()
    {
        goStage2.SetActive(true);
        this.gameObject.SetActive(false);
        //SceneManager.LoadScene("Stage");
        Time.timeScale = 1;
        GameManager.instance.GameStart();
    }

    public void BtnPlay3()
    {
        goStage3.SetActive(true);
        this.gameObject.SetActive(false);
        //SceneManager.LoadScene("Stage");
        Time.timeScale = 1;
        GameManager.instance.GameStart();
    }


    public void BtnPlay4()
    {
        goStage4.SetActive(true);
        this.gameObject.SetActive(false);
        //SceneManager.LoadScene("Stage");
        Time.timeScale = 1;
        GameManager.instance.GameStart();
    }

    public void BtnPlay5()
    {
        goStage5.SetActive(true);
        this.gameObject.SetActive(false);
        //SceneManager.LoadScene("Stage");
        Time.timeScale = 1;
        GameManager.instance.GameStart();
    }

    public void BtnStage()
    {


        /*for (int i = 0; i < Song.Length; i++)
        {
            if(i == 0){
                Song[0].SetActive(false);
            }
            else
            {
                before.SetActive(true);
                Song[i - 1].SetActive(false);
                Song[i].SetActive(true);
            }
            
        }*/

        if (select == 0)
        {
            Song[0].SetActive(false);
            Song[1].SetActive(true);
            before.SetActive(true);
            select++;
        }
        else
        {
            before.SetActive(true);
            Song[select].SetActive(false);
            Song[select+1].SetActive(true);
            select++;

            if(select == 4)
            {
                next.SetActive(false);
            }
        }

    }

    public void BtnBackStage()
    {


        /*for (int i = 0; i < Song.Length; i++)
        {
            if (i == 0)
            {
                Song[0].SetActive(true);
            }
            else
            {
                before.SetActive(false);
                Song[i - 1].SetActive(true);
                Song[i].SetActive(false);
            }

        }*/
        if (select == 1)
        {
            Song[0].SetActive(true);
            Song[1].SetActive(false);
            before.SetActive(false);
            select--;
        }
        else
        {
            before.SetActive(true);
            Song[select].SetActive(false);
            Song[select -1].SetActive(true);
            next.SetActive(true);
            select--;
        }
    }

    public void goStore()
    {

        store.SetActive(true);

    }
    public void backStore()
    {

        store.SetActive(false);

    }
}
