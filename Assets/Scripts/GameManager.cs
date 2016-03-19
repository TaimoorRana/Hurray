using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	int points = 0;
	public GameObject student;
	public GameObject[] location;
	public int studentsCount = 0;
	// Use this for initialization
	void Start () {
		int x = 0;
		while(studentsCount != 0){
			if(x >= location.Length)
				x = 0;
			Instantiate(student,location[x++].transform.position,Quaternion.identity);
			points++;
			studentsCount--;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void reducePoint(){
		points--;
	}

	public int getPoints(){
		return points;
	}
}
