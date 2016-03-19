using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
    public Animation anim;
    // Update is called once per frame
    void Update () {
        Movement();
	}
    void Movement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * 4 * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * 4 * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * 4 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * 4 * Time.deltaTime);
        }
    }
}
