using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionSounds : MonoBehaviour
{
    private MeshRenderer m;
    public AudioSource Hit;
    public AudioSource PanelHit;
    public AudioSource GroundHit;
    public GameObject ballon;


  
    // Start is called before the first frame update
    void Start()
    {
        m = this.GetComponent<MeshRenderer>();

      
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "poteau")
        {
            Hit.Play();
        }
        if (collision.collider.tag == "panel")
        {
            PanelHit.Play();
        }
        if (collision.collider.tag == "ground")
        {
            GroundHit.Play();
        }
    }

    
}
