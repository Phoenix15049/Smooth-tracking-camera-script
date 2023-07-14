using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	[SerializeField] private Vector3 offset;
	[SerializeField] private float smoothness = 0.3f;
	private Vector3 cameraVelocity = Vector3.zero; 
	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag("Player").transform;
		offset = transform.position - target.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void LateUpdate()
	{
		Vector3 targetposition = target.position + offset;
		transform.position = Vector3.SmoothDamp(transform.position, targetposition, ref cameraVelocity, smoothness);
		transform.LookAt(target);


    }
}
