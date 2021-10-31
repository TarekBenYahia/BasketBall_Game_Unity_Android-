using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMvt : MonoBehaviour
{
    private Rigidbody rb;
    public int speed;
    public int SidewaysSpeed;
    public float distToGround = 0.5f;
    public AudioSource Bounce;

 

    public void PlayBounce()
    {
        Bounce.Play();
    }
    bool isGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, distToGround);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();

       
    }

    // Update is called once per frame
    void Update()
    {
        float db = 20 * Mathf.Log10(Mathf.Abs(MicInput.MicLoudness));
        //Debug.Log("'Volume is :' " + db);
        if (db < 1 && db > -25f)
        {
            rb.AddForce(0, -(db/5) * SidewaysSpeed * Time.deltaTime,  30);
        }
       
    }

    void FixedUpdate()
    {/*
        if (isGrounded())
        {
            PlayBounce();
        }*/
        //UpArrow

        
        rb.AddForce(0, Input.GetAxis("Vertical") * SidewaysSpeed * Time.deltaTime, Input.GetAxis("Vertical") * 30);

    }

   
}
