using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrokLimit : MonoBehaviour
{
    [SerializeField] float speed;
    //追加　XとYの上限
    float xLimit = 8.5f;
    float yLimit = 4.5f;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector3(x, y, 0) * speed * Time.deltaTime);



        //追加　現在のポジションを保持する
        Vector3 currentPos = transform.position;

        //追加　Mathf.ClampでX,Yの値それぞれが最小～最大の範囲内に収める。
        //範囲を超えていたら範囲内の値を代入する
        currentPos.x = Mathf.Clamp(currentPos.x, -xLimit, xLimit);
        currentPos.y = Mathf.Clamp(currentPos.y, -yLimit, yLimit);

        //追加　positionをcurrentPosにする
        transform.position = currentPos;

    }
}