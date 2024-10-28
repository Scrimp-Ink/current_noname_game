using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfallow : MonoBehaviour
{
    public float fallowspeed = 2f;
    public Transform target;    
    public float yOffset = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newpos = new Vector3(target.position.x, target.position.y + yOffset, -10f);
        transform.position = Vector3.Slerp(transform.position, newpos, fallowspeed*Time.deltaTime);
    }
}
