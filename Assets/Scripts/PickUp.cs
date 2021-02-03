using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public string pickupTag;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag(pickupTag))
        {
            Destroy(collision.collider.gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
