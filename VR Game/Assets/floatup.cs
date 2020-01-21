using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatup : MonoBehaviour
{
    public float floatStrength = 3.5f;
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * floatStrength);
    }
}
