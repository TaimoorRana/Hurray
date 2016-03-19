using UnityEngine;
using System.Collections;

public class GuardPlayer : MonoBehaviour {
	float moveValVertical;
	float moveValHorizontal;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Move();
	}

	void Move(){
		moveValVertical = Input.GetAxis("Vertical");
		moveValHorizontal = Input.GetAxis("Horizontal");
		if(Input.GetKey(KeyCode.W)){
			transform.localPosition += transform.forward * 0.5f * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.S)){
			transform.localPosition += -transform.forward * 0.5f * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.A)){
			transform.localPosition += -new Vector3(1,0,0) * 0.5f * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.D)){
			transform.localPosition += new Vector3(1,0,0) * 0.5f * Time.deltaTime;
		}
	}

	void OnCollisionEnter(Collision coll) {
        if (coll.gameObject.tag == "Wire"){
            Destroy(coll.gameObject); 
        }  
    }
}
