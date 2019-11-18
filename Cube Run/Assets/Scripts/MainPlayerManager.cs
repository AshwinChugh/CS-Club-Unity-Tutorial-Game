using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerManager : MonoBehaviour
{
    public Rigidbody rb;



    private int speedMultiplier = GlobalDataLibrary.speedMultiplier;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, 1*speedMultiplier, ForceMode.Force);
    }
}
