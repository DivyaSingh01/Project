using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class player_run : MonoBehaviour
{
    public float movespeed;
    public float jumpForce;
    public Rigidbody2D player;
    public bool ground;
    public LayerMask isGround;
    private Collider2D myColider;
    public Animator animator;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        myColider=  GetComponent<Collider2D>();
        animator=GetComponent<Animator>();
    }
    void Update()
    {
        ground = Physics2D.IsTouchingLayers(myColider,isGround);
        player.velocity=new Vector2(movespeed,player.velocity.y);
        if(CrossPlatformInputManager.GetButtonDown("Jump") ){
            if(ground){
                player.velocity=new Vector2(player.velocity.x,jumpForce);
                //animator.SetBool("jump",true);
            }
            //  animator.SetBool("jump",false);            
        }


        animator.SetFloat("speed",player.velocity.x);
        animator.SetBool("jump",ground);
    }


}

