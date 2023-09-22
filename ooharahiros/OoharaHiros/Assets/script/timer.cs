using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class timer : MonoBehaviour
{
    [SerializeField]
    private int minute;
    [SerializeField]
    private float seconds;
    //　前のUpdateの時の秒数
    private float oldSeconds;
    //　タイマー表示用テキスト
    private Text timerText;



    


    GameObject player;



    void Start()
    {
        minute = 5;
        seconds = 0f;
        oldSeconds = 0f;
        timerText = GetComponentInChildren<Text>();



        this.player = GameObject.Find("player");
    }



    void Update()
    {
        seconds -= Time.deltaTime;
        if (seconds < 0f)
        {
            minute--;
            seconds = seconds + 60;
        }
        //　値が変わった時だけテキストUIを更新
        if ((int)seconds != (int)oldSeconds)
        {
            timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        }
        oldSeconds = seconds;



        
    }
}