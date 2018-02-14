using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    [SerializeField]
    private float speed = 1f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f * speed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f * speed;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        /*if(Input.GetKey("w"))
        {
            transform.position += Vector3.forward*speed*Time.deltaTime;
        }
        if(Input.GetKey("a"))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if(Input.GetKey("d"))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if(Input.GetKey("s"))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }*/
    }
}
