using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEditor;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    //�^�[�Q�b�g
    public enemywrok Target;

    // Start is called before the first frame update
    void Start()
    {
        //�i�s����
        Vector2 forward = Target.transform.position - transform.position;
        //�p�x��ϊ�����
        float angle = Mathf.Atan2(forward.x, forward.y) * Mathf.Rad2Deg;
        //�p�x����
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

        //�ړ�
        Vector2 forward= Target.transform.position - transform.position;
        Rigidbody2D.position += forward.normalized * Stats.MoveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<enemywrok>(out var enmey)) return;

        float attack = Stats.

         //�^�[�Q�b�g�ƏՓ�
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
