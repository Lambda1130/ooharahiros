using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class enemywrok : MonoBehaviour
{
    GameObject target1;
    GameObject target2;
   

    private void Start()
    {
        target1 = GameObject.Find("player");
        target2 = GameObject.Find("start");
         
    }
    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position,target2.transform.position, 2 * Time.deltaTime);


        /*
        for(bool i = 1; i <= 2;)
        {
        if(i = 1)
        {
        transform.position = Vector2.MoveTowards(transform.position, target1.transform.position, 2 * Time.deltaTime);
                i++;
        }
        else
        {
        transform.position = Vector2.MoveTowards(transform.position, target2.transform.position, 2 * Time.deltaTime);
                i--;
        }

        }
        */
        Vector3 t1 = transform.position;
        Vector2 p1 = transform.position;
        Vector3 t2=target1.transform.position;
        Vector2 p2 = target2.transform.position;
        Vector2 p3=target1.transform.position;
        Vector2 dir = p1 - p2;
        Vector3 dir2 = t1 - t2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            Destroy(gameObject);
        }
    }
}