using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit_gun1 : MonoBehaviour {
    public int time=4;

	// Use this for initialization
	void Start () {
		
	}
    void OnCollisionEnter(Collision collision) 
    {
        time--;
    }
    // Update is called once per frame
    void Update () {
        if (time == 0)
            Destroy(this.GetComponent<fire1>());
	}
}
