using UnityEngine;
using System.Collections;

public class groundcheckscript : MonoBehaviour {

	public Moveplayer player;
	
	// Update is called once per frame
	void OnTriggerEnter (Collider triggerd){
		player.setCanJump(true);
	}

	void OnTriggerExit (Collider trigger){
		player.setCanJump(false);
	}
}