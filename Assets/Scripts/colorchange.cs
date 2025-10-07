using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour
{
    private MeshRenderer mr;
    [SerializeField] private Color color;
    // Start is called before the first frame update
    private void Start()
    {
        mr = GetComponent<MeshRenderer>();
        color = mr.material.color;
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="Player")
        {
            mr.material.color = Color.red;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            mr.material.color = color;
        }
    }
}
