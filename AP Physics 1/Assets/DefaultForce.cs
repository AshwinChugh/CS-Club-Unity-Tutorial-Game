using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultForce : MonoBehaviour
{
    public Rigidbody rb;
    public float multiplier;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 0, 1 * multiplier, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
