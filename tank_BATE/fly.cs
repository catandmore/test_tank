using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour {
    Transform _fly;
    public float speed;
	// Use this for initialization
	void Start () {
        _fly = GetComponent<Transform>();
        speed = 500f;
	}
	
	// Update is called once per frame
	void Update () {
        _fly.Translate(0, speed * Time.deltaTime,0);
   
    }

}
