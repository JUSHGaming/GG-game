using UnityEngine;
using System.Collections;

public class Moveplayer : MonoBehaviour {

	public Rigidbody player;
	public float speed = 10f;
	public float jumpHeight = 5f;
	private Vector3 velocity;
	private bool canJump;
	// Update is called once per frame
	void Update () {
		velocity = Vector3.zero;

		velocity += new Vector3 (Input.GetAxis ("Horizontal"), 0, 0) * speed * Time.deltaTime;
		player.transform.position += velocity;
	
		if ((Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.Space)) && canJump) 
		{
			player.velocity += Vector3.up * jumpHeight; 	

		}
	}

	public void setCanJump(bool canJump){
		this.canJump = canJump;
	}
}