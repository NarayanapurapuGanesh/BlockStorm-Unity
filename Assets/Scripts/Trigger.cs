using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
     private Rigidbody rig1;
   
    public GameObject trig1;
    
    // Start is called before the first frame update
    void Start()
    {
        rig1 = trig1.gameObject.GetComponent<Rigidbody>();
       
        rig1.useGravity = false;
      
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            rig1.useGravity = true;        
        }
    }
}
