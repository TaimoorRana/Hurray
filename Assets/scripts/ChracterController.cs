using UnityEngine;
using System.Collections;

public class ChracterController : MonoBehaviour {

    public float maxspeed = 10f;
    bool facingright = false;
    bool facingleft = false;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void FixedUpdate() {


        float move = Input.GetAxis("Vertical");
        float movee = Input.GetAxis("Horizontal");
        if(move!=0)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, move * maxspeed);

        }
        if (movee != 0)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(movee * maxspeed, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);

        }

        if(movee>0 && !facingright)
        {
            flip();

        }
        else if (movee < 0 && facingright )
        {
            flip();

        }



    }

    void flip()
    {
        facingright = !facingright;
        Vector3 thescale = transform.localScale;
        thescale.x *= -1;
        transform.localScale = thescale; 
       
    }
}
