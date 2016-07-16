using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    public Rigidbody rb;
    public float speed;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float movehorizontal = Input.GetAxis("Horizontal");
        float movevertical = Input.GetAxis("Vertical");
    }
}
