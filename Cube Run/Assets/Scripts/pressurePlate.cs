using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurePlate : MonoBehaviour
{
    public float boostMultiplier;

    private Rigidbody MainPlayerRB;
    private bool initializedCheck;
    // Start is called before the first frame update
    void Start()
    {
        MainPlayerRB = GameObject.Find("MainPlayer").GetComponent<Rigidbody>();
        if (MainPlayerRB == null)
            initializedCheck = false;
        else
            initializedCheck = true;
    }

    void OnTriggerStay(Collider collider) //collidion detect
    {
        if (initializedCheck)
        {
            MainPlayerRB.AddForce(0, 0, boostMultiplier, ForceMode.Force);
            //Debug.Log("Force boost");  -->debugging purposes 
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
