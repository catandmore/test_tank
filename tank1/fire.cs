using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    private int time = 0;
    public int reload = 100;
    private GameObject bullet;
    private GameObject position;
    private GameObject clone;
    
    void Start()
    {
        bullet = GameObject.Find("bullet");
        position = GameObject.Find("GameObject");
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Debug.Log(Time.deltaTime);
        time++;
    }
    void Update()
    {
        if (Input.GetKey("space") && time >= reload)
        {
            clone = GameObject.Instantiate(bullet, position.transform.position, position.transform.rotation);
            clone.transform.localScale = new Vector3(1.072882f, 3.872993f, 1.22984f);
            clone.AddComponent<hit_bullet>();
            time = 0;


        }
    }



}
