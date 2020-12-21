using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class player_run : MonoBehaviour
{
    public float movespeed, jumpForce; 
    public Rigidbody2D player;
    public bool ground, Good, Bad;
     public LayerMask isGround;    
    private Collider2D myColider;
    public Animator animator;
    public static int gcount,bcount;

    void Start()
    {
        gcount=0;
        bcount=0;
        player = GetComponent<Rigidbody2D>();
        myColider=  GetComponent<Collider2D>();
        animator=GetComponent<Animator>();
    }
    void Update()
    {
        ground = Physics2D.IsTouchingLayers(myColider,isGround);
        if(Good){
            Debug.Log("Good");
            gcount+=1;
            Good=false;
        }
        if(Bad){
            Debug.Log("bad");
            bcount+=1;
            Bad=false;
        }
        player.velocity=new Vector2(movespeed,player.velocity.y);
        if(CrossPlatformInputManager.GetButtonDown("Jump") ){
            if(ground){
                player.velocity=new Vector2(player.velocity.x,jumpForce);
            }
                        
        }


        animator.SetFloat("speed",player.velocity.x);
        animator.SetBool("jump",ground);
    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="good"){
            Good=true;
            movespeed+=1f;
            Destroy(other.gameObject);
        }
        if(other.tag=="bad"){
            Bad=true;
            movespeed-=1.2f;
            Destroy(other.gameObject);
        }

    }


}

