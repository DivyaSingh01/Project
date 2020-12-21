using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_lim : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    void Update()
    {
        transform.position=new Vector3(
            Mathf.Clamp(player.position.x,1.2f,340f),
            Mathf.Clamp(player.position.y,1.75f,1.3f),
            transform.position.z);
    }

}
