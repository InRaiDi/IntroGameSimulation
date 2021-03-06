﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float minX, maxX, minY, maxY;
    public GameObject Laser;
    public Transform laserSpawn;
    public float fireRateDelay = 0.25f;

    private Rigidbody2D rBody;
    private float timer = 0;
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

       rBody.velocity = new Vector2(horiz, vert) * speed;
        rBody.position = new Vector2(
            Mathf.Clamp(rBody.position.x, minX, maxX),
            Mathf.Clamp(rBody.position.y, minY, maxY)
            
            );
    }

    void Update()
    {
        //1. check user input

        if (Input.GetAxis("Fire1") > 0 && timer > fireRateDelay)
        {
            // 2. create the object
            GameObject gObj = Instantiate(Laser, laserSpawn.transform.position, laserSpawn.transform.rotation);
            gObj.transform.Rotate(0, 0, -90);
            timer = 0;
        }

        timer += Time.deltaTime;
    }          
}
