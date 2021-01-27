using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBasicScript : MonoBehaviour
{
    public Vector3 rotationVector = new Vector3(0f, 0f, 10.0f);

    private void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.R))
        {
            AnimateRotation();
        }
    }

    private void AnimateRotation()
    {
        Transform t = GetComponent<Transform>();
        t.Rotate(rotationVector);
    }
}
