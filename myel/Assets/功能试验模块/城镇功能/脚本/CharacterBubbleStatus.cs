using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBubbleStatus : MonoBehaviour
{
    private CharacterAction action;
    public int amount=1;
    public GameObject bubblePrefab;  //气泡预设物
    private bool start_ = false;
    private void Start()
    {
        action = this.GetComponent<CharacterAction>();
    }

    //ToDo:添加角色场景中气泡按钮

    #region 旧代码
    //public CharacterAction characterAction;
    //public SpriteRenderer  bubble,bubbleContent;
    //public string actName;
    //public Sprite[] textlib;

    //private void Update()
    //{
    //    if (actName == "摸鱼")
    //    {
    //        if (!bubble.gameObject.activeSelf)
    //            bubble.gameObject.SetActive(true);
    //        bubbleContent.sprite = textlib[0];
    //    }
    //    else
    //    {
    //        bubble.gameObject.SetActive(false);
    //    }

    //    CheckFishing();
    //}

    //public void CheckFishing()
    //{
    //    if (characterAction.groundName == "池塘")
    //    {
    //        actName = "摸鱼";
    //    }
    //    else if (actName == "摸鱼")
    //    {
    //        actName = "";
    //    }
    //}
    #endregion

        //计算克隆的位置
    void Calculation_of_position(int amount_)
    {
        switch (amount_)
        {
            case 1:

                break;
            default:
                break;
        }

       

    }
        //克隆消息
    void Clone_Messages()
    {
        switch (amount)
        {
            case 1:

                amount = 0;
                break;
            default:
                break;
        }
    }
    private void Update()
    {
        if (action.groundName =="池塘"&& amount != 0)
        {
            start_ = true;
            Clone_Messages();
        }
    }


}
