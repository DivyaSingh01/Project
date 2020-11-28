using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Distance_check : MonoBehaviour
{
    [SerializeField]
    private Transform Checkpoint;
    [SerializeField]
    private Text distanceText;
    public Slider Distance;

    private float distance;

    // Update is called once per frame
    void Update()
    {
        distance=(Checkpoint.transform.position.x-transform.position.x);
        Distance.value=distance;
        distanceText.text="Distance: "+distance.ToString("F1")+" meters.";
        if (distance<=0){
            distanceText.text="Finish";
        }
    }
}
