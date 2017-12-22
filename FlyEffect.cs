using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FlyEffect : MonoBehaviour {
   
    public AudioClip myclip;
    // Use this for initialization
    void Start () {
   
    }
	
	// Update is called once per frame
	void Update () {
        // If the left mouse button is released...
        if (Input.GetMouseButtonUp(0) == true)
        {
            this.gameObject.AddComponent<AudioSource>();
            this.GetComponent<AudioSource>().clip = myclip;
            this.GetComponent<AudioSource>().Play();
        }
    }
}
