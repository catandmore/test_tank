using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit_bullet : MonoBehaviour {
    GameObject clone;
    GameObject Instcube;
    private int a=0;

	// Use this for initialization
	void Start () {
        Instcube = GameObject.Find("Particle System");
	}


    private void OnCollisionEnter(Collision collision)
    {
        a = 1;
    }
   

    // Update is called once per frame
	void Update () {
        if(a==1)
        {
            clone = GameObject.Instantiate(Instcube, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(this.gameObject);
        }
        Destroy(clone, 1);
	}
}
