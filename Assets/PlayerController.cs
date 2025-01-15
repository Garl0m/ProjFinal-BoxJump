using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject playerObj;
    public Rigidbody rb;

    public float movespeed;

    public bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Control Horizontal and Vertically WAD
        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");

        //Move Left Right and Jump
        if (Mathf.Abs(rb.velocity.x) < 8) 
        {
            rb.AddRelativeForce(Vector3.right * xInput * Time.deltaTime * movespeed);
        }

        if (Input.GetButtonDown("Jump") && grounded == true)
        {
            rb.AddRelativeForce(Vector3.up * 1200);
        }

        if (!grounded)
        {
            rb.AddRelativeForce(Vector3.down * 1500 * Time.deltaTime);
        }
    }

    //Jump reset on ground touch
    private void OnCollisionEnter(Collision collision)
    {
        grounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }

    private void OnCollisionStay(Collision collision)
    {
        grounded = true;
    }


    public void PlayerDeath()
    {
        transform.position = new Vector3(0, 0, 0);
    }
}
