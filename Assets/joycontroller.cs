using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joycontroller : MonoBehaviour
{
    public GameObject wytpaint;
    public GameObject blackpaint;
    public GameObject orangepaint;
    public GameObject yellowpaint;
    public static Color currentColor;
    // Use this for initialization

    public void lft()
    {
        if (Input.GetKey("left"))
        {
            Instantiate(wytpaint, transform.position, transform.rotation);
        }
    }
    public void down()
    {

        if (Input.GetKey("down"))
        {
            Instantiate(blackpaint, transform.position, transform.rotation);
        }
    }
    public void up()
    {

        if (Input.GetKey("up"))
        {

            Instantiate(yellowpaint, transform.position, transform.rotation);
        }
    }
    public void right()
    {
        if (Input.GetKey("right"))
        {

            Instantiate(orangepaint, transform.position, transform.rotation);
        }

    }
}