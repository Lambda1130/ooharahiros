using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHantei : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision) //�Ԃ�����������閽�ߕ��J�n
    {
        if (collision.gameObject.CompareTag("Tagutukeru"))//����������Tagutukeru�Ƃ����^�O������I�u�W�F�N�g����Ł`�Ƃ��������̉�
        {
            Destroy(gameObject);//���̃Q�[���I�u�W�F�N�g�����ł�����
        }
    }
}
