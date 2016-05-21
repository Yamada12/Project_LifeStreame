using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour {

    public float jumpP;
    bool isGrounded;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            jumping();
        }
    }

    void jumping()
    {
        if (!isGrounded)
        {
            isGrounded = true;
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpP, 0);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "wall")
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        if (other.tag == "Enemy"){
            Application.LoadLevel(Application.loadedLevel);
        }
    }
    

}

