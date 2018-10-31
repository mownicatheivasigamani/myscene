using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorpicker : MonoBehaviour {

    public Color[] boColor;
    Color CurrCol;
    SpriteRenderer spriteRenderer;
    

	// Use this for initialization
	void Start () {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void redColor()
    {
       spriteRenderer.color = boColor[0];
        CurrCol = spriteRenderer.color;

    }

    public void greenColor()
    {
        spriteRenderer.color = boColor[1];
        CurrCol = spriteRenderer.color;

    }

    public void yellowColor()
    {

        spriteRenderer.color = boColor[2];
        CurrCol = spriteRenderer.color;
    }

    public void blueColor()
    {

        spriteRenderer.color = boColor[3];
        CurrCol = spriteRenderer.color;
    }


}


