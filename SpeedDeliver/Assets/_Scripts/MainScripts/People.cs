using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > -3)
            {
                transform.Translate(Vector3.left * Time.deltaTime * 5, Space.World);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < 3)
            {
                transform.Translate(Vector3.right * Time.deltaTime * 5, Space.World);
            }
        }
	}
}
