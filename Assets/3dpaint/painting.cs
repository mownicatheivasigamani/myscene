using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class painting : MonoBehaviour {

    public GameObject wytpaint;
    public static Color currentColor;
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            Instantiate(wytpaint, transform.position, transform.rotation);
        }
	}
}
