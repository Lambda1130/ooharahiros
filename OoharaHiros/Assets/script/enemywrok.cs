using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemywrok : MonoBehaviour
{
    GameObject target;

    private void Start()
    {
        target = GameObject.Find("player");
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, 2 * Time.deltaTime);
    }
}