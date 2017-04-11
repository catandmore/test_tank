using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour {

    public float speed = 190.0f;
    public float rosd = 10f;
    private Transform move;

	// Use this for initialization
	void Start () {
        move = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w"))
        {
            float delta = speed;
            transform.Translate(delta * Time.deltaTime,0,0);

        }
        if(Input.GetKey("s"))
        {
            float delta = -speed;
            transform.Translate(delta * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("a"))
        {
            move.Rotate(0, -rosd * Time.deltaTime, 0);
        }
        if (Input.GetKey("d"))
        {
            move.Rotate(0, rosd * Time.deltaTime, 0);
        }

    }
}
