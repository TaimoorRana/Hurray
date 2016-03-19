using UnityEngine;
using System.Collections;

public class StudentAI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition += transform.forward * 0.25f * Time.deltaTime;

	}
}
