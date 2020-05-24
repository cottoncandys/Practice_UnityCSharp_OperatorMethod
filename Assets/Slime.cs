using UnityEngine;
using UnityEngine.UI;

public class Slime : MonoBehaviour
{
    [Header("顯示訊息")]
    public Text message;
    [Header("蝙蝠")]
    public Bat bat;

    private float hp = 200;
    private float atk = 20;
    private float cure = 10;



    /// <summary>
    /// 攻擊
    /// </summary>
    public void Attack()
    {
       bat.Damage(atk);
    }
    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damage"></param>
    public void Damage(float damage)
    {
        hp -= damage;// hp= hp - damage; = 200史萊姆的血 - 50蝙蝠的攻擊力
        message.text = "<b><color=#94A013>" + gameObject.name + "</color></b> - 受到傷害:" + damage;
        message.text += "\n<b><color=#94A013>" + gameObject.name + "</color></b> - 血量剩下:" + hp;
    }
    
    /// <summary>
    /// 治癒
    /// </summary>
    public void Cure()
    {
        hp += cure;
        message.text = "<b><color=#94A013>" + gameObject.name + "</color></b> - 受到治癒:" + cure;
        message.text += "\n<b><color=#94A013>" + gameObject.name + "</color></b> - 血量剩下:" + hp;
    }
}
