using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{

    public int point;
    public float Hp;
    public int Attack;


    // Start is called before the first frame update
    void Start()
    {
        //point = PlayerPrefs.GetInt("point", 0);
        //Hp = PlayerPrefs.GetFloat("hp", 0);
        point = GameObject.Find("PlayerController").GetComponent<PlayerCountroller>().point;
        Hp = GameObject.Find("PlayerController").GetComponent<PlayerCountroller>().hp;
        Attack = GameObject.Find("PlayerController").GetComponent<PlayerCountroller>().attack;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Timebuy()
    {
        if(point == 0)
        {
            Debug.Log("구매불가");
        }
        if (point >= 1)
        {
            Hp += 5;

            point--;

            PlayerPrefs.SetInt("point", point);
            PlayerPrefs.SetFloat("hp", Hp);
            PlayerPrefs.Save();
        }

       
    }

    public void Attackbuy()
    {
        if (point == 0)
        {
            Debug.Log("구매불가");
        }
        if (point >= 1)
        {
            Attack += 5;

            point--;

            PlayerPrefs.SetInt("point", point);
            PlayerPrefs.SetInt("Attack", Attack);
            PlayerPrefs.Save();
        }


    }
}
