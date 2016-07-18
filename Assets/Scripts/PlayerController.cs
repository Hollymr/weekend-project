using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;
    public float turnSpeed;
    private int count; // count pickups
    public Text countText; //refers to count text in left hand corner of screen 
    public Text winText; // displays when player wins 


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
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
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText ()
    {
            countText.text = "Count: " + count.ToString();
            if (count >= 10)
            {
                winText.text = "You Win!!";
            }
        }

    }

