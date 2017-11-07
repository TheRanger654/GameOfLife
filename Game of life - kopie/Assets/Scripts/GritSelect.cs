using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GritSelect : MonoBehaviour {

    public void SwitchColor()
    {
        if (gameObject.GetComponent<Renderer>().material.color == Color.white)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.black;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
