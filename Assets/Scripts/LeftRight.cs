using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LeftRight : MonoBehaviour
{
        
    public float min = 1.0f;
    public float max = 3.0f;
    public float change;
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        min = transform.localPosition.z;
        max = transform.localPosition.z + change;
    }

    // Update is called once per frame0
    void Update()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, Mathf.PingPong(Time.time * 2*speed, max - min) + min);
    }
}
