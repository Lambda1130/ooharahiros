using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class timer : MonoBehaviour
{
    [SerializeField]
    private int minute;
    [SerializeField]
    private float seconds;
    //�@�O��Update�̎��̕b��
    private float oldSeconds;
    //�@�^�C�}�[�\���p�e�L�X�g
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
        //�@�l���ς�����������e�L�X�gUI���X�V
        if ((int)seconds != (int)oldSeconds)
        {
            timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        }
        oldSeconds = seconds;



        
    }
}