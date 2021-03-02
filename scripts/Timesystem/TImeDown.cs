using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
///倒计时设置
/// </summary>
public class TImeDown : MonoBehaviour
{
    public int realB;
    public int AllTime;
    private int i ;
    private int Minute;
    private int Second;
    private Text Downtext; 
    private void Awake()
    {
        AllTime = 120;
        i = 1;
        Minute = 2;
        Second = 0;
        this.GetComponent<Text>().text = "02:00";
    }
    private void Start()
    {
        Downtext = this.GetComponent<Text>();
    }
    private void Update()
    {
        TimeDown();
    }

    private void TimeDown()
    {
        realB = (int)Time.time;
        if (realB == i && i <= 120)
        {
            Minute = (120 - realB) / 60;
            Second = (120 - realB) % 60;
            i++;
            Downtext.text = string.Format("{0:d2}:{1:d2}", Minute, Second);
        }
    }          //时间倒计时
}
