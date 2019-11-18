using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerManager : MonoBehaviour
{
    public Rigidbody rb;
    private float health;

    void Start()
    {
        
    }



    private int speedMultiplier = GlobalDataLibrary.speedMultiplier;

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            var position = transform.position;
            position.x -= 0.1f;
            transform.position = position;
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            var position = transform.position;
            position.x += 0.1f;
            transform.position = position;
        }

        rb.AddForce(0, 0, 1*speedMultiplier, ForceMode.Force);
    }
}
