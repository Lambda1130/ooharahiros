using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
namespace CountDownHP
{
    public class EnemyStatus : MonoBehaviour
    {

        //　HP
        [SerializeField]
        private int hp = 100;
        //　HPを一度減らしてからの経過時間
        private float countTime = 0f;
        //　次にHPを減らすまでの時間
        [SerializeField]
        private float nextCountTime = 0f;
        //　HP表示テキスト
        private Text hpText;
        //　現在のダメージ量
        private int damage = 0;

        void Start()
        {
            hpText = GetComponentInChildren<Text>();
            hpText.text = hp.ToString();
        }

        void Update()
        {
            //　ダメージなければ何もしない
            if (damage == 0)
            {
                return;
            }
            //　次に減らす時間がきたら
            if (countTime >= nextCountTime)
            {

                //　ダメージ量を10で割った商をHPから減らす
                var tempDamage = damage / 10;
                //　商が0になったら余りを減らす
                if (tempDamage == 0)
                {
                    tempDamage = damage % 10;
                }
                hp -= tempDamage;
                hpText.text = hp.ToString();
                damage -= tempDamage;

                countTime = 0f;

                //　HPが0以下になったら敵を削除
                if (hp <= 0)
                {
                    Destroy(gameObject);
                }
            }
            countTime += Time.deltaTime;
        }

        //　ダメージ値を追加するメソッド
        public void SetDamage(int damage)
        {
            this.damage += damage;
            countTime = 0f;
        }
    }
}
