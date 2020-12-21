using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Ai : MonoBehaviour
{
    public GameObject player,endUi;
    public Text good,bad;
    public float speed;
    public Animator animator;
    void Start() {
        player.gameObject.SetActive(true);
        endUi.gameObject.SetActive(false);
        animator=GetComponent<Animator>();
    }

    void Update()
    {
        transform.position= Vector2.MoveTowards(transform.position,player.transform.position,speed*Time.deltaTime);
        good.text="You have sanitizer: "+player_run.gcount.ToString();
        bad.text="Handsake and hug: "+player_run.bcount.ToString();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player"){
            player.gameObject.SetActive(false);
            endUi.gameObject.SetActive(true);
            animator.SetBool("fail",true);
            Time.timeScale=0f;
        }
    }
}
