using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startMoving : MonoBehaviour
{
    private Rigidbody2D rb;
    private float x,y;
    public float speed=3f;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        x=Random.Range(0,2)== 1 ? -1 :1;
        y=Random.Range(0,2)== 1 ? -1 :1;
        rb.velocity=new Vector2(speed*x,speed*y);
        }


}
