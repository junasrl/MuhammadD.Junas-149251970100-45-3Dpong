using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControl : MonoBehaviour
{

    public float paddleSpeed;
    public KeyCode leftKey;
    public KeyCode rightKey;
    private Rigidbody rig;

    public string paddleStatus;


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject(GetInput());
    }

    private Vector3 GetInput()
    {
        if (paddleStatus == "z")
        {
        if (Input.GetKey(leftKey))
        {
            return Vector3.left * paddleSpeed;
        }
        if (Input.GetKey(rightKey))
        {
            return Vector3.right * paddleSpeed;
        }

        }

        else if (paddleStatus == "x")
        {
        if (Input.GetKey(leftKey))
        {
            return Vector3.forward * paddleSpeed;
        }
        if (Input.GetKey(rightKey))
        {
            return Vector3.back * paddleSpeed;
        }

        }

        return Vector3.zero;
    }

    private void MoveObject(Vector3 movement)
    {
        rig.velocity = movement;
        Debug.Log("Test: " + movement);
    }

}
