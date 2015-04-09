using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour {
	public Transform[] patrolPoints;
	private int currentPoint;
	public float moveSpeed;

	// Use this for initialization
	void Start () {
		transform.position = patrolPoints[0].position;
		currentPoint = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position == patrolPoints[currentPoint].position) {
			if (currentPoint != patrolPoints.Length-1) {
				currentPoint++;
			} else {
				currentPoint = 0;
			}
		}
		transform.position = Vector3.MoveTowards (transform.position, patrolPoints [currentPoint].position, moveSpeed * Time.deltaTime);
	}
}
