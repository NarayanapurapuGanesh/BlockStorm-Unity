using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER : MonoBehaviour
{
    // Start is called before the first frame update
    float xinput;
    float zinput;
    [SerializeFeild] private float speed;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        xinput = Input.GetAxis("Horizontal")*speed*;
        zinput = Input.GetAxis("Vertical");
    }
}
