using UnityEngine;

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;//UI���g���Ƃ��ɏ����܂��B


public class EnemyAttack : MonoBehaviour

{

    //�ő�HP�ƌ��݂�HP�B

    int maxHp = 100;

    int Hp;

    //Slider

    public Slider slider;


    void Start()

    {

        //Slider���ő�ɂ���B

        slider.value = 1;

        //HP���ő�HP�Ɠ����l�ɁB

        Hp = maxHp;

    }


    private void OnTriggerEnter(Collider collider)

    {

        //Enemy�^�O��ݒ肵�Ă���I�u�W�F�N�g�ɐڐG�����Ƃ�

        if (collider.gameObject.tag == "enemy1")

        {

            //HP����1������

            Hp = Hp - 1;


            //HP��Slider�ɔ��f�B

            slider.value = (float)Hp / (float)maxHp; ;


        }

    }

}