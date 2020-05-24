﻿using UnityEngine;
using UnityEngine.UI;

public class Bat : MonoBehaviour
{
   

    /// <summary>
    /// 血量
    /// </summary>
    private float hp = 150;
    /// <summary>
    /// 攻擊力
    /// </summary>
    private float atk = 50;
    /// <summary>
    /// 治癒量
    /// </summary>
    private float cure = 20;

    [Header("顯示訊息")]
    public Text message;
    [Header("史萊姆")]
    public Slime slime;

    /// <summary>
    /// 攻擊 呼叫史萊姆受傷方法並將攻擊力傳遞給史萊姆
    /// </summary>
    public void Attack()
    {
        // 呼叫 史萊姆 受傷方法(蝙蝠攻擊力)
        slime.Damage(atk);
    }

    /// <summary>
    /// 受傷 帶有一個接收傷害值的參數、扣血、顯示訊息
    /// </summary>
    /// <param name="damage">要接收的傷害值</param>
    public void Damage(float damage)
    {
        hp -= damage;// hp = hp - damage
        message.text = gameObject.name + " - 受到傷害:" + damage;
        message.text ="\n" + gameObject.name + " - 血量剩下:" + hp;
    }

    /// <summary>
    /// 治癒 補血、顯示訊息
    /// </summary>
    public void Cure()
    {
        hp += cure;
        message.text = "<color=#243224>" + gameObject.name + "</color> - 受到治癒:" + cure;
        message.text += "\n<color=#243224>" + gameObject.name + "</color> - 血量剩下:" + hp;
    }
}