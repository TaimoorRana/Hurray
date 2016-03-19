using UnityEngine;
using System.Collections;

public class StudentAI : MonoBehaviour {
	GameManager gameManager;
	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition += transform.forward * 0.25f * Time.deltaTime;

	}

	void OnCollisionEnter(Collision coll) {
        if (coll.gameObject.tag == "Wire"){
        	gameManager.reducePoint();
        	Debug.Log(gameManager.getPoints());
            Destroy(gameObject); 
        }  
    }
}
