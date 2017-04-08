using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour {

    public float speed = 190.0f;
    public float rosd = 10f;
    private Transform move;

	// Use this for initialization
	void Start () {
        move = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("up"))
        {
            float delta = speed;
            transform.Translate(0, 0, delta * Time.deltaTime);
        }
        if(Input.GetKey("down"))
        {
            float delta = -speed;
            transform.Translate(0, 0, delta * Time.deltaTime);
        }
        if(Input.GetKey("left"))
        {
            move.Rotate(0, -rosd * Time.deltaTime, 0);
        }
        if (Input.GetKey("right"))
        {
            move.Rotate(0, rosd * Time.deltaTime, 0);
        }

    }
}
