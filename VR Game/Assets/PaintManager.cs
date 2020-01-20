using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintManager : MonoBehaviour
{
    
    public Transform Paint;
    private Rigidbody rb;
    private float moveZAxis = 0;
    private int timer = 0;
    private float wallDepth;
    private float brushPosY;
    private float brushPosX;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        brushPosY = GameObject.Find("PaintBrush").transform.position.y;
        wallDepth = GameObject.Find("PaintWallHitBox").transform.position.z;
        brushPosX = GameObject.Find("PaintBrush").transform.position.x;

    }

    void FixedUpdate()
    {
        brushPosY = GameObject.Find("PaintBrush").transform.position.y;
        brushPosX = GameObject.Find("PaintBrush").transform.position.x;
       

    }



    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("PaintWallHitBox") && timer >= 5)
        {
            Instantiate(Paint, new Vector3(brushPosX, brushPosY, wallDepth), Quaternion.identity);
            
            timer = 0;
        }
        timer += 1;

    }
}
