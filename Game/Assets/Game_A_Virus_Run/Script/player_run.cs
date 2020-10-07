using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_run : MonoBehaviour
{
    public float movespeed = 5f;
    public float jumpForce = 5f;
    public Rigidbody2D player;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        // Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),0f,0f);
        // transform.position += movement*Time.deltaTime*movespeed;
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement,0,0)*Time.deltaTime*movespeed;

        // if(!Mathf.Approximately(0,movement))
        // {
        //     transform.rotation = movement > 0 ? Quaternion.Euler(0,180,0) : Quaternion.identity;
        // }

        if(Input.GetButtonDown("Jump")&& Mathf.Abs(player.velocity.y)<0.001f)
        {
            player.AddForce(new Vector2(0,jumpForce),ForceMode2D.Impulse);
        }
    }

}

