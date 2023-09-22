using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
namespace CountDownHP
{
    public class EnemyStatus : MonoBehaviour
    {

        //�@HP
        [SerializeField]
        private int hp = 100;
        //�@HP����x���炵�Ă���̌o�ߎ���
        private float countTime = 0f;
        //�@����HP�����炷�܂ł̎���
        [SerializeField]
        private float nextCountTime = 0f;
        //�@HP�\���e�L�X�g
        private Text hpText;
        //�@���݂̃_���[�W��
        private int damage = 0;

        void Start()
        {
            hpText = GetComponentInChildren<Text>();
            hpText.text = hp.ToString();
        }

        void Update()
        {
            //�@�_���[�W�Ȃ���Ή������Ȃ�
            if (damage == 0)
            {
                return;
            }
            //�@���Ɍ��炷���Ԃ�������
            if (countTime >= nextCountTime)
            {

                //�@�_���[�W�ʂ�10�Ŋ���������HP���猸�炷
                var tempDamage = damage / 10;
                //�@����0�ɂȂ�����]������炷
                if (tempDamage == 0)
                {
                    tempDamage = damage % 10;
                }
                hp -= tempDamage;
                hpText.text = hp.ToString();
                damage -= tempDamage;

                countTime = 0f;

                //�@HP��0�ȉ��ɂȂ�����G���폜
                if (hp <= 0)
                {
                    Destroy(gameObject);
                }
            }
            countTime += Time.deltaTime;
        }

        //�@�_���[�W�l��ǉ����郁�\�b�h
        public void SetDamage(int damage)
        {
            this.damage += damage;
            countTime = 0f;
        }
    }
}
