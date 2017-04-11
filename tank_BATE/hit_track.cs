using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit_track : MonoBehaviour {
    public int _time_ = 1;
	// Use this for initialization
	void Start () {
		
	}
    void OnCollisionEnter(Collision collision)
    {
        _time_--;
    }

    // Update is called once per frame
    void Update () {
        if (_time_ == 0)
        {
            Destroy(this.GetComponent<Move1>());
        }
            
    }
}
