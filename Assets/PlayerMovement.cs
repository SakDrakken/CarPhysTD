using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    private float hor = .0f;
    [SerializeField]
    private float ver = .0f;

    float mult = 1000f;

    private Rigidbody player;

    void Start () {
        player = GetComponentInChildren<Rigidbody>();
	}
	
	void FixedUpdate () {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        Vector3 force = new Vector3(ver * mult, 0, ver * mult);
        Vector3 turnforce = new Vector3(0, hor * mult, 0);
        player.AddRelativeTorque(force);
        player.AddTorque(turnforce);
    }
}
