using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb;

    public float speed;
    public float turnSpeed;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") > 0)
        { //if the right arrow is pressed

            transform.Rotate(0, turnSpeed * Time.deltaTime, -10 * Time.deltaTime, Space.World); //and then turn the plane
        }
        if (Input.GetAxis("Horizontal") < 0)
        { //if the left arrow is pressed
            transform.Rotate(0, turnSpeed * Time.deltaTime, 10 * Time.deltaTime, Space.World); //The X-rotation turns the plane - the Z-rotation tilts it
        }
        if (Input.GetAxis("Vertical") > 0)
        { //if the up arrow is pressed
            transform.Rotate(10 * Time.deltaTime, 0, 0);
        }
        if (Input.GetAxis("Vertical") < 0)
        { //if the down arrow is pressed
            transform.Rotate(-10 * Time.deltaTime, 0, 0);
        }

        float movehorizontal = Input.GetAxis("Horizontal");
        float movevertical = Input.GetAxis("Vertical");
        Vector3 force = new Vector3(movehorizontal, 0, movevertical);
        rb.AddForce(force * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            //count = count + 1;\
            //SetCountText();
        }

    }
}
