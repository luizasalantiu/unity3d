using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	public float lifetime; 

	// Use this for initialization
	void Start () {
		// destroy object after a few seconds to keep project clean
		Destroy (gameObject, lifetime);
	}
}
