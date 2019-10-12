using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerManager : MonoBehaviour
{
    public Rigidbody rb;
    public int speedMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, 1*speedMultiplier, ForceMode.Force);
    }
}
