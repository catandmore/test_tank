using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_battery1 : MonoBehaviour
{
    public float _rosd = 100f;
    private Transform _move;

    // Use this for initialization
    void Start()
    {
        _move = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("j"))
        {
            _move.Rotate(  0, 0 ,- _rosd * Time.deltaTime);
        }
        if (Input.GetKey("k"))
        {
            _move.Rotate(  0,0, _rosd * Time.deltaTime);
        }

    }
}
