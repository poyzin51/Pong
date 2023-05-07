using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving2 : MonoBehaviour
{   [SerializeField]private GameObject gotop;
    [SerializeField] private LayerMask jumpableGround;

    [SerializeField]private GameObject goBot;
    private BoxCollider2D coll;
    private BoxCollider2D topColl;
    private BoxCollider2D botColl; 
    [SerializeField] private float speed=4f;
    private Rigidbody2D rb;
    private float dirY;
    void Start()
    {
        coll=GetComponent<BoxCollider2D>();
        rb=GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        
        if(Input.GetKeyUp("z"))
        rb.velocity=new Vector2(rb.velocity.x,dirY*speed);
        else if  (Input.GetKeyUp("s"))
        rb.velocity=new Vector2(-rb.velocity.x,dirY*speed);

    
    }
 
}
