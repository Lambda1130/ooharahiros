using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrokLimit : MonoBehaviour
{
    [SerializeField] float speed;
    //�ǉ��@X��Y�̏��
    float xLimit = 8.5f;
    float yLimit = 4.5f;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector3(x, y, 0) * speed * Time.deltaTime);



        //�ǉ��@���݂̃|�W�V������ێ�����
        Vector3 currentPos = transform.position;

        //�ǉ��@Mathf.Clamp��X,Y�̒l���ꂼ�ꂪ�ŏ��`�ő�͈͓̔��Ɏ��߂�B
        //�͈͂𒴂��Ă�����͈͓��̒l��������
        currentPos.x = Mathf.Clamp(currentPos.x, -xLimit, xLimit);
        currentPos.y = Mathf.Clamp(currentPos.y, -yLimit, yLimit);

        //�ǉ��@position��currentPos�ɂ���
        transform.position = currentPos;

    }
}