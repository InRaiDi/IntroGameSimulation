using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // public var
    public float speed = 20;

    // private var
    private Rigidbody2D rBody;

    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        rBody.velocity = new Vector2(speed, 0);
        
    }
}
