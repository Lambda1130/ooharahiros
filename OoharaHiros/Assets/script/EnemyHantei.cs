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
    private void OnCollisionEnter(Collision collision) //ぶつかったら消える命令文開始
    {
        if (collision.gameObject.CompareTag("Tagutukeru"))//さっきつけたTagutukeruというタグがあるオブジェクト限定で～という条件の下
        {
            Destroy(gameObject);//このゲームオブジェクトを消滅させる
        }
    }
}
