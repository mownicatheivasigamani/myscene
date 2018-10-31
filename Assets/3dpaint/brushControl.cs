using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brushControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        if(paintGM.toolType == "eraser")
        Destroy(gameObject);

    }
}
