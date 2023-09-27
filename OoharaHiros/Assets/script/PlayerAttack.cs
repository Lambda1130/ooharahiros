using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.CinemachineTargetGroup;
using static UnityEngine.GraphicsBuffer;

public class PlayerAttack : MonoBehaviour
{
    GameObject enemy1;

    private void Start()
    {
       
    }
    void Update()
    {
       



        if(transform.position.x<-5.0f)
        {
            Destroy(enemy1);
        }


       
    }
}
