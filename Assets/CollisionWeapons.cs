using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWeapons : MonoBehaviour
{
    [SerializeField] private string triggeringTag;
    private void OnTriggerEnter(Collider other)
    {


        if (other.tag == triggeringTag && enabled && Input.GetKeyDown(KeyCode.Z))
        {
            
        }



    }
}
