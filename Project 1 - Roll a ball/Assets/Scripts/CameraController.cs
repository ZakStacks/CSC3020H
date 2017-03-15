using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;     //want to keep the camera a fixed distance from the player

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;    //the offset is the initial distance to the player
	}
	
	// Update is called once per frame, after all updates have been processed
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
