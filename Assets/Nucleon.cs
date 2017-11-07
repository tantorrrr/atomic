using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Nucleon : MonoBehaviour 
{
    public float AttractionForce;
    Rigidbody Body;

    void Awake()
    {
        Body = GetComponent<Rigidbody>();
    }

	// Use this for initialization
	void Start () 
    {

        //Body.AddForce(transform.localPosition * -AttractionForce * 0.1f, ForceMode.VelocityChange);
        //zzdebug.log(transform.localPosition * -AttractionForce);
	}

    
	
	void FixedUpdate () 
    {
        Body.AddForce(transform.localPosition *-AttractionForce);
	}
}


public static class zzdebug
{ 
    public static void log(Vector3 vector)
    {
        Debug.Log("x: " + vector.x + "  y:" + vector.y + "  z:" + vector.z);
    }

}