using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolControl : MonoBehaviour {



    public float scalingSpeed = 0.03f;
 //   public float rotationSpeed = 70.0f;
    public float translationSpeed = 5.0f;
    //	public GameObject Model;
    public GameObject Brush;
    public GameObject wytpaint;
    public GameObject yellowpaint;
    public GameObject blackpaint;
    public GameObject orangepaint;
    bool repeatScaleUp = false;
    bool repeatScaleDown = false;
   // bool repeatRotateLeft = false;
   // bool repeatRotateRight = false;
    bool repeatPositionUp = false;
    bool repeatPositionDown = false;
    bool repeatPositionLeft = false;
    bool repeatPositionRight = false;

    void Update()
    {
        if (repeatScaleUp)
        {
            ScaleUpButton();
        }

        if (repeatScaleDown)
        {
            ScaleDownButton();
        }

      
        if (repeatPositionUp)
        {
            PositionUpButton();
        }

        if (repeatPositionDown)
        {
            PositionDownButton();
        }

        if (repeatPositionLeft)
        {
            PositionLeftButton();
        }

        if (repeatPositionRight)
        {
            PositionRightButton();
        }

    }

   

   
   

   

    public void ScaleUpButton()
    {
        // transform.localScale += new Vector3(scalingSpeed, scalingSpeed, scalingSpeed);
        GameObject.FindWithTag("Brush").transform.localScale += new Vector3(scalingSpeed, scalingSpeed, scalingSpeed);
    }

    public void ScaleUpButtonRepeat()
    {
        repeatScaleUp = true;
        Debug.Log("Up");
    }
    public void ScaleDownButtonRepeat()
    {
        repeatScaleDown = true;
        Debug.Log("Down");
    }
    public void PositionDownButtonRepeat()
    {
        repeatPositionDown = true;
    }
    public void PositionUpButtonRepeat()
    {
        repeatPositionUp = true;
    }
    public void PositionLeftButtonRepeat()
    {
        repeatPositionLeft = true;
    }
    public void PositionRightButtonRepeat()
    {
        repeatPositionRight = true;
    }

    public void ScaleUpButtonOff()
    {
        repeatScaleUp = false;
        Debug.Log("Off");
    }
    public void ScaleDownButtonOff()
    {
        repeatScaleDown = false;
        Debug.Log("Off");
    }

  

   
    public void PositionRightButtonOff()
    {
        repeatPositionRight = false;
        Debug.Log("Off");
    }
    public void PositionLeftButtonOff()
    {
        repeatPositionLeft = false;
        Debug.Log("Off");
    }
    public void PositionUpButtonOff()
    {
        repeatPositionUp = false;
        Debug.Log("Off");
    }
    public void PositionDownButtonOff()
    {
        repeatPositionDown = false;
        Debug.Log("Off");
    }

    public void ScaleDownButton()
    {
        // transform.localScale += new Vector3(-scalingSpeed, -scalingSpeed, -scalingSpeed);
        GameObject.FindWithTag("Brush").transform.localScale += new Vector3(-scalingSpeed, -scalingSpeed, -scalingSpeed);
    }

    public void PositionUpButton()
    {
        GameObject.FindWithTag("mc");
    }

    public void PositionDownButton()
    {

        GameObject.FindWithTag("2");
    }

    public void PositionRightButton()
    {
        GameObject.FindWithTag("orange");
    }

    public void PositionLeftButton()
    {
        GameObject.FindWithTag("yellow");  // backward
    }

   
}



