using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCountroller : MonoBehaviour
{

    public int level;
    public int exp;
    public int totalexp;
    public int point;
    public int attack;
    public float hp;
    public Text txtexp;
    public Text txtlv;
    public Text txtPoint;
    public Text txtAttack;
    public Text txtHP;
    // Start is called before the first frame update
    void Start()
    {
        hp = (float)60;
        level = PlayerPrefs.GetInt("level", 1);
        
        //attack = GameObject.Find("Score").GetComponent<ScoreManager>().increaseScore;
        //
        //exp = 0;
        //totalexp = 200;
        txtlv.text = string.Format("Level : {0}", level);
        txtexp.text = string.Format("Exp : {0} / {1}", exp, totalexp);
        txtAttack.text = string.Format("Attack : {0}", attack);
        txtHP.text = string.Format("Hp : {0}", hp);


        

    }

    // Update is called once per frame
    void Update()
    {

        point = PlayerPrefs.GetInt("point", 0);
        hp = PlayerPrefs.GetFloat("hp", 60);
        attack = PlayerPrefs.GetInt("Attack", 10);
        totalexp = PlayerPrefs.GetInt("totalexp", 200);
        exp = PlayerPrefs.GetInt("exp", 0);

        txtlv.text = string.Format("Level : {0}", level);
        txtexp.text = string.Format("Exp : {0} / {1}", exp, totalexp);
        txtPoint.text = string.Format("SkillPoint : {0}", point);
        txtAttack.text = string.Format("Attack : {0}", attack);
        txtHP.text = string.Format("Hp : {0}", hp);

        if (exp >= totalexp)
        {
            level++;
            
            switch (level)
            {
                case (2):
                    exp = exp-totalexp;
                    totalexp = 400;
                    point++;
                    break;
                case (3):
                    exp = exp - totalexp;
                    totalexp = 600;
                    point++;
                    break;
                case (4):
                    exp = exp - totalexp;
                    totalexp = 800;
                    point++;
                    break;
                case (5):
                    exp = exp - totalexp;
                    totalexp = 1000;
                    point++;
                    break;
                case (6):
                    exp = exp - totalexp;
                    totalexp = 1200;
                    point++;
                    break;
                case (7):
                    exp = exp - totalexp;
                    totalexp = 1400;
                    point++;
                    break;
                case (8):
                    exp = exp - totalexp;
                    totalexp = 1600;
                    point++;
                    break;
                case (9):
                    exp = exp - totalexp;
                    totalexp = 1800;
                    point++;
                    break;
            }
            if (level >= 10)
            {
                level = 10;
                exp = 0;
                totalexp = 0;
            }
        }

        PlayerPrefs.SetInt("level", level);
        PlayerPrefs.SetInt("exp", exp);
        PlayerPrefs.SetInt("point", point);
        PlayerPrefs.SetInt("totalexp", totalexp);
        PlayerPrefs.SetInt("attack", attack);
        PlayerPrefs.SetFloat("hp", hp);
        PlayerPrefs.SetInt("totalexp", totalexp);
        PlayerPrefs.Save();

    }
}
