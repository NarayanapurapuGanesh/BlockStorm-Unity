using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlayer : MonoBehaviour
{
    [SerializeField] private float yval = 1000f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, yval*Time.deltaTime, 0);
    }
}
