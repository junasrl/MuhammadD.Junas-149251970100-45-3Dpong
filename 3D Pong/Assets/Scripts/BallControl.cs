using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform center;
    private Rigidbody rig;

    public Vector3 offset;
    public BallSpawnManager bm;

    private GameObject ball;

 
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.AddForce((center.position - transform.position)*3);
        rig.velocity = (center.position - transform.position - offset);
    }


    private void OnCollisionEnter(Collision collisioninfo) 
    {
        string collider_tag = collisioninfo.collider.tag;
        Debug.Log(collider_tag);

        if (collider_tag == "Paddle")
        {
            rig.velocity *= 1.5f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
