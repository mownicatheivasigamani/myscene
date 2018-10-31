using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintGM : MonoBehaviour {
    public Transform baseBrush;
    public KeyCode mouseRight;
    public static string toolType;
	// Use this for initialization
	void Start () {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("down"))
        {

            Application.LoadLevel(Application.loadedLevel);
        }


    }
}
