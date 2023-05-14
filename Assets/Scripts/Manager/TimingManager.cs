using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimingManager : MonoBehaviour
{

    public List<GameObject> boxNoteList = new List<GameObject>();

    int[] judgemnetRecord = new int[5];

    [SerializeField] Transform Center = null;
    [SerializeField] RectTransform[] timingRect = null;
    Vector2[] timingBoxs = null;

    EffectManager theEffect;
    ScoreManager theScoreManager;
    ComboManager theComboManager;


    // Start is called before the first frame update
    void Start()
    {
        theEffect = FindObjectOfType<EffectManager>();
        theScoreManager = FindObjectOfType<ScoreManager>();
        theComboManager = FindObjectOfType<ComboManager>();

        timingBoxs = new Vector2[timingRect.Length];

        for (int i = 0; i < timingRect.Length; i++)
        {
            timingBoxs[i].Set(Center.localPosition.x - timingRect[i].rect.width / 2,
                              Center.localPosition.x + timingRect[i].rect.width / 2);
        }
    }

    public void CheckTiming()
    {
        for(int i = 0; i < boxNoteList.Count; i++)
        {
            float t_notePosX = boxNoteList[i].transform.localPosition.x;

            for (int x = 0; x < timingBoxs.Length; x++)
            {
                if(timingBoxs[x].x <= t_notePosX && t_notePosX <= timingBoxs[x].y)
                {
                    //Destroy(boxNoteList[i]);
                    boxNoteList[i].GetComponent<Note>().HideNote();
                    boxNoteList.RemoveAt(i);


                    if (x < timingBoxs.Length - 1)
                    {
                        theEffect.NoteHitEffect();
                        theEffect.NoteHitEffect1();
                        theEffect.NoteHitEffect2();
                    }
                        
                        

                    theEffect.JudgementEffect(x);
                    Debug.Log("Hit" + x);

                    theScoreManager.IncreaseScore(x);
                    judgemnetRecord[x]++;

                    return;
                }
            }

        }
        theComboManager.ResetCombo();
        theEffect.JudgementEffect(4);
        MissRecord();
        Debug.Log("Miss");
    }

    public int[] GetJudgementRecord()
    {
        return judgemnetRecord;
    }

    public void MissRecord()
    {
        judgemnetRecord[4]++;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
