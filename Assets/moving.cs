using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{   
    public KeyCode up;
    public KeyCode down;
    [SerializeField] private float speed=4f;
    private Rigidbody2D rb;
    private float dirY;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        
        if(Input.GetKey(up))
        rb.velocity=new Vector2(rb.velocity.x,speed);
        else if  (Input.GetKey(down))
        rb.velocity=new Vector2(rb.velocity.x,-speed);
        else 
                rb.velocity=new Vector2(rb.velocity.x,0);


    
    }
 
}
