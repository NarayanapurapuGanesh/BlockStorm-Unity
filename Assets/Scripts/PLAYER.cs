using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER : MonoBehaviour
{
    [SerializeField] private float speed;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xinput = Input.GetAxis("Horizontal")*speed*Time.deltaTime;
        float zinput = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(xinput, 0, zinput);
    }
}
