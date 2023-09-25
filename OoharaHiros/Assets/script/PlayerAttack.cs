using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEditor;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    //ターゲット
    public enemywrok Target;

    // Start is called before the first frame update
    void Start()
    {
        //進行方向
        Vector2 forward = Target.transform.position - transform.position;
        //角度を変換する
        float angle = Mathf.Atan2(forward.x, forward.y) * Mathf.Rad2Deg;
        //角度を代入
        transform.rotation=Quaternion.Euler(0,0,angle);
    }

    // Update is called once per frame
    void Update()
    {
        if(!Target)
        {
            Destroy(gameObject);
            return;
        }

        //移動
        Vector2 forward= Target.transform.position - transform.position;
        Rigidbody2D.position += forward.normalized * Stats.MoveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<enemywrok>(out var enmey)) return;

        float attack = Stats.

         //ターゲットと衝突
         if(Target == enmey)
        {
            Target = null;
        }
         else
        {
            attack /= 2;
        }

         (collision.attack);
    }
}
