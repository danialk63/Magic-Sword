using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeUp : MonoBehaviour
{
	private Vector2 startTouchPosition, endTouchPosition;
	private Rigidbody rb;
	private float jumpForce = 410f;
	
	private bool jumpAllowed = false;

	// Use this for initialization
	private void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	private void Update()
	{
		SwipeCheck();
	}

	private void FixedUpdate()
	{
		JumpIfAllowed();
	}
	public float _swipeThreshold = 1.7f;
	private void SwipeCheck()
	{
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
			startTouchPosition = Input.GetTouch(0).position;

		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
		{
			endTouchPosition = Input.GetTouch(0).position;
			if (endTouchPosition.y > (startTouchPosition.y+_swipeThreshold) && rb.velocity.y == 0)
				jumpAllowed = true;
		}
	}

	private void JumpIfAllowed()
	{
		if (jumpAllowed)
		{
			rb.AddForce(Vector2.up * jumpForce);
			//GetComponent<Animator>().Play("Jump");
			jumpAllowed = false;
		}
	}

}
