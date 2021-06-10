using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontBack : MonoBehaviour
{
    public GameObject obstacle;
   
    public float min = 1.0f;
    public float max = 3.0f;
    public float change;
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        min = obstacle.transform.localPosition.x;
        max = obstacle.transform.localPosition.x + change;
    }

    // Update is called once per frame
    void Update()
    {
        obstacle.transform.localPosition = new Vector3(Mathf.PingPong(Time.time * 2*speed, max - min) + min, transform.position.y, transform.position.z);

    }
}
