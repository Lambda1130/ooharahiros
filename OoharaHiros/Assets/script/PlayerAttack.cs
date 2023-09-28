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
       



      
      

       
    }
    void OnCollionEnter(Collider collider)
    {
        if(collider.gameObject)
        { 
            Destroy(enemy1);
        }

    }
}
