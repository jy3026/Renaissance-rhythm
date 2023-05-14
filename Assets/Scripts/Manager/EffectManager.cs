using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    [SerializeField] Animator noteHitAnimator = null;

    [SerializeField]
    Animator noteHit1Animator = null;

    [SerializeField]
    Animator noteHit2Animator = null;

    string hit = "Hit";
    string hit1 = "hit1";
    string hit2 = "hit2";

    [SerializeField]
    Animator judgementAnimator = null;

    [SerializeField]
    UnityEngine.UI.Image judgementImage = null;

    [SerializeField]
    Sprite[] judgementSprite = null;

    public void JudgementEffect(int p_num)
    {
        judgementImage.sprite = judgementSprite[p_num];
        judgementAnimator.SetTrigger(hit);
    }

    public void NoteHitEffect()
    {
        noteHitAnimator.SetTrigger(hit);
    }

    public void NoteHitEffect1()
    {
        noteHit1Animator.SetTrigger(hit1);
    }

    public void NoteHitEffect2()
    {
        noteHit2Animator.SetTrigger(hit2);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
