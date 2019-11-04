using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurePlate : MonoBehaviour
{
    MainPlayerManager rb = new MainPlayerManager();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collider) //collidion detect
    {
        GlobalDataLibrary.speedMultiplier = 300;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
