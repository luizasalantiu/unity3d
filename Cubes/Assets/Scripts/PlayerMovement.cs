using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public GameObject deathParticles;
	public float moveSpeed;
	private float minSpeed = 1;
	private float maxSpeed = 8;
	private Vector3 input;
	private Vector3 spawn;

	// Use this for initialization
	void Start () {
		spawn = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < 0) {
			Die ();
		}
		if (GetComponent<Rigidbody>().velocity.magnitude < maxSpeed) {
			float xMove = Input.GetAxisRaw ("Horizontal") * moveSpeed;
			if (xMove > 0) {
				xMove += minSpeed;
			}
			float zMove = Input.GetAxisRaw ("Vertical") * moveSpeed;
			if (zMove > 0) {
				zMove += minSpeed;
			}
			Vector3 force =  new Vector3 (xMove, 0, zMove);
			GetComponent<Rigidbody>().AddForce(force);
		}	
	}

	void Die(){
		Instantiate(deathParticles, transform.position, Quaternion.identity);
		transform.position = spawn;
	}

	void OnCollisionEnter(Collision other){
		if (other.transform.tag == "Enemy") {
			Die ();
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.transform.tag == "Goal") {
			GameManager.CompleteLevel();
		}
	}
}
