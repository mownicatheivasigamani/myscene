using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mudiyalai : MonoBehaviour {
    public GameObject wytpaint;
    public GameObject blackpaint;
    public GameObject orangepaint;
    public GameObject yellowpaint;
    public static Color currentColor;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("left"))
        {
            Instantiate(wytpaint, transform.position, transform.rotation);
        }
        if (Input.GetKey("down"))
        {
            Instantiate(blackpaint, transform.position, transform.rotation);
        }

        if(Input.GetKey("up"))
        {

            Instantiate(yellowpaint, transform.position, transform.rotation);
        }

        if (Input.GetKey("right"))
        {

            Instantiate(orangepaint, transform.position, transform.rotation);
        }
    }
}
