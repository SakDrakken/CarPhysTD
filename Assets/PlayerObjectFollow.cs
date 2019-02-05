using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObjectFollow : MonoBehaviour {

    [SerializeField]
    Transform player;

	void LateUpdate () {
        transform.position = player.transform.position; 
	}
}
