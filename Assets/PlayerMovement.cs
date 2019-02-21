using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    private float hor = .0f;
    [SerializeField]
    private float ver = .0f;

    float mult = 1000f;

    private Rigidbody FLWheel;
    private Rigidbody FRWheel;
    private Rigidbody RLWheel;
    private Rigidbody RRWheel;

    private Transform FrontAxis;
    private Transform RearAxis;

    [SerializeField]
    private bool isAWD = false;
    [SerializeField]
    private bool isFWD = true;
    [SerializeField]
    private bool isRWD = false;


    void Start () {
        FrontAxis = transform.Find("FrontAxis").GetComponent<Transform>();
        RearAxis = transform.Find("RearAxis").GetComponent<Transform>();

        FLWheel = FrontAxis.Find("LFWheel").GetComponent<Rigidbody>();
        FRWheel = FrontAxis.Find("RFWheel").GetComponent<Rigidbody>();
        RLWheel = RearAxis.Find("LRWheel").GetComponent<Rigidbody>();
        RRWheel = RearAxis.Find("RRWheel").GetComponent<Rigidbody>();
    }
	
	void FixedUpdate () {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        Vector3 force = new Vector3(ver * mult, 0, 0);

        if(isAWD)
        {
            isFWD = isRWD = true;
        }

        if(isFWD)
        {
            FRWheel.AddTorque(force);
            FLWheel.AddTorque(force);
        }
        if(isRWD)
        {
            RRWheel.AddTorque(force);
            RLWheel.AddTorque(force);
        }
        
    }
}
