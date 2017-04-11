using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit_armor_front1 : MonoBehaviour {
    public int _time = 3;

	// Use this for initialization
	void Start () {
		
	}
    void OnCollisionEnter(Collision collision)
    {
        _time--;
    }
    // Update is called once per frame
    void Update () {
        if(_time == 0)
            Destroy(this.gameObject);
    }
}
