using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class end : MonoBehaviour
{
    public GameObject player,endUi;
    public Text good;
    public Text bad;public Animator animator;
    void Start() {
        player.gameObject.SetActive(true);
        endUi.gameObject.SetActive(false);
        animator=GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player"){
            player.gameObject.SetActive(false);
            endUi.gameObject.SetActive(true);
            animator.SetBool("win",true);
            Time.timeScale=0f;         
        }
    }
    void Update()
    {
        good.text="You have sanitizer: "+player_run.gcount.ToString();
        bad.text="Handsake and hug: "+player_run.bcount.ToString();
    }
}
