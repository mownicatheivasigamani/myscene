using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rubber : MonoBehaviour {

    public GameObject rubb;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("left"))
        {
            Destroy(gameObject);
        }
	}

}
